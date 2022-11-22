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
    public partial class frmTaiKhoan : Form
    {
        BUS_TaiKhoan bus_tk = new BUS_TaiKhoan();
        public frmTaiKhoan()
        {
            InitializeComponent();
            đổiMậtKhẩuToolStripMenuItem.Enabled = xóaTàiKhoảnToolStripMenuItem.Enabled = false;
            dgvTaiKhoan.DataSource = bus_tk.getListTK();
        }

        private void frmTaiKhoan_Load(object sender, EventArgs e)
        {
            đổiMậtKhẩuToolStripMenuItem.Enabled= xóaTàiKhoảnToolStripMenuItem.Enabled = false;
            dgvTaiKhoan.DataSource = bus_tk.getListTK();
        }

        private void thêmTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmThemTaiKhoan().ShowDialog();
            this.frmTaiKhoan_Load(sender, e);
        }

        private void dgvTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            đổiMậtKhẩuToolStripMenuItem.Enabled = xóaTàiKhoảnToolStripMenuItem.Enabled = true;
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string id = dgvTaiKhoan.CurrentRow.Cells["ID"].Value.ToString();
            frmDoiMatKhau.USERNAME = bus_tk.getTenDangNhap(id);
            new frmDoiMatKhau().ShowDialog();
            this.frmTaiKhoan_Load(sender, e);
            dgvTaiKhoan.DataSource = frmDoiMatKhau.LIST;
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
    }
}
