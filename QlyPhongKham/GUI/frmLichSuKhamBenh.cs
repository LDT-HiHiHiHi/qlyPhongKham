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
    public partial class frmLichSuKhamBenh : Form
    {
        public static string mabn;
        public static string tenbn;
        BUS_LichSuKB bus_ls = new BUS_LichSuKB();
        BUS_KhamBenh bus_kb = new BUS_KhamBenh();
        BUS_TaiKhoan bus_tk = new BUS_TaiKhoan();
        BUS_ThanhToanTT bus_tt = new BUS_ThanhToanTT();
        BUS_KeToa bus_kt = new BUS_KeToa();
        public frmLichSuKhamBenh()
        {
            InitializeComponent();
            menu.PrimaryColor = Color.FromArgb(30, 144, 255);
        }

        private void frmLichSuKhamBenh_Load(object sender, EventArgs e)
        {
            lbBN.Text = tenbn;
            dgvBenhNhan.DataSource = bus_ls.getListLS(mabn);
        }

        private void dgvBenhNhan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string mals = dgvBenhNhan.CurrentRow.Cells["MALS"].Value.ToString();
            lbBS.Text = bus_ls.getTenBS(mals);
            string chandoan = bus_kb.getChanDoan(mals);
            if (chandoan.Equals("Chưa có"))
            {
                lbCD.Text = string.Empty;
            }
            else
            {
                lbCD.Text = chandoan;
            }
            if (bus_kb.checkPhieuTonTai(mals) > 0)
            {
                dgvCTDV.DataSource = bus_kb.getListCT(bus_kb.getMaCD(mals));
            }
            else
            {
                DataTable dt = new DataTable();
                dt.Columns.Add(new DataColumn("MACD", typeof(string)));
                dt.Columns.Add(new DataColumn("TENDV", typeof(string)));
                dt.Columns.Add(new DataColumn("MOTA", typeof(string)));
                dt.Columns.Add(new DataColumn("KETQUA", typeof(string)));
                dt.Columns.Add(new DataColumn("DONGIA", typeof(double)));
                dt.Columns.Add(new DataColumn("HINHANH", typeof(string)));
                dgvCTDV.DataSource = dt;
            }
            if (bus_kt.checkTT(mals) > 0)
            {
                string matt = bus_kt.getMaToaThuoc(mals);
                List<ToaThuoc> list = bus_kt.getListToaThuoc(matt);
                if (list != null)
                {
                    dgvToaThuoc.DataSource = list;
                }
                else
                {
                    DataTable dt = new DataTable();
                    dt.Columns.Add(new DataColumn("MATT", typeof(string)));
                    dt.Columns.Add(new DataColumn("TENT", typeof(string)));
                    dt.Columns.Add(new DataColumn("SB", typeof(int)));
                    dt.Columns.Add(new DataColumn("SL", typeof(int)));
                    dt.Columns.Add(new DataColumn("TONG", typeof(int)));
                    dt.Columns.Add(new DataColumn("DONGIA", typeof(double)));
                    dgvToaThuoc.DataSource = dt;
                }
            }
        }

        private void dgvCTDV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string hinhanh = dgvCTDV.CurrentRow.Cells["HINHANH"].Value.ToString();
            if (hinhanh.Equals("Chưa có"))
            {
                btnXem.Enabled = false;
            }
            else
            {
                btnXem.Enabled = true;
            }
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            frm.anh = dgvCTDV.CurrentRow.Cells["HINHANH"].Value.ToString();
            new frm().ShowDialog();
        }
    }
}
