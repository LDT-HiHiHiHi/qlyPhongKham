using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmConfig : Form
    {
        public frmConfig()
        {
            InitializeComponent();
            btnLuu.Enabled = false;
        }

        private void cbServername_DropDown(object sender, EventArgs e)
        {
            cbServername.DataSource = BUS.BUS_db.GetServername();
            cbServername.DisplayMember = "Servername";
        }

        private void cbDb_DropDown(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbServername.Text))
            {
                Program.AlertMessage("Vui lòng chọn server", MessageBoxIcon.Warning);
                cbServername.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtUsername.Texts))
            {
                Program.AlertMessage("Vui lòng nhập Username", MessageBoxIcon.Warning);
                txtUsername.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtPw.Texts))
            {
                Program.AlertMessage("Vui lòng nhập mật khẩu", MessageBoxIcon.Warning);
                txtPw.Focus();
                return;
            }
            try
            {
                cbDb.DataSource = BUS.BUS_db.GetDBName(cbServername.Text, txtUsername.Texts, txtPw.Texts);
                cbDb.DisplayMember = "name";
                btnLuu.Enabled = true;
            }
            catch (Exception err)
            {
                Program.AlertMessage("Vui lòng kiểm tra lại thông tin", MessageBoxIcon.Warning);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            BUS.BUS_db.SaveConfig(cbServername.Text, txtUsername.Texts, txtPw.Texts, cbDb.Text);
            this.Close();
        }

        private void customButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}