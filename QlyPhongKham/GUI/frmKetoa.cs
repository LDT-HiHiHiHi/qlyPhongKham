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
    public partial class frmKetoa : Form
    {
        BUS_KeToa bus_kt = new BUS_KeToa();
        public frmKetoa()
        {
            InitializeComponent();
            lbHeader.Text = "TOA THUỐC CỦA BỆNH NHÂN " + frmKhamBenh.tenBN;
            menu.PrimaryColor = Color.FromArgb(30, 144, 255);
        }

        private void txtNgay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTenThuoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSoVien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void frmKetoa_Load(object sender, EventArgs e)
        {
            btnXoa.Enabled = false;
            txtTenThuoc.Texts = txtSoVien.Texts = string.Empty;
            cboBuoi.Texts = "1";
            string mals = frmKhamBenh.MALS;
            btnLuu.Enabled = false;
            dgvThuoc.DataSource = bus_kt.getListThuoc();
            if(bus_kt.checkTT(mals) > 0)
            {
                string matt = bus_kt.getMaToaThuoc(mals);
                List<ToaThuoc> list = bus_kt.getListToaThuoc(matt);
                if (list != null)
                {
                    dgvToaThuoc.DataSource = list;
                }    
                else
                {
                    DataTable dt = new DataTable();
                    dt.Columns.Add(new DataColumn("MATT", typeof(string)));
                    dt.Columns.Add(new DataColumn("TENT", typeof(string)));
                    dt.Columns.Add(new DataColumn("SB", typeof(int)));
                    dt.Columns.Add(new DataColumn("SL", typeof(int)));
                    dt.Columns.Add(new DataColumn("TONG", typeof(int)));
                    dt.Columns.Add(new DataColumn("DONGIA", typeof(double)));
                    dgvToaThuoc.DataSource = dt;
                }    
            }
            this.KeyDown += FrmKetoa_KeyDown;
        }

        private void FrmKetoa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnTimKiem_Click(sender, e);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtTimKiem.Texts))
            {
                dgvThuoc.DataSource = bus_kt.getListThuoc();
                return;
            }
            dgvThuoc.DataSource = bus_kt.timKiemThuoc(txtTimKiem.Texts);
        }

        private void dgvThuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnLuu.Enabled = true;
            txtTenThuoc.Texts = dgvThuoc.CurrentRow.Cells["TENT"].Value.ToString();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string mals = frmKhamBenh.MALS;
            
            if(string.IsNullOrEmpty(txtNgay.Texts))
            {
                errorProvider1.SetError(txtNgay, "Vui lòng nhập giá trị");
                txtNgay.Focus();
                return;
            }
            errorProvider1.Clear();

            if (string.IsNullOrEmpty(txtSoVien.Texts))
            {
                errorProvider2.SetError(txtSoVien, "Vui lòng nhập giá trị");
                txtSoVien.Focus();
                return;
            }
            errorProvider2.Clear();

            int sb = int.Parse(cboBuoi.Texts);
            int songay = int.Parse(txtNgay.Texts);
            int sl = int.Parse(txtSoVien.Texts);

            if (songay == 0)
            {
                errorProvider1.SetError(txtNgay, "Giá trị không hợp lệ");
                txtNgay.Texts = "1";
                txtNgay.Focus();
                txtNgay.SelectAll();
                return;
            }
            errorProvider1.Clear();

            if (sl == 0)
            {
                errorProvider2.SetError(txtSoVien, "Giá trị không hợp lệ");
                txtSoVien.Texts = "1";
                txtSoVien.Focus();
                txtSoVien.SelectAll();
                return;
            }
            errorProvider2.Clear();
            string mat = bus_kt.getMaT(txtTenThuoc.Texts);
            int tong = sl * sb * songay;
            if (bus_kt.checkTT(mals) > 0)
            {
                
                string matt = bus_kt.getMaToaThuoc(mals);
                CT_TOATHUOC ct = new CT_TOATHUOC
                {
                    MATT = matt,
                    MAT = mat,
                    SOBUOI = sb,
                    SOLUONGUONG = sl,
                    TONGSOLUONG = tong
                };
                if(bus_kt.checkCTTT(matt,mat) > 0)
                {
                    //int slcu = bus_kt.getSoLuong(matt, mat);
                    if (bus_kt.updateCT(ct))
                    {
                        if(!bus_kt.capNhatThanhTien(matt))
                        {
                            Program.AlertMessage("Đã xảy ra lỗi cập nhật 1", MessageBoxIcon.Error);
                        }
                        //if (!bus_kt.capNhatSoLuong(mat,(tong - slcu))) 
                        //{
                        //    Program.AlertMessage("Đã xảy ra lỗi cập nhật 2", MessageBoxIcon.Error);
                        //}    
                        Program.AlertMessage("Cập nhật thành công !", MessageBoxIcon.Information);
                        this.OnLoad(e);
                        return;
                    }
                    Program.AlertMessage("Đã xảy ra lỗi", MessageBoxIcon.Error);
                    return;
                }    
                if(bus_kt.themToaThuoc_DaCo(matt,mat,sb,sl,tong))
                {
                    if (!bus_kt.capNhatThanhTien(matt))
                    {
                        Program.AlertMessage("Đã xảy ra lỗi cập nhật 3", MessageBoxIcon.Error);
                    }
                    int slcu = bus_kt.getSoLuong(matt, mat);
                    //if (!bus_kt.capNhatSoLuong(mat, tong)) 
                    //{
                    //    Program.AlertMessage("Đã xảy ra lỗi cập nhật 4", MessageBoxIcon.Error);
                    //}
                    Program.AlertMessage("Thêm thành công", MessageBoxIcon.Information);
                    this.OnLoad(e);
                    return;
                }
                Program.AlertMessage("Đã xảy ra lỗi", MessageBoxIcon.Error);
                return;
            }
            string mattm = "TT" + Program.phatSinhMaTuDong();
            if(bus_kt.themToaThuoc(mals,mattm,mat,sb,sl,tong))
            {
                if (!bus_kt.capNhatThanhTien(mattm))
                {
                    Program.AlertMessage("Đã xảy ra lỗi cập nhật 5", MessageBoxIcon.Error);
                }
                //if (!bus_kt.capNhatSoLuong(mat, tong)) 
                //{
                //    Program.AlertMessage("Đã xảy ra lỗi cập nhật 6", MessageBoxIcon.Error);
                //}
                Program.AlertMessage("Thêm mới thành công", MessageBoxIcon.Information);
                this.OnLoad(e);
                return;
            }
            Program.AlertMessage("Đã xảy ra lỗi", MessageBoxIcon.Error);
            return;
        }

        private void dgvToaThuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnLuu.Enabled = btnXoa.Enabled = true;
            txtSoVien.Texts = dgvToaThuoc.CurrentRow.Cells["SOVIEN"].Value.ToString();
            txtTenThuoc.Texts = dgvToaThuoc.CurrentRow.Cells["TENTT"].Value.ToString();
            cboBuoi.Texts = dgvToaThuoc.CurrentRow.Cells["SOBUOI"].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string matt = dgvToaThuoc.CurrentRow.Cells["MATT"].Value.ToString();
            string mat = bus_kt.getMaT(dgvToaThuoc.CurrentRow.Cells["TENTT"].Value.ToString());
            int tong = bus_kt.getSoLuong(matt, mat);
            if (bus_kt.xoaCT(matt, mat))
            {
                if (!bus_kt.capNhatThanhTien(matt))
                {
                    Program.AlertMessage("Đã xảy ra lỗi cập nhật 7", MessageBoxIcon.Error);
                }
                if (!bus_kt.capNhatSoLuong(mat, -tong))
                {
                    Program.AlertMessage("Đã xảy ra lỗi cập nhật 8", MessageBoxIcon.Error);
                }
                Program.AlertMessage("Xóa thành công", MessageBoxIcon.Information);
                this.OnLoad(e);
                return;
            }
            Program.AlertMessage("Đã xảy ra lỗi", MessageBoxIcon.Error);
            return;
        }

        private void txtTimKiem_Click(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }

        private void txtTimKiem_Leave(object sender, EventArgs e)
        {
            this.KeyPreview = false;
        }
    }
}
