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

namespace GUI
{
    public partial class frmLogin : Form
    {
        public static string USERNAME;
        BUS_Login bus_lg = new BUS_Login();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            ////Kiểm tra rỗng
            if (string.IsNullOrEmpty(txtTDN.Texts.Trim()))
            {
                Program.AlertMessage("Vui lòng nhập " + lbTDN.Text.ToLower(), MessageBoxIcon.Warning);
                txtTDN.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtMK.Texts.Trim()))
            {
                Program.AlertMessage("Vui lòng nhập " + label1.Text.ToLower(), MessageBoxIcon.Warning);
                txtMK.Focus();
                return;
            }

            //Kiểm tra đăng nhập
            string tennd = txtTDN.Texts;
            string mk = txtMK.Texts;
            if (!bus_lg.dangNhap(tennd, mk))
            {
                Program.AlertMessage("Đăng nhập không hợp lệ !", MessageBoxIcon.Error);
                txtTDN.Focus();
                return;
            }
            USERNAME = tennd;
            Program.AlertMessage("Xin chào !", MessageBoxIcon.Information);
            Thread t = new Thread(new ThreadStart(ThreadLogin));
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
            this.Dispose();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyDown += frmLogin_KeyDown;
        }

        private void ThreadLogin()
        {
            Application.Run(new frmMain());
        }

        void frmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDangNhap.PerformClick();
            }
        }
    }
}
