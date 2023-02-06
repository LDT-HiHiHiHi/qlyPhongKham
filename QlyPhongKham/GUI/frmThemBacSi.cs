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
    public partial class frmThemBacSi : Form
    {
        BUS_QLBN bus_qlbn = new BUS_QLBN();
        BUS_KhamBenh bus_kb = new BUS_KhamBenh();
        public static string username;
        public static string idtk;
        public frmThemBacSi()
        {
            InitializeComponent();
        }

        private void frmThemBacSi_Load(object sender, EventArgs e)
        {
            lbTen.Text = username;
            cboPhong.DataSource = bus_qlbn.getListPhong();
            cboPhong.DisplayMember = "TENPHONG";
            cboPhong.ValueMember = "MAPHONG";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maphong = cboPhong.SelectedValue();
            string mabs = bus_kb.getMaBacSi(maphong);
            if (!string.IsNullOrEmpty(mabs))
            {
                Program.AlertMessage("Phòng đã có bác sĩ", MessageBoxIcon.Information);
                return;
            }

            if (bus_kb.checkBacSi(idtk) > 0)
            {
                Program.AlertMessage("Bác sĩ đã tồn tại !", MessageBoxIcon.Information);
                return;
            }

            BACSI bs = new BACSI
            {
                MABS = "BS" + Program.phatSinhMaTuDong(),
                IDTK = idtk,
                MAPHONG = maphong
            };
            if(bus_qlbn.themBacSi(bs))
            {
                Program.AlertMessage("Thêm bác sĩ thành công !", MessageBoxIcon.Information);
                this.Dispose();
                return;
            }
            Program.AlertMessage("Đã xảy ra lỗi 1", MessageBoxIcon.Error);
        }
    }
}
