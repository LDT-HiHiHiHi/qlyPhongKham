using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
namespace GUI
{
    public partial class frmTaiKhoan : Form_Edit
    {

        BUS_TaiKhoan bus_tk = new BUS_TaiKhoan();
        
        public frmTaiKhoan()
        {
            InitializeComponent();
            dgvTaiKhoan.DataSource = bus_tk.getListTK();
        }

        private void frmTaiKhoan_Load(object sender, EventArgs e)
        {
            đặtLạiMậtKhẩuToolStripMenuItem.Enabled = false;
            dgvTaiKhoan.DataSource = bus_tk.getListTK();
            this.KeyDown += FrmTaiKhoan_KeyDown;
        }

        private void FrmTaiKhoan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnTimKiem_Click(sender, e);
            }
        }

        private void thêmTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmThemTaiKhoan().ShowDialog();
            this.frmTaiKhoan_Load(sender, e);
        }

        private void dgvTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                đặtLạiMậtKhẩuToolStripMenuItem.Enabled = true;
        }

        private void dgvTaiKhoan_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvTaiKhoan.Columns[e.ColumnIndex].Index == 2)
            {
                if (e.Value != null)
                {
                    e.Value = new string('*', e.Value.ToString().Length);
                    e.FormattingApplied = true;
                }
            }
        }

        private void dgvTaiKhoan_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox t = e.Control as TextBox;
            if (t != null)
            {
                t.Text = (string)dgvTaiKhoan.SelectedCells[0].Value.ToString();
            }
        }

        private void đặtLạiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string id = dgvTaiKhoan.CurrentRow.Cells["ID"].Value.ToString();
            string mk = "123";
            string tendn = bus_tk.getTenDangNhap(id);
            if (bus_tk.updateMatKhau(tendn, mk))
            {
                Program.AlertMessage("Đặt lại mật khẩu thành công !\nMật khẩu mặc định là "+mk, MessageBoxIcon.Information);
                this.OnLoad(e);
                return;
            }
            Program.AlertMessage("Đã xảy ra lỗi !", MessageBoxIcon.Error);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string user = txtTimKiem.Texts;
            if (string.IsNullOrEmpty(user))
            {
                txtTimKiem.Focus();
                this.OnLoad(e);
                return;
            }
            dgvTaiKhoan.DataSource = bus_tk.timKiemTaiKhoan(user);
        }

        private void frmTaiKhoan_Activated(object sender, EventArgs e)
        {
            //Activate the corresponding Tabpage
            tabCtrl.SelectedTab = tabPag;

            if (!tabCtrl.Visible)
            {
                tabCtrl.Visible = true;
            }
        }

        private void frmTaiKhoan_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Destroy the corresponding Tabpage when closing MDI child form
            this.tabPag.Dispose();
            //If no Tabpage left
            if (!tabCtrl.HasChildren)
            {
                tabCtrl.Visible = false;
            }
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
