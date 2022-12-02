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
    public partial class frmManHinh : Form_Edit
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
                    Program.AlertMessage("Sửa màn hình " + txtIDMH.Texts + " thành công !",MessageBoxIcon.Information);
                    this.OnLoad(e);
                    return;
                }
                Program.AlertMessage("Đã xãy ra lỗi !", MessageBoxIcon.Error);
            }

            if (bus_mh.themManHinh(txtIDMH.Texts, txtTenMH.Texts))
            {
                Program.AlertMessage("Thêm màn hình " + txtIDMH.Texts + " thành công !", MessageBoxIcon.Information);
                this.OnLoad(e);
                return;
            }
            Program.AlertMessage("Đã xãy ra lỗi !", MessageBoxIcon.Error);
        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string idmh = dgvManHinh.CurrentRow.Cells["IDMH"].Value.ToString();
            if (bus_mh.xoaManHinh(idmh))
            {
                Program.AlertMessage("Xóa màn hình " + txtIDMH.Texts + " thành công !", MessageBoxIcon.Information);
                this.OnLoad(e);
                return;
            }
            Program.AlertMessage("Đã xãy ra lỗi !", MessageBoxIcon.Error);
        }

        private void dgvManHinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            xóaToolStripMenuItem.Enabled = true;
            txtIDMH.Texts = dgvManHinh.CurrentRow.Cells["IDMH"].Value.ToString();
            txtTenMH.Texts = dgvManHinh.CurrentRow.Cells["TENMH"].Value.ToString();
        }

        private void frmManHinh_Activated(object sender, EventArgs e)
        {
            //Activate the corresponding Tabpage
            tabCtrl.SelectedTab = tabPag;

            if (!tabCtrl.Visible)
            {
                tabCtrl.Visible = true;
            }
        }

        private void frmManHinh_FormClosing(object sender, FormClosingEventArgs e)
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
