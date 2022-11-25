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
    public partial class frmQLBN : Form
    {
        BUS_QLBN bus_qlbn = new BUS_QLBN();
        public static bool flag = false;
        public static string ID;
        public frmQLBN()
        {
            InitializeComponent();
            txtTimKiem.Focus();
        }

        private void frmQLBN_Load(object sender, EventArgs e)
        {
            btnKham.Enabled = btnSua.Enabled = false;
            cboPhong.DataSource = bus_qlbn.getListPhong();
            cboPhong.DisplayMember = "TENPHONG";
            cboPhong.ValueMember = "MAPHONG";
            dgvListBN.DataSource = bus_qlbn.getListBenhNhan();
            this.KeyDown += FrmQLBN_KeyDown;
        }

        private void FrmQLBN_KeyDown(object sender, KeyEventArgs e)
        {
           if(e.KeyCode == Keys.Enter)
            {
                btnTimKiem_Click(sender, e);
            }    
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            new frmThemBenhNhan().ShowDialog();
            this.OnLoad(e);
        }

        private void dgvListBN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = dgvListBN.CurrentRow.Cells["MABN"].Value.ToString();
            btnKham.Enabled = btnSua.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            flag = true;
            new frmThemBenhNhan().ShowDialog();
            this.OnLoad(e);
            dgvListBN.DataSource = frmThemBenhNhan.list;
            flag = false;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtTimKiem.Texts))
            {
                this.OnLoad(e); 
                return;
            }
            DataTable ds = bus_qlbn.timKiemBN(txtTimKiem.Texts);
            if(ds.Rows.Count == 0)
            {
                Program.AlertMessage("Không tìm thấy kết quả", MessageBoxIcon.Information);
                return;
            }
            dgvListBN.DataSource = ds;
        }

        private void txtTimKiem_Click(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }
    }
}
