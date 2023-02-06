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
    public partial class frmThemNguoiDung : Form_Edit
    {
        BUS_QLTK bus_qltk = new BUS.BUS_QLTK();
        BUS_QLNND bus_qlnnd = new BUS.BUS_QLNND();
        public frmThemNguoiDung()
        {
            InitializeComponent();
            // set background for data gridview
            drvTK.RowsDefaultCellStyle.BackColor = Color.FromArgb(217, 226, 243);
            drvTK.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;

            drvNhom.RowsDefaultCellStyle.BackColor = Color.White;
            drvNhom.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;

            // null value
            drvTK.DefaultCellStyle.NullValue = drvNhom.DefaultCellStyle.NullValue = "no entry";

            menu.PrimaryColor = Color.FromArgb(30, 144, 255);
        }

        private void frmThemNguoiDung_Activated(object sender, EventArgs e)
        {
            //Activate the corresponding Tabpage
            tabCtrl.SelectedTab = tabPag;

            if (!tabCtrl.Visible)
            {
                tabCtrl.Visible = true;
            }
        }

        private void frmThemNguoiDung_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Destroy the corresponding Tabpage when closing MDI child form
            this.tabPag.Dispose();
            //If no Tabpage left
            if (!tabCtrl.HasChildren)
            {
                tabCtrl.Visible = false;
            }
        }

        private void frmThemNguoiDung_Load(object sender, EventArgs e)
        {
            btnThem.Enabled = false;
            this.cbNhoms.ValueMember = "MAQUYEN";
            this.cbNhoms.DisplayMember = "TENQUYEN";
            this.cbNhoms.DataSource = bus_qlnnd.getGrs();
        }

        private void drvTK_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            drvTK.Rows[e.RowIndex].Cells["No"].Value = (e.RowIndex + 1).ToString();
        }
        private void LoadDrv()
        {
            int idGr = int.Parse(cbNhoms.SelectedValue());
            drvTK.DataSource = bus_qltk.getDSTK(idGr);
            drvNhom.DataSource = bus_qltk.getDSNhomTK(idGr);
        }

        private void cbNhoms_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDrv();
        }

        private void drvNhom_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            drvNhom.Rows[e.RowIndex].Cells["No_grA"].Value = (e.RowIndex + 1).ToString();
        }

        private void btnAddOne_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in drvTK.SelectedRows)
            {
                bus_qlnnd.addToGr(int.Parse(cbNhoms.SelectedValue()), item.Cells["ID"].Value.ToString());
            }

            LoadDrv();
        }

        private void btnAddAll_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in drvTK.Rows)
            {
                bus_qlnnd.addToGr(int.Parse(cbNhoms.SelectedValue()), item.Cells["ID"].Value.ToString());
            }

            LoadDrv();
        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            this.OnLoad(e);
        }

        private void btnDelOne_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in drvNhom.SelectedRows)
            {
                bus_qlnnd.DelToGr(int.Parse(cbNhoms.SelectedValue()), item.Cells["IDTK_grA"].Value.ToString());
            }

            LoadDrv();
        }

        private void btnDelAll_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in drvNhom.Rows)
            {
                bus_qlnnd.DelToGr(int.Parse(cbNhoms.SelectedValue()), item.Cells["IDTK_grA"].Value.ToString());
            }

            LoadDrv();
        }

        private void drvNhom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (drvNhom.CurrentRow == null)
                return;
            if(cbNhoms.Texts.Equals("BACSI"))
            {
                btnThem.Enabled = true;
            }    
        }

        private void drvTK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (drvTK.CurrentRow == null)
                return;
        }

        private void thêmBấcSĩToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThemBacSi.username = drvNhom.CurrentRow.Cells["Username_grA"].Value.ToString();
            frmThemBacSi.idtk = drvNhom.CurrentRow.Cells["IDTK_grA"].Value.ToString();
            new frmThemBacSi().ShowDialog();

            btnThem.Enabled = false;
        }
    }
}
