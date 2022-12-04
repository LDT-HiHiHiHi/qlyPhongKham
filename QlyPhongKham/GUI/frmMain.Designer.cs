namespace GUI
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.chứcNăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thựcHiệnDịchVụToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kêToaThuốcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.khámBệnhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xemThôngTinCáNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phânQuyềnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.thôngTinCáNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýBệnhNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.quảnLýTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýNhómNgườiDùngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýMànHìnhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmNgườiDùngVàoNhómToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Window;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chứcNăngToolStripMenuItem,
            this.quảnLýToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(982, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tabControl1
            // 
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(982, 35);
            this.tabControl1.TabIndex = 3;
            this.tabControl1.Visible = false;
            this.tabControl1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControl1_DrawItem);
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.TabControl1_SelectedIndexChanged);
            // 
            // chứcNăngToolStripMenuItem
            // 
            this.chứcNăngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thựcHiệnDịchVụToolStripMenuItem,
            this.kêToaThuốcToolStripMenuItem,
            this.khámBệnhToolStripMenuItem,
            this.xemThôngTinCáNhânToolStripMenuItem,
            this.phânQuyềnToolStripMenuItem,
            this.toolStripSeparator3,
            this.thôngTinCáNhânToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem1});
            this.chứcNăngToolStripMenuItem.Image = global::GUI.Properties.Resources.software;
            this.chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
            this.chứcNăngToolStripMenuItem.Size = new System.Drawing.Size(105, 24);
            this.chứcNăngToolStripMenuItem.Text = "Hệ thống";
            // 
            // thựcHiệnDịchVụToolStripMenuItem
            // 
            this.thựcHiệnDịchVụToolStripMenuItem.Image = global::GUI.Properties.Resources.customer;
            this.thựcHiệnDịchVụToolStripMenuItem.Name = "thựcHiệnDịchVụToolStripMenuItem";
            this.thựcHiệnDịchVụToolStripMenuItem.Size = new System.Drawing.Size(256, 26);
            this.thựcHiệnDịchVụToolStripMenuItem.Tag = "M4";
            this.thựcHiệnDịchVụToolStripMenuItem.Text = "Thực hiện dịch vụ";
            this.thựcHiệnDịchVụToolStripMenuItem.Click += new System.EventHandler(this.thựcHiệnDịchVụToolStripMenuItem_Click);
            // 
            // kêToaThuốcToolStripMenuItem
            // 
            this.kêToaThuốcToolStripMenuItem.Image = global::GUI.Properties.Resources.bill;
            this.kêToaThuốcToolStripMenuItem.Name = "kêToaThuốcToolStripMenuItem";
            this.kêToaThuốcToolStripMenuItem.Size = new System.Drawing.Size(256, 26);
            this.kêToaThuốcToolStripMenuItem.Tag = "M2";
            this.kêToaThuốcToolStripMenuItem.Text = "Thanh toán địch vụ";
            this.kêToaThuốcToolStripMenuItem.Click += new System.EventHandler(this.kêToaThuốcToolStripMenuItem_Click);
            // 
            // khámBệnhToolStripMenuItem
            // 
            this.khámBệnhToolStripMenuItem.Image = global::GUI.Properties.Resources.examination;
            this.khámBệnhToolStripMenuItem.Name = "khámBệnhToolStripMenuItem";
            this.khámBệnhToolStripMenuItem.Size = new System.Drawing.Size(256, 26);
            this.khámBệnhToolStripMenuItem.Tag = "M9";
            this.khámBệnhToolStripMenuItem.Text = "Khám bệnh";
            this.khámBệnhToolStripMenuItem.Click += new System.EventHandler(this.khámBệnhToolStripMenuItem_Click);
            // 
            // xemThôngTinCáNhânToolStripMenuItem
            // 
            this.xemThôngTinCáNhânToolStripMenuItem.Image = global::GUI.Properties.Resources.credit_card;
            this.xemThôngTinCáNhânToolStripMenuItem.Name = "xemThôngTinCáNhânToolStripMenuItem";
            this.xemThôngTinCáNhânToolStripMenuItem.Size = new System.Drawing.Size(256, 26);
            this.xemThôngTinCáNhânToolStripMenuItem.Tag = "M5";
            this.xemThôngTinCáNhânToolStripMenuItem.Text = "Thanh toán toa thuốc";
            // 
            // phânQuyềnToolStripMenuItem
            // 
            this.phânQuyềnToolStripMenuItem.Image = global::GUI.Properties.Resources.decentralized__1_;
            this.phânQuyềnToolStripMenuItem.Name = "phânQuyềnToolStripMenuItem";
            this.phânQuyềnToolStripMenuItem.Size = new System.Drawing.Size(256, 26);
            this.phânQuyềnToolStripMenuItem.Tag = "M6";
            this.phânQuyềnToolStripMenuItem.Text = "Phân quyền";
            this.phânQuyềnToolStripMenuItem.Click += new System.EventHandler(this.phânQuyềnToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(253, 6);
            // 
            // thôngTinCáNhânToolStripMenuItem
            // 
            this.thôngTinCáNhânToolStripMenuItem.Image = global::GUI.Properties.Resources.information;
            this.thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
            this.thôngTinCáNhânToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.thôngTinCáNhânToolStripMenuItem.Size = new System.Drawing.Size(256, 26);
            this.thôngTinCáNhânToolStripMenuItem.Text = "Thông tin cá nhân";
            this.thôngTinCáNhânToolStripMenuItem.Click += new System.EventHandler(this.thôngTinCáNhânToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem1
            // 
            this.đăngXuấtToolStripMenuItem1.Image = global::GUI.Properties.Resources.logout;
            this.đăngXuấtToolStripMenuItem1.Name = "đăngXuấtToolStripMenuItem1";
            this.đăngXuấtToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.đăngXuấtToolStripMenuItem1.Size = new System.Drawing.Size(256, 26);
            this.đăngXuấtToolStripMenuItem1.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem1.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // quảnLýToolStripMenuItem
            // 
            this.quảnLýToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýBệnhNhânToolStripMenuItem,
            this.toolStripSeparator2,
            this.quảnLýTàiKhoảnToolStripMenuItem,
            this.quảnLýNhómNgườiDùngToolStripMenuItem,
            this.quảnLýMànHìnhToolStripMenuItem,
            this.thêmNgườiDùngVàoNhómToolStripMenuItem});
            this.quảnLýToolStripMenuItem.Image = global::GUI.Properties.Resources.clipboard;
            this.quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            this.quảnLýToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.quảnLýToolStripMenuItem.Text = "Quản lý";
            // 
            // quảnLýBệnhNhânToolStripMenuItem
            // 
            this.quảnLýBệnhNhânToolStripMenuItem.Image = global::GUI.Properties.Resources.management;
            this.quảnLýBệnhNhânToolStripMenuItem.Name = "quảnLýBệnhNhânToolStripMenuItem";
            this.quảnLýBệnhNhânToolStripMenuItem.Size = new System.Drawing.Size(280, 26);
            this.quảnLýBệnhNhânToolStripMenuItem.Tag = "M1";
            this.quảnLýBệnhNhânToolStripMenuItem.Text = "Quản lý bệnh nhân";
            this.quảnLýBệnhNhânToolStripMenuItem.Click += new System.EventHandler(this.quảnLýBệnhNhânToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(277, 6);
            // 
            // quảnLýTàiKhoảnToolStripMenuItem
            // 
            this.quảnLýTàiKhoảnToolStripMenuItem.Image = global::GUI.Properties.Resources.skills;
            this.quảnLýTàiKhoảnToolStripMenuItem.Name = "quảnLýTàiKhoảnToolStripMenuItem";
            this.quảnLýTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(280, 26);
            this.quảnLýTàiKhoảnToolStripMenuItem.Tag = "M3";
            this.quảnLýTàiKhoảnToolStripMenuItem.Text = "Quản lý tài khoản";
            this.quảnLýTàiKhoảnToolStripMenuItem.Click += new System.EventHandler(this.quảnLýTàiKhoảnToolStripMenuItem_Click);
            // 
            // quảnLýNhómNgườiDùngToolStripMenuItem
            // 
            this.quảnLýNhómNgườiDùngToolStripMenuItem.Image = global::GUI.Properties.Resources.user1;
            this.quảnLýNhómNgườiDùngToolStripMenuItem.Name = "quảnLýNhómNgườiDùngToolStripMenuItem";
            this.quảnLýNhómNgườiDùngToolStripMenuItem.Size = new System.Drawing.Size(280, 26);
            this.quảnLýNhómNgườiDùngToolStripMenuItem.Tag = "M7";
            this.quảnLýNhómNgườiDùngToolStripMenuItem.Text = "Quản lý nhóm người dùng";
            this.quảnLýNhómNgườiDùngToolStripMenuItem.Click += new System.EventHandler(this.quảnLýNhómNgườiDùngToolStripMenuItem_Click);
            // 
            // quảnLýMànHìnhToolStripMenuItem
            // 
            this.quảnLýMànHìnhToolStripMenuItem.Image = global::GUI.Properties.Resources.monitor;
            this.quảnLýMànHìnhToolStripMenuItem.Name = "quảnLýMànHìnhToolStripMenuItem";
            this.quảnLýMànHìnhToolStripMenuItem.Size = new System.Drawing.Size(280, 26);
            this.quảnLýMànHìnhToolStripMenuItem.Tag = "MMH";
            this.quảnLýMànHìnhToolStripMenuItem.Text = "Quản lý màn hình";
            this.quảnLýMànHìnhToolStripMenuItem.Click += new System.EventHandler(this.quảnLýMànHìnhToolStripMenuItem_Click);
            // 
            // thêmNgườiDùngVàoNhómToolStripMenuItem
            // 
            this.thêmNgườiDùngVàoNhómToolStripMenuItem.Image = global::GUI.Properties.Resources.add_user;
            this.thêmNgườiDùngVàoNhómToolStripMenuItem.Name = "thêmNgườiDùngVàoNhómToolStripMenuItem";
            this.thêmNgườiDùngVàoNhómToolStripMenuItem.Size = new System.Drawing.Size(280, 26);
            this.thêmNgườiDùngVàoNhómToolStripMenuItem.Tag = "M8";
            this.thêmNgườiDùngVàoNhómToolStripMenuItem.Text = "Thêm người dùng vào nhóm";
            this.thêmNgườiDùngVàoNhómToolStripMenuItem.Click += new System.EventHandler(this.thêmNgườiDùngVàoNhómToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(982, 953);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý phòng khám";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem chứcNăngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thựcHiệnDịchVụToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kêToaThuốcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xemThôngTinCáNhânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phânQuyềnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem khámBệnhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýBệnhNhânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýNhómNgườiDùngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýMànHìnhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmNgườiDùngVàoNhómToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
    }
}