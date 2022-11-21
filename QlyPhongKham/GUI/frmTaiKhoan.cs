using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
        }

        private void frmTaiKhoan_Load(object sender, EventArgs e)
        {
            đổiMậtKhẩuToolStripMenuItem.Enabled = false;
            dgvTaiKhoan.DataSource = bus_tk.getListTK();
        }

        private void thêmTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmThemTaiKhoan().ShowDialog();
            this.frmTaiKhoan_Load(sender, e);
        }
    }
}
