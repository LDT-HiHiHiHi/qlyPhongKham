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
    public partial class frmThanhToanTT : Form_Edit
    {
        BUS_ThanhToanTT bus_tt = new BUS_ThanhToanTT();
        BUS_KeToa bus_kt = new BUS_KeToa();
        BUS_LichSuKB bus_ls = new BUS_LichSuKB();
        private int? currentSelectionStart;
        private object val;
        public frmThanhToanTT()
        {
            InitializeComponent();
        }
        public string GiaTien
        {
            get
            {
                return string.Format("{0:#,##0}", val);
            }
        }
        private void frmThanhToanTT_Activated(object sender, EventArgs e)
        {
            //Activate the corresponding Tabpage
            tabCtrl.SelectedTab = tabPag;

            if (!tabCtrl.Visible)
            {
                tabCtrl.Visible = true;
            }
        }

        private void frmThanhToanTT_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Destroy the corresponding Tabpage when closing MDI child form
            this.tabPag.Dispose();
            //If no Tabpage left
            if (!tabCtrl.HasChildren)
            {
                tabCtrl.Visible = false;
            }
        }

        private void txtTienNhan__TextChanged(object sender, EventArgs e)
        {
            if (txtTienNhan.Texts != string.Empty)
            {
                errorProvider1.Clear();
                txtTienNhan.Texts = GiaTien;
                txtTienNhan.Select(currentSelectionStart ?? txtTienNhan.Texts.Length, 0);

                // tiền thừa
                double tienHD = double.Parse(txtTongTien.Texts.Trim().Replace(",", null));
                txtTienThua.Texts = string.Format("{0:#,##0}", (double)val - tienHD);
            }
            else
            {
                txtTienThua.Texts = string.Empty;
            }
        }

        private void txtTienNhan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            string soTien = txtTienNhan.Texts.Trim().Replace(",", null);

            if (char.IsDigit(e.KeyChar))
                val = double.Parse(soTien + e.KeyChar);
            else if (e.KeyChar == KPress.BACKSPACE_KEY && val.ToString() != string.Empty) // ấn nút xóa
            {
                if (soTien.Length <= 1)
                    val = 0;
                else val = double.Parse(soTien.Remove(soTien.Length - 1));
            }
            currentSelectionStart = null;
        }

        private void frmThanhToanTT_Load(object sender, EventArgs e)
        {
            btnThanhToan.Enabled = false;
            lbTrangThai.Text = txtTongTien.Texts = txtTienNhan.Texts = txtTienThua.Texts = string.Empty;
            lbTrangThai.BackColor = Color.White;

                List<ThanhToanTT> list = bus_tt.getListTT_Today();
                if (list != null)
                {
                    dgvTT.DataSource = list;
                }
                else
                {
                    DataTable dt = new DataTable();
                    dt.Columns.Add(new DataColumn("MATT", typeof(string)));
                    dt.Columns.Add(new DataColumn("TENBN", typeof(string)));
                    dt.Columns.Add(new DataColumn("DAY", typeof(DateTime)));
                    dgvTT.DataSource = dt;
                }
            this.KeyDown += FrmThanhToanTT_KeyDown; ;
        }

        private void FrmThanhToanTT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //btnTimKiem_Click(sender, e);
            }
            if (e.KeyCode == Keys.F5)
            {
                    List<ThanhToanTT> list = bus_tt.getListTT_Today();
                    if (list != null)
                    {
                        dgvTT.DataSource = list;
                    }
                    else
                    {
                        DataTable dt = new DataTable();
                        dt.Columns.Add(new DataColumn("MATT", typeof(string)));
                        dt.Columns.Add(new DataColumn("TENBN", typeof(string)));
                        dt.Columns.Add(new DataColumn("DAY", typeof(DateTime)));
                        dgvTT.DataSource = dt;
                    }
                }
            }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTimKiem.Texts))
            {
                this.OnLoad(e);
                return;
            }
            dgvTT.DataSource = bus_tt.timKiemTT_Today(txtTimKiem.Texts);
        }

        private void dgvTT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lbTrangThai.Text = string.Empty;
            lbTrangThai.ForeColor = Color.White;
            lbTrangThai.BackColor = Color.White;

            txtTongTien.Texts = string.Empty;
            if(dgvTT.CurrentRow == null)
            {
                return;
            }    
            string matt = dgvTT.CurrentRow.Cells["MATT"].Value.ToString();
            if (bus_tt.checkCTTT(matt) > 0)
            {
                btnThanhToan.Enabled = true;
                dgvCT.DataSource = bus_tt.getListCT(matt);
                txtTongTien.Texts = string.Format("{0:#,##0}", bus_tt.getTongTien(matt));
                if (bus_tt.getTrangThai(matt))
                {
                    btnThanhToan.Enabled = false;
                    lbTrangThai.Text = "Đã thanh toán";
                    lbTrangThai.ForeColor = Color.White;
                    lbTrangThai.BackColor = Color.Green;
                }
                else
                {
                    btnThanhToan.Enabled = true;
                    lbTrangThai.Text = "Chưa thanh toán";
                    lbTrangThai.ForeColor = Color.White;
                    lbTrangThai.BackColor = Color.Red;
                }
            }
            else
            {
                btnThanhToan.Enabled = false;
                DataTable dt = new DataTable();
                dt.Columns.Add(new DataColumn("TENT", typeof(string)));
                dt.Columns.Add(new DataColumn("DONGIA", typeof(string)));
                dt.Columns.Add(new DataColumn("SOLUONG", typeof(string)));
                dgvCT.DataSource = dt;
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            string matt = dgvTT.CurrentRow.Cells["MATT"].Value.ToString();
            if (string.IsNullOrEmpty(txtTienNhan.Texts))
            {
                errorProvider1.SetError(lb, "Vui lòng nhập tiền nhận");
                txtTienNhan.Focus();
                return;
            }
            errorProvider1.Clear();

            DialogResult r;
            r = MessageBox.Show("Bạn có chắc chắn muốn thanh toán " + matt + " ?", "Thông báo",

            MessageBoxButtons.YesNo, MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button1);

            if (r == DialogResult.Yes)
            {
                if (bus_tt.capNhatTrangThai(matt))
                {
                    foreach (DataGridViewRow t in dgvCT.Rows)
                    {
                        string mat = bus_kt.getMaT(t.Cells["TENT"].Value.ToString());
                        int sl = int.Parse(t.Cells["SOLUONG"].Value.ToString());
                        if(!bus_kt.capNhatSoLuong(mat,sl))
                        {
                            Program.AlertMessage("Đã xảy ra lỗi", MessageBoxIcon.Error);
                        }    
                    }
                    Program.AlertMessage("Thanh toán thành công", MessageBoxIcon.Information);

                    string macds = dgvTT.CurrentRow.Cells["MATT"].Value.ToString();
                    LS_KHAMBENH ls = bus_kt.getLS(bus_ls.getLS2(macds));

                    List<object> _lstSp = new List<object>();

                    foreach (DataGridViewRow r1 in dgvCT.Rows)
                    {
                        double a = double.Parse(r1.Cells["SOLUONG"].Value.ToString());
                        double b = double.Parse(r1.Cells["Column2"].Value.ToString());
                        double c = a * b;
                        _lstSp.Add(new
                        {
                            tent = r1.Cells["TENT"].Value.ToString(),
                            sovien = r1.Cells["SOLUONG"].Value.ToString(),
                            tongsl = string.Format("{0:#,##0}", r1.Cells["Column2"].Value),
                            tien = string.Format("{0:#,##0}", c)
                        });
                    }
                    DateTime? ngay = ls.NGKHAM;
                    string ngayCus = ngay.Value.Day + "/" + ngay.Value.Month + "/" + ngay.Value.Year;

                    List<string[]> data = new List<string[]>();
                    data.Add(new string[] { "tenbn", "tenbs", "chandoan", "ngay", "TongGia" });
                    data.Add(new string[] { dgvTT.CurrentRow.Cells["TENBN"].Value.ToString(), bus_ls.getTenBS(ls.MALS), ls.CHANDOAN, ngayCus, string.Format("{0:#,##0}", bus_tt.getTongTien(macds)) });

                    // Show thông tin
                    new Reports<object>().export_Word("reportTT.docx", "ListSP", _lstSp, data);
                    this.OnLoad(e);
                    return;
                }
                Program.AlertMessage("Đã xảy ra lỗi thanh toán", MessageBoxIcon.Error);
            }
        }

        private void txtTimKiem__TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTimKiem.Texts))
            {
                this.OnLoad(e);
                return;
            }
            dgvTT.DataSource = bus_tt.timKiemTT_Today(txtTimKiem.Texts);
        }
    }
}
