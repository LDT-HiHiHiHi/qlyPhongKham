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
    public partial class frmKhamBenh : Form_Edit
    {
        public static string MALS;
        public static string tenBN;
        public static string DV;
        public static string TDV;
        BUS_KhamBenh bus_kb = new BUS_KhamBenh();
        BUS_TaiKhoan bus_tk = new BUS_TaiKhoan();
        BUS_ThanhToanDV bus_tt = new BUS_ThanhToanDV();
        public frmKhamBenh()
        {
            InitializeComponent();
            menu.PrimaryColor = Color.FromArgb(30, 144, 255);
            menu2.PrimaryColor = Color.FromArgb(30, 144, 255);
        }

        private void frmKhamBenh_Load(object sender, EventArgs e)
        {
            btnThem.Enabled = btnXoa.Enabled = btnToaThuoc.Enabled = btnXemLS.Enabled = btnLuu.Enabled = btnXem.Enabled = false;
            string idtk = bus_tk.getIDTK(frmLogin.USERNAME);
            dgvBenhNhan.DataSource = bus_kb.getDanhSachBN(idtk);
            cboDichVu.DataSource = bus_kb.getListDV();
            cboDichVu.DisplayMember = "TENDV";
            cboDichVu.ValueMember = "MADV";
            this.KeyDown += FrmKhamBenh_KeyDown;
        }

        private void FrmKhamBenh_KeyDown(object sender, KeyEventArgs e)
        {
            string idtk = bus_tk.getIDTK(frmLogin.USERNAME);
            if (e.KeyCode == Keys.F5)
            {
                dgvBenhNhan.DataSource = bus_kb.getDanhSachBN(idtk);
            }    
        }

        private void dgvBenhNhan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnThem.Enabled = btnToaThuoc.Enabled = btnXemLS.Enabled = true;
            string ten = dgvBenhNhan.CurrentRow.Cells["TENBN"].Value.ToString();
            string mals = dgvBenhNhan.CurrentRow.Cells["LSKB"].Value.ToString();
            lbTenBn.Texts = ten;
            string chandoan = bus_kb.getChanDoan(mals);
            if(chandoan.Equals("Chưa có"))
            {
                txtChanDoan.Texts = string.Empty;
            } 
            else
            {
                txtChanDoan.Texts = chandoan;
            }
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
                dt.Columns.Add(new DataColumn("DONGIA", typeof(double)));
                dt.Columns.Add(new DataColumn("HINHANH", typeof(string)));
                dgvCTDV.DataSource = dt;
            }
            if(bus_kb.getTrangThaiBN(mals) == true)
            {
                btnThem.Enabled = btnLuu.Enabled = false;
            }
            else
            {
                btnThem.Enabled = btnLuu.Enabled = true;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            TDV = cboDichVu.Texts;
            DV = bus_kb.getMaDV(cboDichVu.Texts);
            new frmChiTietDV().ShowDialog();
            if(!frmChiTietDV.flag)
            {
                return;
            }    
            string mt = frmChiTietDV.mota.TrimEnd(',',' ');
            txtMoTa.Texts = mt;
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
                        txtMoTa.Texts = frmChiTietDV.mota = string.Empty;
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
                    txtMoTa.Texts = frmChiTietDV.mota = string.Empty;
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
            string mals = dgvBenhNhan.CurrentRow.Cells["LSKB"].Value.ToString();
            if (bus_kb.getTrangThaiBN(mals) == true)
            {
                btnXoa.Enabled = false;
            }
            else
            {
                btnXoa.Enabled = true;
            }    
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

            string hinhanh = dgvCTDV.CurrentRow.Cells["HINHANH"].Value.ToString();
            if(hinhanh.Equals("Chưa có"))
            {
                btnXem.Enabled = false;
            }    
            else
            {
                btnXem.Enabled = true;
            }
            if(bus_tt.getTrangThai(bus_kb.getMaCD(mals)))
            {
                btnXoa.Enabled = false;
            }    
            else
            {
                btnXoa.Enabled = true;
            }    
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string mals = dgvBenhNhan.CurrentRow.Cells["LSKB"].Value.ToString();
            string macd = bus_kb.getMaCD(mals);
            string madv = bus_kb.getMaDV(cboDichVu.Texts);
            DialogResult r;
            r = MessageBox.Show("Bạn có chắc chắn muốn xóa dịc vụ " + cboDichVu.Texts + " ?", "Thông báo",

            MessageBoxButtons.YesNo, MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button1);

            if (r == DialogResult.Yes)
            {
                if (bus_kb.xoaCTCD(macd, madv))
                {
                    if (!bus_kb.capNhatThanhTien(macd))
                    {
                        Program.AlertMessage("Đã xảy ra lỗi cập nhật thành tiền !", MessageBoxIcon.Error);
                    }
                    Program.AlertMessage("Xóa thành công", MessageBoxIcon.Information);
                    btnXoa.Enabled = false;
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
                        dt.Columns.Add(new DataColumn("DONGIA", typeof(double)));
                        dt.Columns.Add(new DataColumn("HINHANH", typeof(string)));
                        dgvCTDV.DataSource = dt;
                    }
                    return;
                }
                Program.AlertMessage("Đã xảy ra lỗi !", MessageBoxIcon.Error);
            }
        }

        private void cboDichVu_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            btnXoa.Enabled = false;
            txtMoTa.Texts = string.Empty;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string mals = dgvBenhNhan.CurrentRow.Cells["LSKB"].Value.ToString();
            string chandoan = txtChanDoan.Texts;
            string ten = dgvBenhNhan.CurrentRow.Cells["TENBN"].Value.ToString();
            if (string.IsNullOrEmpty(chandoan))
            {
                errorProvider1.SetError(txtChanDoan, "Vui lòng nhập chẩn đoán");
                txtChanDoan.Focus();
                return;
            }
            errorProvider1.Clear();
            DialogResult r;
            r = MessageBox.Show("Bạn có chắc chắn muốn lưu ? ", "Thông báo",

            MessageBoxButtons.YesNo, MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button1);

            if (r == DialogResult.Yes)
            {
                if (bus_kb.hoanThanhLichSu(mals, chandoan))
                {
                    Program.AlertMessage("Hoàn thành khám bệnh cho bệnh nhân " + ten, MessageBoxIcon.Information);
                    txtChanDoan.Texts = string.Empty;
                    if (bus_kb.getTrangThaiBN(mals) == true)
                    {
                        btnThem.Enabled = btnLuu.Enabled = false;
                    }
                    else
                    {
                        btnThem.Enabled = btnLuu.Enabled = true;
                    }
                    return;
                }
                Program.AlertMessage("Đã xảy ra lỗi" + ten, MessageBoxIcon.Error);
            }
        }

        private void txtChanDoan__TextChanged(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtChanDoan.Texts))
            {
                errorProvider1.Clear();
            }    
        }

        private void btnToaThuoc_Click(object sender, EventArgs e)
        {
            tenBN = dgvBenhNhan.CurrentRow.Cells["TENBN"].Value.ToString();
            MALS = dgvBenhNhan.CurrentRow.Cells["LSKB"].Value.ToString();
            new frmKetoa().ShowDialog();
        }

        private void frmKhamBenh_Activated(object sender, EventArgs e)
        {
            //Activate the corresponding Tabpage
            tabCtrl.SelectedTab = tabPag;

            if (!tabCtrl.Visible)
            {
                tabCtrl.Visible = true;
            }
        }

        private void frmKhamBenh_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Destroy the corresponding Tabpage when closing MDI child form
            this.tabPag.Dispose();
            //If no Tabpage left
            if (!tabCtrl.HasChildren)
            {
                tabCtrl.Visible = false;
            }
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            frm.anh = dgvCTDV.CurrentRow.Cells["HINHANH"].Value.ToString();
            new frm().ShowDialog();
        }

        private void btnXemLS_Click(object sender, EventArgs e)
        {
            frmLichSuKhamBenh.tenbn = dgvBenhNhan.CurrentRow.Cells["TENBN"].Value.ToString();
            frmLichSuKhamBenh.mabn = dgvBenhNhan.CurrentRow.Cells["MABN"].Value.ToString();
            new frmLichSuKhamBenh().ShowDialog();
            btnXemLS.Enabled = false;
        }
    }
}
