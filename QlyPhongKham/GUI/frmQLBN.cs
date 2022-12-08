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
    public partial class frmQLBN : Form_Edit
    {
        BUS_QLBN bus_qlbn = new BUS_QLBN();
        BUS_KhamBenh bus_kb = new BUS_KhamBenh();
        public static bool flag = false;
        public static string ID;
        public frmQLBN()
        {
            InitializeComponent();
            menu.PrimaryColor = Color.FromArgb(30 ,144 ,255);
            txtTimKiem.Focus();
            dgvListBN.RowsDefaultCellStyle.BackColor = Color.White;
            dgvListBN.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
        }

        private void frmQLBN_Load(object sender, EventArgs e)
        {
            btnKham.Enabled = btnSua.Enabled= btnDoiPhong.Enabled = false;
            cboPhong.DataSource = bus_qlbn.getListPhong();
            cboPhong.DisplayMember = "TENPHONG";
            cboPhong.ValueMember = "MAPHONG";
            dgvListBN.DataSource = bus_qlbn.getListBenhNhan();
            this.KeyDown += FrmQLBN_KeyDown;
            cboPhong_OnSelectedIndexChanged(sender, e);
        }

        private void FrmQLBN_KeyDown(object sender, KeyEventArgs e)
        {
           if(e.KeyCode == Keys.Enter)
            {
                btnTimKiem_Click(sender, e);
            }    
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            new frmThemBenhNhan().ShowDialog();
            this.OnLoad(e);
        }

        private void dgvListBN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvListBN.CurrentRow == null)
                return;
            ID = dgvListBN.CurrentRow.Cells["MABN"].Value.ToString();
            btnKham.Enabled = btnSua.Enabled = btnDoiPhong.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            flag = true;
            new frmThemBenhNhan().ShowDialog();
            this.OnLoad(e);
            dgvListBN.DataSource = frmThemBenhNhan.list;
            flag = false;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtTimKiem.Texts))
            {
                this.OnLoad(e); 
                return;
            }
            DataTable ds = bus_qlbn.timKiemBN(txtTimKiem.Texts);
            if(ds.Rows.Count == 0)
            {
                Program.AlertMessage("Không tìm thấy kết quả", MessageBoxIcon.Information);
                return;
            }
            dgvListBN.DataSource = ds;
        }

        private void txtTimKiem_Click(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }

        private void txtTimKiem_Leave(object sender, EventArgs e)
        {
            this.KeyPreview = false;
        }

        private void btnKham_Click(object sender, EventArgs e)
        {
            string maphong = cboPhong.SelectedValue();
            string mabs = bus_kb.getMaBacSi(maphong);
            string mabn = dgvListBN.CurrentRow.Cells["MABN"].Value.ToString();
            if (string.IsNullOrEmpty(mabs))
            {
                Program.AlertMessage("Phòng chưa có bác sĩ", MessageBoxIcon.Information);
                return;
            }
            string mals = "LS" + Program.phatSinhMaTuDong();
            if(bus_kb.checkBenhNhanKham(mabn) > 0)
            {
                Program.AlertMessage("Bệnh nhân đã khám", MessageBoxIcon.Information);
                return;
            }
            int stt = bus_kb.STT(mabs) + 1;
            LS_KHAMBENH lskb = new LS_KHAMBENH
            {
                MALS = mals,
                MABN = mabn,
                MABS = mabs,
                NGKHAM = DateTime.Today,
                CHANDOAN = "Chưa có",
                TRANGTHAI = false,
                STT = stt
                
            };
            if (bus_kb.themDangKiKham(lskb))
            {
                btnKham.Enabled = btnSua.Enabled = btnDoiPhong.Enabled = false;
                cboPhong_OnSelectedIndexChanged(sender, e);
                Program.AlertMessage("Thêm thành công", MessageBoxIcon.Information);
                return;
            }
            Program.AlertMessage("Đã xảy ra lỗi", MessageBoxIcon.Error);
        }

        private void cboPhong_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            string maphong = cboPhong.SelectedValue();
            string mabs = bus_kb.getMaBacSi(maphong);
            int stt = bus_kb.soLuong(mabs);
            lbSoLuong.Text = stt.ToString();
        }

        private void đổiPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string mabn = dgvListBN.CurrentRow.Cells["MABN"].Value.ToString();
            string mabsCu = bus_qlbn.getMaBSCu(mabn);

            string maphong = cboPhong.SelectedValue();
            string mabs = bus_kb.getMaBacSi(maphong);
            if (string.IsNullOrEmpty(mabs))
            {
                Program.AlertMessage("Phòng chưa có bác sĩ", MessageBoxIcon.Information);
                return;
            }
            if (mabs.Equals(mabsCu))
            {
                return;
            }
            int stt;
            if (bus_kb.STT(mabs) == 0)
            {
                stt = 1;
            }
            else
            {
                stt = bus_kb.addSTT(mabs) + 1;
            }
            if (bus_kb.checkBenhNhanKham(mabn) == 0)
            {
                Program.AlertMessage("Bệnh nhân chưa khám", MessageBoxIcon.Information);
                return;
            }
            LS_KHAMBENH ls = new LS_KHAMBENH
            {
                MABN = mabn,
                STT = stt,
                MABS = mabs
            };
            if(bus_qlbn.suaPhong(ls))
            {
                btnKham.Enabled = btnSua.Enabled = btnDoiPhong.Enabled = false;
                cboPhong_OnSelectedIndexChanged(sender, e);
                Program.AlertMessage("Sửa phòng thành công", MessageBoxIcon.Information);
                return;
            }
            Program.AlertMessage("Đã xảy ra lỗi", MessageBoxIcon.Error);
        }

        private void frmQLBN_Activated(object sender, EventArgs e)
        {
            //Activate the corresponding Tabpage
            tabCtrl.SelectedTab = tabPag;

            if (!tabCtrl.Visible)
            {
                tabCtrl.Visible = true;
            }
        }

        private void frmQLBN_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Destroy the corresponding Tabpage when closing MDI child form
            this.tabPag.Dispose();

            //If no Tabpage left
            if (!tabCtrl.HasChildren)
            {
                tabCtrl.Visible = false;
            }
        }
    }
}
