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
    public partial class frmKhamBenh : Form
    {
        BUS_KhamBenh bus_kb = new BUS_KhamBenh();
        BUS_TaiKhoan bus_tk = new BUS_TaiKhoan();
        public frmKhamBenh()
        {
            InitializeComponent();
            menu.PrimaryColor = Color.FromArgb(30, 144, 255);
        }

        private void frmKhamBenh_Load(object sender, EventArgs e)
        {
            btnThem.Enabled = btnXoa.Enabled = false;
            string idtk = bus_tk.getIDTK(frmLogin.USERNAME);
            dgvBenhNhan.DataSource = bus_kb.getDanhSachBN(idtk);
            cboDichVu.DataSource = bus_kb.getListDV();
            cboDichVu.DisplayMember = "TENDV";
            cboDichVu.ValueMember = "MADV";
            
        }

        private void dgvBenhNhan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnThem.Enabled = true;
            string ten = dgvBenhNhan.CurrentRow.Cells["TENBN"].Value.ToString();
            string mals = dgvBenhNhan.CurrentRow.Cells["LSKB"].Value.ToString();
            lbTenBn.Texts = ten;
            if(bus_kb.checkPhieuTonTai(mals) > 0)
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
                dgvCTDV.DataSource = dt;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string mals = dgvBenhNhan.CurrentRow.Cells["LSKB"].Value.ToString();
            string madv = bus_kb.getMaDV(cboDichVu.Texts);
            string mota = txtMoTa.Texts;
            if (bus_kb.checkPhieuTonTai(mals) > 0)
            {
                if(string.IsNullOrEmpty(mota))
                {
                    mota = "Chưa có";
                }    
                string macd = bus_kb.getMaCD(mals);
                CHITIETCD cd = new CHITIETCD
                {
                    MACD = macd,
                    MADV = madv,
                    MOTA = mota
                };
                if(bus_kb.checkCTCD(macd,madv) > 0)
                {
                    if (bus_kb.updateCD(cd))
                    {
                        if (!bus_kb.capNhatThanhTien(macd))
                        {
                            Program.AlertMessage("Đã xảy ra lỗi cập nhật thành tiền !", MessageBoxIcon.Error);
                        }
                        Program.AlertMessage("Cập nhật thành công", MessageBoxIcon.Information);
                        txtMoTa.Texts = string.Empty;
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
                            dgvCTDV.DataSource = dt;
                        }
                        return;
                    }
                    Program.AlertMessage("Đã xảy ra lỗi !", MessageBoxIcon.Error);
                    return;
                }
                if (bus_kb.themChiTietDichVu_DaCo(macd,madv,mota))
                {
                    if (!bus_kb.capNhatThanhTien(macd))
                    {
                        Program.AlertMessage("Đã xảy ra lỗi cập nhật thành tiền !", MessageBoxIcon.Error);
                    }
                    Program.AlertMessage("Thêm thành công", MessageBoxIcon.Information);
                    txtMoTa.Texts = string.Empty;
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
                        dgvCTDV.DataSource = dt;
                    }
                    return;
                }
                Program.AlertMessage("Đã xảy ra lỗi !", MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(mota))
            {
                mota = "Chưa có";
            }
            string macdm = "CD" + Program.phatSinhMaTuDong();
            if(bus_kb.themChiTietDichVu(mals,macdm,madv,mota))
            {
                if (!bus_kb.capNhatThanhTien(macdm))
                {
                    Program.AlertMessage("Đã xảy ra lỗi cập nhật thành tiền !", MessageBoxIcon.Error);
                }
                Program.AlertMessage("Thêm thành công", MessageBoxIcon.Information);
                txtMoTa.Texts = string.Empty;
                if (bus_kb.checkPhieuTonTai(mals) > 0)
                {
                    dgvCTDV.DataSource = bus_kb.getListCT(bus_kb.getMaCD(mals));
                }
                return;
            }
            Program.AlertMessage("Đã xảy ra lỗi !", MessageBoxIcon.Error);
        }

        private void dgvCTDV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnXoa.Enabled = true;
            cboDichVu.Texts = dgvCTDV.CurrentRow.Cells["TENDV"].Value.ToString();
            string mota =  dgvCTDV.CurrentRow.Cells["MOTA"].Value.ToString();
            if(mota.Equals("Chưa có"))
            {
                txtMoTa.Texts = string.Empty;
            }    
            else
            {
                txtMoTa.Texts = mota;
            }    
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string mals = dgvBenhNhan.CurrentRow.Cells["LSKB"].Value.ToString();
            string macd = bus_kb.getMaCD(mals);
            string madv = bus_kb.getMaDV(cboDichVu.Texts);
            if (bus_kb.xoaCTCD(macd,madv))
            {
                if(!bus_kb.capNhatThanhTien(macd))
                {
                    Program.AlertMessage("Đã xảy ra lỗi cập nhật thành tiền !", MessageBoxIcon.Error);
                }    
                Program.AlertMessage("Xóa thành công", MessageBoxIcon.Information);
                btnXoa.Enabled = false;
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
                    dgvCTDV.DataSource = dt;
                }
                return;
            }
            Program.AlertMessage("Đã xảy ra lỗi !", MessageBoxIcon.Error);
        }

        private void cboDichVu_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            btnXoa.Enabled = false;
            txtMoTa.Texts = string.Empty;
        }
    }
}
