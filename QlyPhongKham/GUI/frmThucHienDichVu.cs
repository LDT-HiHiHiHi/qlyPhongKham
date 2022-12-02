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
using System.IO;

namespace GUI
{
    public partial class frmThucHienDichVu : Form_Edit
    {
        BUS_ThucHienDV bus_dv = new BUS_ThucHienDV();
        BUS_KhamBenh bus_kb = new BUS_KhamBenh();
        public static string HINH;
        public frmThucHienDichVu()
        {
            InitializeComponent();
            menu.PrimaryColor = Color.FromArgb(30, 144, 255);
        }

        private void frmThucHienDichVu_Load(object sender, EventArgs e)
        {
            btnLuu.Enabled = btnXem.Enabled = btnOpen.Enabled = false;
            List<ThanhToanDV> list = bus_dv.getListCD_Today();
            if (list != null)
            {
                dgvCD.DataSource = list;
            }
            else
            {
                DataTable dt = new DataTable();
                dt.Columns.Add(new DataColumn("MACD", typeof(string)));
                dt.Columns.Add(new DataColumn("TENBN", typeof(string)));
                dt.Columns.Add(new DataColumn("DAY", typeof(DateTime)));
                dgvCD.DataSource = dt;
            }
            this.KeyDown += FrmThucHienDichVu_KeyDown;
        }

        private void FrmThucHienDichVu_KeyDown(object sender, KeyEventArgs e)
        {
            btnTimKiem_Click(sender, e);
        }

        private void dgvCD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string macd = dgvCD.CurrentRow.Cells["MACD"].Value.ToString();
            dgvCT.DataSource = bus_kb.getListCT(macd);
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Pictures files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png)|*.jpg; *.jpeg; *.jpe; *.jfif; *.png|All files (*.*)|*.*";
            openFile.FilterIndex = 1;
            openFile.RestoreDirectory = true;
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                txtHinhAnh.Texts = openFile.FileName;
            }
        }
        private byte[] converImgToByte()
        {
            FileStream fs;
            fs = new FileStream(txtHinhAnh.Texts, FileMode.Open, FileAccess.Read);
            byte[] picbyte = new byte[fs.Length];
            fs.Read(picbyte, 0, System.Convert.ToInt32(fs.Length));
            fs.Close();
            return picbyte;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string ketqua = txtKetQua.Texts;
            if (string.IsNullOrEmpty(txtHinhAnh.Texts))
            {
                btnOpen.Focus();
                errorProvider1.SetError(btnOpen, "Vui lòng chọn hình ảnh");
                return;
            }
            errorProvider1.Clear();

            if (string.IsNullOrEmpty(ketqua))
            {
                txtKetQua.Focus();
                errorProvider1.SetError(txtKetQua, "Vui lòng nhập kết quả");
                return;
            }
            errorProvider1.Clear();
            string tendv = dgvCT.CurrentRow.Cells["TENDV"].Value.ToString();
            string madv = bus_kb.getMaDV(tendv);
            string macd = dgvCD.CurrentRow.Cells["MACD"].Value.ToString();

            string hinhanh = Convert.ToBase64String(converImgToByte());
            if (bus_dv.updateCTCD(macd,madv,hinhanh,ketqua))
            {
                btnLuu.Enabled = btnXem.Enabled = btnOpen.Enabled = false;
                Program.AlertMessage("Thực hiện thành công", MessageBoxIcon.Information);
                dgvCT.DataSource = bus_kb.getListCT(macd);
                return;
            }
            Program.AlertMessage("Đã xảy ra lỗi ", MessageBoxIcon.Error);
        }

        private void xemHìnhẢnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HINH = dgvCT.CurrentRow.Cells["HINHANH"].Value.ToString();
            new frmXemHinhAnh().ShowDialog();
        }

        private void dgvCT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnLuu.Enabled = btnXem.Enabled = btnOpen.Enabled = true;
            string hinh = dgvCT.CurrentRow.Cells["HINHANH"].Value.ToString();
            if (hinh.Equals("Chưa có"))
            {
                btnXem.Enabled = false;
            }
            string kq = dgvCT.CurrentRow.Cells["KETQUA"].Value.ToString();
            if (kq.Equals("Chưa có"))
            {
                txtKetQua.Texts = string.Empty;
            } 
            else
            {
                txtKetQua.Texts = kq;
            }    
        }

        private void txtHinhAnh__TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtHinhAnh.Texts))
            {
                errorProvider1.Clear();
            }
            
        }
        private void txtKetQua__TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtKetQua.Texts))
            {
                errorProvider1.Clear();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTimKiem.Texts))
            {
                this.OnLoad(e);
                return;
            }
            dgvCD.DataSource = bus_dv.timKiemCD_Today(txtTimKiem.Texts);
        }

        private void txtTimKiem_Click(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }

        private void txtTimKiem_Leave(object sender, EventArgs e)
        {
            this.KeyPreview = false;
        }

        private void frmThucHienDichVu_Activated(object sender, EventArgs e)
        {
            //Activate the corresponding Tabpage
            tabCtrl.SelectedTab = tabPag;

            if (!tabCtrl.Visible)
            {
                tabCtrl.Visible = true;
            }
        }

        private void frmThucHienDichVu_FormClosing(object sender, FormClosingEventArgs e)
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
