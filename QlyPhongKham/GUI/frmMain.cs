using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private bool CheckAllMenuChildVisible(ToolStripItemCollection mnuItems)
        {
            foreach (ToolStripItem mnuItem in mnuItems)
            {
                if (mnuItem is ToolStripMenuItem && mnuItem.Enabled)
                    return true;
                else if (mnuItem is ToolStripSeparator)
                    continue;
            }
            return false;
        }

        private void FindMenuPhanQuyen(ToolStripItemCollection mnuItem, string pScreenName, bool pEnable)
        {
            foreach (ToolStripItem mnu in mnuItem)
            {
                if (mnu is ToolStripMenuItem && (mnu as ToolStripMenuItem).DropDownItems.Count > 0)
                {
                    FindMenuPhanQuyen((mnu as ToolStripMenuItem).DropDownItems, pScreenName, pEnable);
                    mnu.Enabled = mnu.Visible = CheckAllMenuChildVisible((mnu as ToolStripMenuItem).DropDownItems);
                }
                else if (string.Equals(pScreenName, mnu.Tag))
                {
                    mnu.Enabled = pEnable;
                    if (pEnable)
                        mnu.Tag = pEnable; // gán màn hình đã được chọn
                    mnu.Visible = pEnable; // ẩn màn hình chức năng
                }
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            BUS.BUS_QLTK bus_qltk = new BUS.BUS_QLTK();

            var lstND = bus_qltk.lstNhomNguoiDung(frmLogin.USERNAME);

            foreach (var item in lstND)
            {
                var dsQuyen = bus_qltk.lstManHinh(item.IdGr); // lấy các màn hình chức năng đã được phân quyền
                foreach (var mh in dsQuyen)
                {
                    FindMenuPhanQuyen(this.menuStrip1.Items, mh.IdMH, mh.CoQuyen);
                }
            }
        }

        private void ThreadLogout()
        {
            Application.Run(new frmLogin());
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(new ThreadStart(ThreadLogout));
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
            this.Dispose();
        }

        private void phânQuyềnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPhanQuyen frm = new frmPhanQuyen();
            frm.MdiParent = this;

            frm.Show();
        }

    }
}
