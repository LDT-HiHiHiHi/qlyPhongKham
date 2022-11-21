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
    public partial class frmThemTaiKhoan : Form
    {
        BUS_TaiKhoan bus_tk = new BUS_TaiKhoan();
        public frmThemTaiKhoan()
        {
            InitializeComponent();
            
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtRPW.Texts))
            {
                errorProvider1.SetError(txtTenDN, "Vui lòng nhập xác nhận mật khẩu");
                txtRPW.Focus();
                return;
            }
            errorProvider1.Clear();

            if (!txtPW.Texts.Equals(txtRPW.Texts))
            {
                Program.AlertMessage("Xác nhận mật khẩu không chính xác !",MessageBoxIcon.Error);
                txtRPW.Focus();
                return;
            }

            string id = "TK" + Program.phatSinhMaTuDong();
            string tentk = txtTenDN.Texts.Trim();
            string mk = txtPW.Texts.Trim();
            TAIKHOAN tk = new TAIKHOAN
            {
                ID = id,
                USERNAME = tentk,
                PW = mk
            };
            if(bus_tk.themTaiKhoan(tk))
            {
                Program.AlertMessage("Tạo mới thành công !", MessageBoxIcon.Information);
                this.Close();
                return;
            }
            Program.AlertMessage("Đã xảy ra lỗi !", MessageBoxIcon.Error);
        }

        private void txtTenDN_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenDN.Texts))
            {
                errorProvider1.SetError(txtTenDN, "Vui lòng nhập tên đăng nhập");
                txtTenDN.Focus();
                return;
            }
            errorProvider1.Clear();

            if (bus_tk.checkTenDangNhap(txtTenDN.Texts) > 0)
            {
                errorProvider1.SetError(txtTenDN, "Trùng tên đăng nhập");
                txtTenDN.Focus();
                return;
            }
            errorProvider1.Clear();
        }

        private void txtPW_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPW.Texts))
            {
                errorProvider2.SetError(txtPW, "Vui lòng nhập mật khẩu");
                txtPW.Focus();
                return;
            }
            errorProvider2.Clear();

           if(txtPW.Texts.Length <= 3)
            {
                errorProvider2.SetError(txtPW, "Mật khẩu phải chứa nhiều hơn 3 kí tự");
                txtPW.Focus();
                return;
            }    
        }
    }
}
