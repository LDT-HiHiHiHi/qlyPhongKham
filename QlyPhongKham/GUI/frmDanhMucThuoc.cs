using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
namespace GUI
{
    public partial class frmDanhMucThuoc : Form_Edit
    {
        public bool flag = false;
        BUS_DMThuoc bus_dmt = new BUS_DMThuoc();
        public frmDanhMucThuoc()
        {
            InitializeComponent();
            menu.PrimaryColor = Color.FromArgb(30, 144, 255);
        }

        private void frmDanhMucThuoc_Activated(object sender, EventArgs e)
        {
            //Activate the corresponding Tabpage
            tabCtrl.SelectedTab = tabPag;

            if (!tabCtrl.Visible)
            {
                tabCtrl.Visible = true;
            }
        }

        private void frmDanhMucThuoc_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Destroy the corresponding Tabpage when closing MDI child form
            this.tabPag.Dispose();
            //If no Tabpage left
            if (!tabCtrl.HasChildren)
            {
                tabCtrl.Visible = false;
            }
        }

        private void frmDanhMucThuoc_Load(object sender, EventArgs e)
        {
            txtTen.Texts = txtDG.Texts = txtHSD.Texts = txtDVT.Texts = txtSL.Texts = lbNgay.Text = string.Empty;
            dgvThuoc.DataSource = bus_dmt.getListThuoc();
            btnXoa.Enabled = false;
        }

        private void txtSL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDG_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(flag)
            {
                txtTen.Texts = txtDG.Texts = txtHSD.Texts = txtDVT.Texts = txtSL.Texts = lbNgay.Text = string.Empty;
                btnThem.Text = "Thêm";
                btnThem.BackColor = Color.MediumSeaGreen;
                flag = false;
                return;
            }
            txtTen.Focus();
            txtTen.Texts = txtDG.Texts = txtHSD.Texts = txtDVT.Texts = txtSL.Texts = lbNgay.Text = string.Empty;
            lbNgay.Text = DateTime.Today.Day + "/" + DateTime.Today.Month + "/" + DateTime.Today.Year;
            btnThem.Text = "Hủy";
            btnThem.BackColor = Color.Red;
            flag = true;
        }

        private void dgvThuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvThuoc.CurrentRow == null)
                return;
            btnXoa.Enabled = true;  

            string mat = dgvThuoc.CurrentRow.Cells["MAT"].Value.ToString();
            DateTime? day = bus_dmt.getDay(mat);

            txtTen.Texts = dgvThuoc.CurrentRow.Cells["TENT"].Value.ToString();
            txtHSD.Texts = dgvThuoc.CurrentRow.Cells["HSD"].Value.ToString();
            txtSL.Texts = dgvThuoc.CurrentRow.Cells["SL"].Value.ToString();
            txtDVT.Texts = dgvThuoc.CurrentRow.Cells["DVT"].Value.ToString();
            lbNgay.Text = day.Value.Day + "/" + day.Value.Month + "/" + day.Value.Year;
            txtDG.Texts = dgvThuoc.CurrentRow.Cells["DG"].Value.ToString();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtTen.Texts))
            {
                errorProvider1.SetError(txtTen, "Vui lòng nhập tên thuốc");
                txtTen.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtHSD.Texts))
            {
                errorProvider1.SetError(txtHSD ,"Vui lòng nhập hạn sử dụng");
                txtHSD.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtSL.Texts))
            {
                errorProvider1.SetError(txtSL, "Vui lòng nhập số lượng thuốc");
                txtSL.Focus();
                return;
            }

            int sl = int.Parse(txtSL.Texts);
            if(sl== 0)
            {
                errorProvider1.SetError(txtSL, "Số lượng ko hợp lệ !");
                txtSL.Focus();
                txtSL.Texts = "1";
                return;
            }    

            if (string.IsNullOrEmpty(txtDVT.Texts))
            {
                errorProvider1.SetError(txtDVT, "Vui lòng nhập đơn vị tính");
                txtDVT.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtDG.Texts))
            {
                errorProvider1.SetError(txtDG, "Vui lòng nhập đơn giá");
                txtDG.Focus();
                return;
            }

            double dg = double.Parse(txtDG.Texts);
            if (dg == 0)
            {
                errorProvider1.SetError(txtSL, "Đơn giá ko hợp lệ !");
                txtDG.Focus();
                txtDG.Texts = "1000";
                return;
            }
            string mat = dgvThuoc.CurrentRow.Cells["MAT"].Value.ToString();
            string dvt = txtDVT.Texts;
            string hsd = txtHSD.Texts;
            string tent = txtTen.Texts;

            DMTHUOC thuoc = new DMTHUOC
            {
                MAT = mat,
                TENTHUOC = tent,
                SOLUONG = sl,
                HSD = hsd,
                DONVITINH = dvt
            };

            DONGIA_THUOC donggia = new DONGIA_THUOC
            {
                MAT = mat,
                GIA = dg,
                NGCAPNHAT = DateTime.Today
            };

            if (!flag)
            {
                if (bus_dmt.capNhatThuoc(thuoc, donggia))
                {
                    Program.AlertMessage("Cập nhật thuốc thành công", MessageBoxIcon.Information);
                    this.OnLoad(e);
                    return;
                }
                Program.AlertMessage("Đã xảy ra lỗi 1 !", MessageBoxIcon.Error);
                return;
            }
            thuoc.MAT = donggia.MAT = "T" + Program.phatSinhMaTuDong();

            if (bus_dmt.themThuoc(thuoc, donggia))
            {
                Program.AlertMessage("Thêm thuốc thành công", MessageBoxIcon.Information);
                this.OnLoad(e);
                return;
            }
            Program.AlertMessage("Đã xảy ra lỗi 2 !", MessageBoxIcon.Error);
            return;
        }

        private void txtTen__TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTen.Texts))
            {
                errorProvider1.Clear();
            }
        }

        private void txtHSD__TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtHSD.Texts))
            {
                errorProvider1.Clear();
            }
        }

        private void txtSL__TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSL.Texts))
            {
                errorProvider1.Clear();
            }
        }

        private void txtDVT__TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDVT.Texts))
            {
                errorProvider1.Clear();
            }
        }

        private void txtDG__TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDG.Texts))
            {
                errorProvider1.Clear();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string mat = dgvThuoc.CurrentRow.Cells["MAT"].Value.ToString();
            if (bus_dmt.checkThuoc(mat) > 0)
            {
                Program.AlertMessage("Thuốc đang tồn tại trong chi tiết thuốc", MessageBoxIcon.Information);
                return;
            }

            DialogResult r;
            r = MessageBox.Show("Bạn có chắc chắn muốn xóa " + dgvThuoc.CurrentRow.Cells["TENT"].Value.ToString() + " ?", "Thông báo",

            MessageBoxButtons.YesNo, MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button1);

            if (r == DialogResult.Yes)
            {
                if(bus_dmt.xoaThuoc(mat))
                {
                    Program.AlertMessage("Xóa thuốc thuốc thành công", MessageBoxIcon.Information);
                    this.OnLoad(e);
                    return;
                }
                Program.AlertMessage("Đã xảy ra lỗi 3 !", MessageBoxIcon.Error);
                return;
            }
        }

        private void textBoxCustom1__TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTimKiem.Texts))
            {
                dgvThuoc.DataSource = bus_dmt.getListThuoc();
                return;
            }
            dgvThuoc.DataSource = bus_dmt.timKiemThuoc(txtTimKiem.Texts);
        }
    }
}
