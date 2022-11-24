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
    public partial class frmPhanQuyen : Form
    {
        BUS_QLNND bus_qlnnd = new BUS_QLNND();
        BUS_PhanQuyen bus_phanQuyen = new BUS_PhanQuyen();
        public frmPhanQuyen()
        {
            InitializeComponent();
        }

        private void frmPhanQuyen_Load(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            drvNhomNguoiDung.DataSource = bus_qlnnd.getGrs();
            drvNhomNguoiDung.RowsDefaultCellStyle.BackColor = Color.White;
            drvNhomNguoiDung.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
        }

        private void drvNhomNguoiDung_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idQ = int.Parse(drvNhomNguoiDung.CurrentRow.Cells["MAQUYEN"].Value.ToString());

            drvPhanQuyen.DataSource = bus_phanQuyen.getPhanQuyens(idQ);
            drvPhanQuyen.RowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
            drvPhanQuyen.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            btnLuu.Enabled = true;
            HandleCkAll();
        }
        private void HandleCkAll()
        {
            ckAll.Checked = true;
            foreach (DataGridViewRow pq in drvPhanQuyen.Rows)
            {
                if (!(pq.Cells["COQUYEN"].Value == null ? false : bool.Parse(pq.Cells["COQUYEN"].Value.ToString())))
                {
                    ckAll.Checked = false;
                    return;
                }
            }
        }

        private void ckAll_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow pq in drvPhanQuyen.Rows)
            {
                pq.Cells["COQUYEN"].Value = ckAll.Checked;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                int idQuyen = int.Parse(drvNhomNguoiDung.CurrentRow.Cells["MAQUYEN"].Value.ToString());
                foreach (DataGridViewRow pq in drvPhanQuyen.Rows)
                {
                    bus_phanQuyen.luuTT_PQ(new DTO.QL_PHANQUYEN
                    {
                        MAQUYEN = idQuyen,
                        ID_MH = pq.Cells["ID_PQ"].Value.ToString(),
                        COQUYEN = pq.Cells["COQUYEN"].Value == null ? false : bool.Parse(pq.Cells["COQUYEN"].Value.ToString())
                    });
                }
                MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                this.OnLoad(e);
            }
            catch (Exception)
            {
                MessageBox.Show("Đã xảy ra lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

    }
}
