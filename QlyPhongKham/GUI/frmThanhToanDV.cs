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
    public partial class frmThanhToanDV : Form_Edit
    {
        BUS_ThanhToanDV bus_dv = new BUS_ThanhToanDV();
        BUS_KhamBenh bus_kb = new BUS_KhamBenh();
        BUS_KeToa bus_kt = new BUS_KeToa();
        BUS_LichSuKB bus_ls = new BUS_LichSuKB();
        private int? currentSelectionStart;
        private object val;
        public frmThanhToanDV()
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
        private void frmThanhToanDV_Load(object sender, EventArgs e)
        {
            btnThanhToan.Enabled = false;
            lbTrangThai.Text = txtTongTien.Texts = string.Empty;
            lbTrangThai.BackColor = Color.White;
            if (checkBox.Checked)
            {
                List<ThanhToanDV> list = bus_dv.getListCD();
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
            }   
            else
            {
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
            }
            this.KeyDown += FrmThanhToanDV_KeyDown;
        }

        private void FrmThanhToanDV_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnTimKiem_Click(sender, e);
            }
            if (e.KeyCode == Keys.F5)
            {
                if (checkBox.Checked)
                {
                    List<ThanhToanDV> list = bus_dv.getListCD();
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
                }
                else
                {
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
                }
            }
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            this.OnLoad(e);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtTimKiem.Texts))
            {
                this.OnLoad(e);
                return;
            }   
            if(checkBox.Checked)
            {
                dgvCD.DataSource = bus_dv.timKiemCD(txtTimKiem.Texts);
            }
            else
            {
                dgvCD.DataSource = bus_dv.timKiemCD_Today(txtTimKiem.Texts);
            }
        }

        private void dgvCD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCD.CurrentRow == null)
                return;

            lbTrangThai.Text = string.Empty;
            lbTrangThai.ForeColor = Color.White;
            lbTrangThai.BackColor = Color.White;
            
            txtTongTien.Texts = string.Empty;
            string macd = dgvCD.CurrentRow.Cells["MACD"].Value.ToString();
            if (bus_dv.checkCTCD(macd) > 0)
            {
                btnThanhToan.Enabled = true;
                dgvCT.DataSource = bus_kb.getListCT(macd);
                txtTongTien.Texts = string.Format("{0:#,##0}",bus_dv.getTongTien(macd));
                if(bus_dv.getTrangThai(macd))
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
                dt.Columns.Add(new DataColumn("MACD", typeof(string)));
                dt.Columns.Add(new DataColumn("TENDV", typeof(string)));
                dt.Columns.Add(new DataColumn("MOTA", typeof(string)));
                dt.Columns.Add(new DataColumn("KETQUA", typeof(string)));
                dt.Columns.Add(new DataColumn("DONGIA", typeof(double)));
                dgvCT.DataSource = dt;
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

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            string macd = dgvCD.CurrentRow.Cells["MACD"].Value.ToString();
            if (string.IsNullOrEmpty(txtTienNhan.Texts))
            {
                errorProvider1.SetError(lb, "Vui lòng nhập tiền nhận");
                txtTienNhan.Focus();
                return;
            }
            errorProvider1.Clear();

            DialogResult r;
            r = MessageBox.Show("Bạn có chắc chắn muốn thanh toán " + macd + " ?", "Thông báo",

            MessageBoxButtons.YesNo, MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button1);

            if (r == DialogResult.Yes)
            {
                if(bus_dv.capNhatTrangThai(macd))
                {

                    string macds = dgvCD.CurrentRow.Cells["MACD"].Value.ToString();
                    LS_KHAMBENH ls = bus_kt.getLS(bus_ls.getLS(macds));

                    List<object> _lstSp = new List<object>();

                    foreach (DataGridViewRow r1 in dgvCT.Rows)
                    {
                        _lstSp.Add(new
                        {
                            tent = r1.Cells["Column1"].Value.ToString(),
                            sovien = string.Format("{0:#,##0}", r1.Cells["Column2"].Value)
                        });
                    }
                    DateTime? ngay = ls.NGKHAM;
                    string ngayCus = ngay.Value.Day + "/" + ngay.Value.Month + "/" + ngay.Value.Year;

                    List<string[]> data = new List<string[]>();
                    data.Add(new string[] { "tenbn", "tenbs", "ngay", "TongGia"});
                    data.Add(new string[] { dgvCD.CurrentRow.Cells["TENBN"].Value.ToString(), bus_ls.getTenBS(bus_ls.getLS(macds)), ngayCus, string.Format("{0:#,##0}", bus_dv.getTongTien(macds)) });

                    // Show thông tin
                    new Reports<object>().export_Word("reportTTDV.docx", "ListSP", _lstSp, data);
                    Program.AlertMessage("Thanh toán thành công", MessageBoxIcon.Information);
                    this.OnLoad(e);
                    return;
                }
                Program.AlertMessage("Đã xảy ra lỗi thanh toán", MessageBoxIcon.Error);
            }
        }

        private void frmThanhToanDV_Activated(object sender, EventArgs e)
        {
            //Activate the corresponding Tabpage
            tabCtrl.SelectedTab = tabPag;

            if (!tabCtrl.Visible)
            {
                tabCtrl.Visible = true;
            }
        }

        private void frmThanhToanDV_FormClosing(object sender, FormClosingEventArgs e)
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
