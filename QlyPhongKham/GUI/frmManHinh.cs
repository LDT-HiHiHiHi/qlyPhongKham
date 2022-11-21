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
    public partial class frmManHinh : Form
    {
        BUS_ManHinh bus_mh = new BUS_ManHinh();
        public frmManHinh()
        {
            InitializeComponent();
        }

        private void frmManHinh_Load(object sender, EventArgs e)
        {
            dgvManHinh.DataSource = bus_mh.getManHinh();
            xóaToolStripMenuItem.Enabled = false;
            txtIDMH.Texts = txtTenMH.Texts = string.Empty;
            dgvManHinh.RowsDefaultCellStyle.BackColor = Color.White;
            dgvManHinh.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtIDMH.Texts.Equals(String.Empty))
            {
                MessageBox.Show("Vui lòng nhập " + label2.Text.ToLower(), "Thông báo");
                txtIDMH.Focus();
                return;
            }

            if (txtTenMH.Texts.Equals(String.Empty))
            {
                MessageBox.Show("Vui lòng nhập " + label3.Text.ToLower(), "Thông báo");
                txtTenMH.Focus();
                return;
            }

            if (!bus_mh.kt_KhoaManHinh(txtIDMH.Texts))
            {
                if(bus_mh.suaManHinh(txtIDMH.Texts,txtTenMH.Texts))
                {
                    MessageBox.Show("Sửa màn hình " + txtIDMH.Texts + " thành công !", "Thông báo");
                    this.OnLoad(e);
                    return;
                }
                MessageBox.Show("Đã xãy ra lỗi !", "Thông báo");
            }

            if (bus_mh.themManHinh(txtIDMH.Texts, txtTenMH.Texts))
            {
                MessageBox.Show("Thêm màn hình " + txtIDMH.Texts + " thành công !", "Thông báo");
                this.OnLoad(e);
                return;
            }
            MessageBox.Show("Đã xãy ra lỗi !", "Thông báo");
        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string idmh = dgvManHinh.CurrentRow.Cells["IDMH"].Value.ToString();
            if (bus_mh.xoaManHinh(idmh))
            {
                MessageBox.Show("Xóa màn hình " + txtIDMH.Texts + " thành công !", "Thông báo");
                this.OnLoad(e);
                return;
            }
            MessageBox.Show("Đã xãy ra lỗi !", "Thông báo");
        }

        private void dgvManHinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            xóaToolStripMenuItem.Enabled = true;
            txtIDMH.Texts = dgvManHinh.CurrentRow.Cells["IDMH"].Value.ToString();
            txtTenMH.Texts = dgvManHinh.CurrentRow.Cells["TENMH"].Value.ToString();
        }
    }
}
