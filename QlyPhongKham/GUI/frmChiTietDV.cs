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
    public partial class frmChiTietDV : Form
    {
        public static bool flag = false;
        public static string mota = string.Empty;
        BUS_KhamBenh bus_kb = new BUS_KhamBenh();
        public frmChiTietDV()
        {
            InitializeComponent();
        }

        private void frmChiTietDV_Load(object sender, EventArgs e)
        {
            flag = false;
            lbHeader.Text = frmKhamBenh.TDV;
            dgvCT.DataSource = bus_kb.getListCTDV(frmKhamBenh.DV);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow t in dgvCT.Rows)
            {
                if(t.Cells["CK"].Value != null)
                {
                    if(t.Cells["CK"].Value.ToString() == true.ToString())
                    {
                        mota = mota + t.Cells["TEN"].Value.ToString() + ", ";
                    }    
                }    
            }
            flag = true;
            this.Dispose();
        }
    }
}
