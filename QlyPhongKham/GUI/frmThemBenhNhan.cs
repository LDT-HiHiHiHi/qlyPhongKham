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
using System.Text.RegularExpressions;

namespace GUI
{
    public partial class frmThemBenhNhan : Form
    {
        BUS_QLBN bus_qlbn = new BUS_QLBN();
        public static List<BENHNHAN> list;
        public frmThemBenhNhan()
        {
            InitializeComponent();
            list = bus_qlbn.getListBenhNhan();
            rdbNam.Checked = true;
        }
        public static bool CK_SDT(string pSDT)
        {
            // số điện thoại được định dạng theo sdt ở Việt Nam
            // - gồm 10 số
            // - 2 số đầu tiên có thể là các số: 84, 03, 05, 07, 08, 09
            Regex rg = new Regex(@"^(84|0[3|5|7|8|9])+([0-9]{8})$");

            return rg.IsMatch(pSDT);
        }
        private void customButton1_Click(object sender, EventArgs e)
        {
            //Kiểm tra rỗng
            if(string.IsNullOrEmpty(txtTenBN.Texts))
            {
                errorProvider1.SetError(txtTenBN, "Vui lòng nhập tên đăng nhập");
                txtTenBN.Focus();
                return;
            }
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(txtDiaChi.Texts))
            {
                errorProvider2.SetError(txtDiaChi, "Vui lòng nhập địa chỉ");
                txtDiaChi.Focus();
                return;
            }
            errorProvider2.Clear();
            if (string.IsNullOrEmpty(txtDienThoai.Texts))
            {
                errorProvider3.SetError(txtDienThoai, "Vui lòng nhập số điện thoại");
                txtTenBN.Focus();
                return;
            }
            errorProvider3.Clear();

            //Kiểm tra tính đúng đắn
            string id = "BN" + Program.phatSinhMaTuDong();
            if(bus_qlbn.checkMaBenhNhan(id) > 0)
            {
                return;
            }
            if (!CK_SDT(txtDienThoai.Texts))
            {
                errorProvider3.SetError(txtDienThoai, "Số điện thoại không phù hợp \n Vui lòng nhập lại");
                txtDienThoai.Focus();
                txtDienThoai.SelectAll();
                return;
            }
            string gt = rdbNam.Text;
            if (rdbNu.Checked)
            {
                gt = rdbNu.Text;
            }
            string day = txtNgaySinh.Value.ToString();

            if(frmQLBN.flag)
            {
                BENHNHAN t = new BENHNHAN
                {
                    MABN = frmQLBN.ID,
                    TENBN = txtTenBN.Texts,
                    DIACHI = txtDiaChi.Texts,
                    SDT = txtDienThoai.Texts,
                    GTINH = gt,
                    NGAYSINH = DateTime.Parse(day)
                };
                if (bus_qlbn.suaBenhNhan(t))
                {
                    Program.AlertMessage("Cập nhật thành công !", MessageBoxIcon.Information);
                    list = bus_qlbn.getListBenhNhan();
                    this.Close();
                    return;
                }
                Program.AlertMessage("Đã xảy ra lỗi !", MessageBoxIcon.Error);
                return;
            }   
            BENHNHAN bn = new BENHNHAN
            {
                MABN = id,
                DIACHI = txtDiaChi.Texts,
                SDT = txtDienThoai.Texts,
                NGAYSINH = DateTime.Parse(day),
                TENBN = txtTenBN.Texts,
                GTINH = gt
            };
            if(bus_qlbn.themBenhNhan(bn))
            {
                Program.AlertMessage("Thêm bệnh nhân thành công" , MessageBoxIcon.Information);
                list = bus_qlbn.getListBenhNhan();
                this.Close();
                return;
            }
            Program.AlertMessage("Đã xảy ra lỗi !", MessageBoxIcon.Error);
        }

        private void txtTenBN__TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTenBN.Texts))
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

        private void txtDienThoai__TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDienThoai.Texts))
            {
                errorProvider3.Clear();
            }
        }

        private void frmThemBenhNhan_Load(object sender, EventArgs e)
        {
            if (frmQLBN.flag == true)
            {
                BENHNHAN a = bus_qlbn.getBenhNhan(frmQLBN.ID);
                txtTenBN.Texts = a.TENBN;
                txtDiaChi.Texts = a.DIACHI;
                if (a.GTINH.Equals("Nam"))
                    rdbNam.Checked = true;
                else
                    rdbNu.Checked = true;
                txtDienThoai.Texts = a.SDT;
                txtNgaySinh.Text = a.NGAYSINH.ToString();
            }
        }

        private void txtDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
