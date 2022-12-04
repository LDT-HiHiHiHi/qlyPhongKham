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
    public partial class frmThongTinCaNhan : Form_Edit
    {
        BUS_TaiKhoan bus_tk = new BUS_TaiKhoan();
        BUS_ThongTinCaNhan bus_tt = new BUS_ThongTinCaNhan();
        public frmThongTinCaNhan()
        {
            InitializeComponent();
        }


        private void frmThongTinCaNhan_Load(object sender, EventArgs e)
        {
            string id = bus_tk.getIDTK(frmLogin.USERNAME);
            if(bus_tt.ckThongTin(id) > 0)
            {
                THONGTINTAIKHOAN tt = bus_tt.getThongTin(id);
                txtHoTen.Texts = tt.HOTEN;
                if(tt.GTINH.Equals("Nam"))
                {
                    rdbNam.Checked = true;
                }    
                else
                {
                    rdbNu.Checked = true;
                }
                txtDiaChi.Texts = tt.DCHI;
                txtSDT.Texts = tt.SDT;
                txtNgaySinh.Text = tt.NGSINH.ToString();
            }    
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtHoTen.Texts))
            {
                errorProvider1.SetError(txtHoTen, "Vui ;òng nhập họ tên");
                txtHoTen.Focus();
                return;
            }
            errorProvider1.Clear();

            if (string.IsNullOrEmpty(txtDiaChi.Texts))
            {
                errorProvider2.SetError(txtDiaChi, "Vui ;òng nhập họ tên");
                txtDiaChi.Focus();
                return;
            }
            errorProvider2.Clear();

            if (string.IsNullOrEmpty(txtSDT.Texts))
            {
                errorProvider2.SetError(txtSDT, "Vui ;òng nhập họ tên");
                txtSDT.Focus();
                return;
            }
            errorProvider3.Clear();

            if (!frmThemBenhNhan.CK_SDT(txtSDT.Texts))
            {
                errorProvider3.SetError(txtSDT, "Số điện thoại không phù hợp \n Vui lòng nhập lại");
                txtSDT.Focus();
                txtSDT.SelectAll();
                return;
            }
            errorProvider3.Clear();

            string id = bus_tk.getIDTK(frmLogin.USERNAME);
            string gt = rdbNam.Text;
            if(!rdbNam.Checked)
            {
                gt = rdbNu.Text;
            }    
            THONGTINTAIKHOAN tt = new THONGTINTAIKHOAN
            {
                ID = id,
                HOTEN = txtHoTen.Texts,
                NGSINH = DateTime.Parse(txtNgaySinh.Text),
                GTINH = gt,
                SDT = txtSDT.Texts,
                DCHI = txtDiaChi.Texts
            };

            if (bus_tt.ckThongTin(id) == 0)
            {
                if(bus_tt.luuThongTin(tt))
                {
                    Program.AlertMessage("Lưu thành công", MessageBoxIcon.Information);
                    return;
                }
                Program.AlertMessage("Đã xảy ra lỗi", MessageBoxIcon.Error);
                return;
            }
           
            if(bus_tt.capNhatThongTin(tt))
                {
                Program.AlertMessage("Cập nhât thành công", MessageBoxIcon.Information);
                return;
            }
            Program.AlertMessage("Đã xảy ra lỗi", MessageBoxIcon.Error);
            return;
        }

        private void txtHoTen__TextChanged(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtHoTen.Texts))
            {
                errorProvider1.Clear();
            }    
        }

        private void txtDiaChi__TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDiaChi.Texts))
            {
                errorProvider2.Clear();
            }
        }

        private void txtSDT__TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSDT.Texts))
            {
                errorProvider3.Clear();
            }
        }
    }
}
