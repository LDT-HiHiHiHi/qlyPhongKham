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
    public partial class frmNhomNguoiDung : Form_Edit
    {
        BUS_QLNND bus_qlnnd = new BUS_QLNND();
        
        public frmNhomNguoiDung()
        {
            InitializeComponent();

            drvThongTinNhom.RowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
            drvThongTinNhom.AlternatingRowsDefaultCellStyle.BackColor = Color.White;

            // null value
            drvThongTinNhom.DefaultCellStyle.NullValue = "no entry";
        }

        private void thêmNhómToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThongTinNhom frm = new frmThongTinNhom();
            frm.ShowDialog();
            // thực hiện thêm nhóm
            if (frm.TenNhom != null)
            {
                bus_qlnnd.themNhom(frm.TenNhom);
                this.OnLoad(e);
            }
        }

        private void frmNhomNguoiDung_Load(object sender, EventArgs e)
        {
            btnSua.Enabled = btnXoa.Enabled = false;
            drvThongTinNhom.DataSource = bus_qlnnd.getGrs();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            var a = drvThongTinNhom.CurrentRow.Cells[0].Value;
        }

        private void xóaNhómToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (rs == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    bus_qlnnd.xoaNhom(drvThongTinNhom.CurrentRow.Cells["TenNhom"].Value.ToString());
                    this.OnLoad(e);
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                }
            }
        }

        private void drvThongTinNhom_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex != -1 && e.RowIndex != -1 && e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                DataGridViewCell c = (sender as DataGridView)[e.ColumnIndex, e.RowIndex];
                if (!c.Selected)
                {
                    c.DataGridView.ClearSelection();
                    c.DataGridView.CurrentCell = c;
                    c.Selected = true;
                }
                btnXoa.Enabled = btnSua.Enabled = true;
            }
            else if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                btnXoa.Enabled = btnSua.Enabled = false;
            }
        }

        private void drvThongTinNhom_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
                btnXoa.Enabled = btnSua.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            frmThongTinNhom frm = new frmThongTinNhom();
            frm.TenNhom = drvThongTinNhom.CurrentRow.Cells["TenNhom"].Value.ToString();
            frm.ShowDialog();

            if (frm.TenNhom != null)
            {
                bus_qlnnd.chinhSua(int.Parse(drvThongTinNhom.CurrentRow.Cells["ID"].Value.ToString()), frm.TenNhom);
                this.OnLoad(e);
            }
        }

        private void drvThongTinNhom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSua.Enabled = btnXoa.Enabled = true;
        }

        private void frmNhomNguoiDung_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Destroy the corresponding Tabpage when closing MDI child form
            this.tabPag.Dispose();

            //If no Tabpage left
            if (!tabCtrl.HasChildren)
            {
                tabCtrl.Visible = false;
            }
        }

        private void frmNhomNguoiDung_Activated(object sender, EventArgs e)
        {
            //Activate the corresponding Tabpage
            tabCtrl.SelectedTab = tabPag;
            if (!tabCtrl.Visible)
            {
                tabCtrl.Visible = true;
            }
        }
    }
}
