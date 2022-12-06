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
    public partial class frmDoiMatKhau : Form
    {
        public static string USERNAME;
        BUS_TaiKhoan bus_tk = new BUS_TaiKhoan();
        public frmDoiMatKhau()
        {
            InitializeComponent();
            USERNAME = frmLogin.USERNAME;
        }

        private void frmDoiMatKhau_Load(object sender, EventArgs e)
        {
            label4.Text = USERNAME;
        }


        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPW.Texts))
            {
                errorProvider1.SetError(txtPW, "Vui lòng nhập mật khẩu");
                txtPW.Focus();
                return;
            }
            errorProvider1.Clear();
            if (txtPW.Texts.Length < 4)
            {
                errorProvider1.SetError(txtPW, "Vui lòng nhập mật khẩu nhiều hơn 3 kí tự");
                txtPW.Focus();
                return;
            }
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(txtRPW.Texts))
            {
                errorProvider2.SetError(txtRPW, "Vui lòng nhập xác nhận mật khẩu");
                txtRPW.Focus();
                return;
            }
            errorProvider2.Clear();

            if (!txtPW.Texts.Equals(txtRPW.Texts))
            {
                Program.AlertMessage("Xác nhận mật khẩu không chính xác !", MessageBoxIcon.Error);
                txtRPW.Focus();
                txtRPW.SelectAll();
                return;
            }

            if(bus_tk.updateMatKhau(USERNAME,txtPW.Texts.Trim()))
            {
                Program.AlertMessage("Đổi mật khẩu thành công !", MessageBoxIcon.Information);
                this.Close();
                return;
            }
            Program.AlertMessage("Đã xảy ra lỗi !", MessageBoxIcon.Error);
        }

        private void txtPW__TextChanged(object sender, EventArgs e)
        {
            if (txtPW.Texts.Length > 3)
            {
                errorProvider1.Clear();
            }    
        }
    }
}
