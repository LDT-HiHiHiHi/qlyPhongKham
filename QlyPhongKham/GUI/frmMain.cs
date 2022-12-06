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
        public static int childCount_PQ = 0;
        public static int childCount_MH = 0;
        public static int childCount_N = 0;
        public static int childCount_NND = 0;
        public static int childCount_TK = 0;
        public static int childCount_BN = 0;
        public static int childCount_KB = 0;
        public static int childCount_DV = 0;
        public static int childCount_TH = 0;
        public static int childCount_TT = 0;

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
             DialogResult r;
            r = MessageBox.Show("Bạn có chắc chắn muốn thoát ? ", "Thông báo",

            MessageBoxButtons.YesNo, MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button1);

            if (r == DialogResult.Yes)
            {
                Thread t = new Thread(new ThreadStart(ThreadLogout));
                t.SetApartmentState(ApartmentState.STA);
                t.Start();
                this.Dispose();
            }
        }

        private void phânQuyềnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPhanQuyen frm = new frmPhanQuyen();
            frm.MdiParent = this;
            if(childCount_PQ > 0)
            {
                frm.Text = frm.Text + " (" + childCount_PQ.ToString() + ")";
            }    
            //child Form will now hold a reference value to the tab control
            frm.TabCtrl = tabControl1;

            //Add a Tabpage and enables it
            TabPage tp = new TabPage();
            tp.Parent = tabControl1;
            tp.Text = frm.Text;
            tp.Show();

            //child Form will now hold a reference value to a tabpage
            frm.TabPag = tp;

            //Activate the MDI child form
            frm.Show();
            childCount_PQ++;

            //Activate the newly created Tabpage
            tabControl1.SelectedTab = tp;
        }

        private void quảnLýMànHìnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManHinh frm = new frmManHinh();
            frm.MdiParent = this;
            if (childCount_MH > 0)
            {
                frm.Text = frm.Text + " (" + childCount_MH.ToString() + ")";
            }
            //child Form will now hold a reference value to the tab control
            frm.TabCtrl = tabControl1;

            //Add a Tabpage and enables it
            TabPage tp = new TabPage();
            tp.Parent = tabControl1;
            tp.Text = frm.Text;
            tp.Show();

            //child Form will now hold a reference value to a tabpage
            frm.TabPag = tp;

            //Activate the MDI child form
            frm.Show();
            childCount_MH++;

            //Activate the newly created Tabpage
            tabControl1.SelectedTab = tp;
        }

        private void thêmNgườiDùngVàoNhómToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThemNguoiDung frm = new frmThemNguoiDung ();
            frm.MdiParent = this;
            if (childCount_N > 0)
            {
                frm.Text = frm.Text + " (" + childCount_N.ToString() + ")";
            }
            //child Form will now hold a reference value to the tab control
            frm.TabCtrl = tabControl1;

            //Add a Tabpage and enables it
            TabPage tp = new TabPage();
            tp.Parent = tabControl1;
            tp.Text = frm.Text;
            tp.Show();

            //child Form will now hold a reference value to a tabpage
            frm.TabPag = tp;

            //Activate the MDI child form
            frm.Show();
            childCount_NND++;

            //Activate the newly created Tabpage
            tabControl1.SelectedTab = tp;
        }

        private void quảnLýNhómNgườiDùngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhomNguoiDung frm = new frmNhomNguoiDung();
            frm.MdiParent = this;
            if (childCount_N > 0)
            {
                frm.Text = frm.Text + " (" + childCount_N.ToString() + ")";
            }
            //child Form will now hold a reference value to the tab control
            frm.TabCtrl = tabControl1;

            //Add a Tabpage and enables it
            TabPage tp = new TabPage();
            tp.Parent = tabControl1;
            tp.Text = frm.Text;
            tp.Show();

            //child Form will now hold a reference value to a tabpage
            frm.TabPag = tp;

            //Activate the MDI child form
            frm.Show();
            childCount_N++;

            //Activate the newly created Tabpage
            tabControl1.SelectedTab = tp;
        }

        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Form_Edit childForm in this.MdiChildren)
            {
                //Check for its corresponding MDI child form
                if (childForm.TabPag.Equals(tabControl1.SelectedTab))
                {
                    //Activate the MDI child form
                    childForm.Select();
                }
            }
        }

        public void quảnLýTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTaiKhoan frm = new frmTaiKhoan();
            frm.MdiParent = this;
            if (childCount_TK > 0)
            {
                frm.Text = frm.Text + " (" + childCount_TK.ToString() + ")";
            }
            //child Form will now hold a reference value to the tab control
            frm.TabCtrl = tabControl1;

            //Add a Tabpage and enables it
            TabPage tp = new TabPage();
            tp.Parent = tabControl1;
            tp.Text = frm.Text;
            tp.Show();

            //child Form will now hold a reference value to a tabpage
            frm.TabPag = tp;

            //Activate the MDI child form
            frm.Show();
            childCount_TK++;

            //Activate the newly created Tabpage
            tabControl1.SelectedTab = tp;
        }

        private void quảnLýBệnhNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQLBN frm = new frmQLBN();
            frm.MdiParent = this;
            if (childCount_BN > 0)
            {
                frm.Text = frm.Text + " (" + childCount_BN.ToString() + ")";
            }
            //child Form will now hold a reference value to the tab control
            frm.TabCtrl = tabControl1;

            //Add a Tabpage and enables it
            TabPage tp = new TabPage();
            tp.Parent = tabControl1;
            tp.Text = frm.Text;
            tp.Show();

            //child Form will now hold a reference value to a tabpage
            frm.TabPag = tp;

            //Activate the MDI child form
            frm.Show();
            childCount_BN++;

            //Activate the newly created Tabpage
            tabControl1.SelectedTab = tp;
        }

        private void khámBệnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKhamBenh frm = new frmKhamBenh();
            frm.MdiParent = this;
            if (childCount_KB > 0)
            {
                frm.Text = frm.Text + " (" + childCount_KB.ToString() + ")";
            }
            //child Form will now hold a reference value to the tab control
            frm.TabCtrl = tabControl1;

            //Add a Tabpage and enables it
            TabPage tp = new TabPage();
            tp.Parent = tabControl1;
            tp.Text = frm.Text;
            tp.Show();

            //child Form will now hold a reference value to a tabpage
            frm.TabPag = tp;

            //Activate the MDI child form
            frm.Show();
            childCount_KB++;

            //Activate the newly created Tabpage
            tabControl1.SelectedTab = tp;
        }

        private void kêToaThuốcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThanhToanDV frm = new frmThanhToanDV();
            frm.MdiParent = this;
            if (childCount_DV > 0)
            {
                frm.Text = frm.Text + " (" + childCount_DV.ToString() + ")";
            }
            //child Form will now hold a reference value to the tab control
            frm.TabCtrl = tabControl1;

            //Add a Tabpage and enables it
            TabPage tp = new TabPage();
            tp.Parent = tabControl1;
            tp.Text = frm.Text;
            tp.Show();

            //child Form will now hold a reference value to a tabpage
            frm.TabPag = tp;

            //Activate the MDI child form
            frm.Show();
            childCount_DV++;

            //Activate the newly created Tabpage
            tabControl1.SelectedTab = tp;
        }

        private void thựcHiệnDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThucHienDichVu frm = new frmThucHienDichVu();
            frm.MdiParent = this;
            if (childCount_TH > 0)
            {
                frm.Text = frm.Text + " (" + childCount_TH.ToString() + ")";
            }
            //child Form will now hold a reference value to the tab control
            frm.TabCtrl = tabControl1;

            //Add a Tabpage and enables it
            TabPage tp = new TabPage();
            tp.Parent = tabControl1;
            tp.Text = frm.Text;
            tp.Show();

            //child Form will now hold a reference value to a tabpage
            frm.TabPag = tp;

            //Activate the MDI child form
            frm.Show();
            childCount_TH++;

            //Activate the newly created Tabpage
            tabControl1.SelectedTab = tp;
        }

        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            Font fntTab;
            Brush bshBack;
            Brush bshFore;
            if (e.Index == this.tabControl1.SelectedIndex)
            {
                fntTab = new Font(e.Font, FontStyle.Bold);
                bshBack = new System.Drawing.Drawing2D.LinearGradientBrush(e.Bounds, Color.Blue, Color.LightSkyBlue, System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal);
                bshFore = Brushes.White;
            }
            else
            {
                fntTab = e.Font;
                bshBack = new SolidBrush(Color.White);
                bshFore = new SolidBrush(Color.Black);
            }
            string tabName = this.tabControl1.TabPages[e.Index].Text;
            StringFormat sftTab = new StringFormat(StringFormatFlags.NoClip);
            sftTab.Alignment = StringAlignment.Center;
            sftTab.LineAlignment = StringAlignment.Center;
            e.Graphics.FillRectangle(bshBack, e.Bounds);
            Rectangle recTab = e.Bounds;
            recTab = new Rectangle(recTab.X, recTab.Y + 4, recTab.Width, recTab.Height - 4);
            e.Graphics.DrawString(tabName, fntTab, bshFore, recTab, sftTab);

        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmThongTinCaNhan().ShowDialog();
        }

        private void xemThôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThanhToanTT frm = new frmThanhToanTT();
            frm.MdiParent = this;
            if (childCount_BN > 0)
            {
                frm.Text = frm.Text + " (" + childCount_BN.ToString() + ")";
            }
            //child Form will now hold a reference value to the tab control
            frm.TabCtrl = tabControl1;

            //Add a Tabpage and enables it
            TabPage tp = new TabPage();
            tp.Parent = tabControl1;
            tp.Text = frm.Text;
            tp.Show();

            //child Form will now hold a reference value to a tabpage
            frm.TabPag = tp;

            //Activate the MDI child form
            frm.Show();
            childCount_TT++;

            //Activate the newly created Tabpage
            tabControl1.SelectedTab = tp;
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmDoiMatKhau().ShowDialog();

        }
    }
}
