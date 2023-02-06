
namespace GUI
{
    partial class frmThemNguoiDung
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.drvTK = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdGr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pw = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbNhoms = new CustomControls.RJControls.RJComboBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddOne = new GUI.CustomButton();
            this.btnAddAll = new GUI.CustomButton();
            this.btnRefesh = new GUI.CustomButton();
            this.btnDelOne = new GUI.CustomButton();
            this.btnDelAll = new GUI.CustomButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.drvNhom = new System.Windows.Forms.DataGridView();
            this.No_grA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDTK_grA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username_grA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten_grA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_grA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pw_nnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menu = new CustomControls.RJControls.RJDropdownMenu(this.components);
            this.btnThem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drvTK)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drvNhom)).BeginInit();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.00001F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.cbNhoms, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 2, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(982, 753);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 3);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(976, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thêm người dùng vào nhóm";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.drvTK);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 89);
            this.groupBox1.Name = "groupBox1";
            this.tableLayoutPanel1.SetRowSpan(this.groupBox1, 2);
            this.groupBox1.Size = new System.Drawing.Size(441, 661);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Người dùng";
            // 
            // drvTK
            // 
            this.drvTK.AllowUserToAddRows = false;
            this.drvTK.AllowUserToDeleteRows = false;
            this.drvTK.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.drvTK.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.drvTK.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.drvTK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.drvTK.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.ID,
            this.Username,
            this.Ten,
            this.IdGr,
            this.pw});
            this.drvTK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drvTK.Location = new System.Drawing.Point(3, 23);
            this.drvTK.Name = "drvTK";
            this.drvTK.ReadOnly = true;
            this.drvTK.RowHeadersVisible = false;
            this.drvTK.RowHeadersWidth = 51;
            this.drvTK.RowTemplate.Height = 24;
            this.drvTK.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.drvTK.Size = new System.Drawing.Size(435, 635);
            this.drvTK.TabIndex = 1;
            this.drvTK.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.drvTK_CellClick);
            this.drvTK.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.drvTK_RowPostPaint);
            // 
            // No
            // 
            this.No.HeaderText = "No";
            this.No.MinimumWidth = 6;
            this.No.Name = "No";
            this.No.ReadOnly = true;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "IdTK";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Username
            // 
            this.Username.DataPropertyName = "Username";
            this.Username.HeaderText = "Username";
            this.Username.MinimumWidth = 6;
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            // 
            // Ten
            // 
            this.Ten.DataPropertyName = "Ten";
            this.Ten.HeaderText = "Ten";
            this.Ten.MinimumWidth = 6;
            this.Ten.Name = "Ten";
            this.Ten.ReadOnly = true;
            this.Ten.Visible = false;
            // 
            // IdGr
            // 
            this.IdGr.DataPropertyName = "IdGr";
            this.IdGr.HeaderText = "IdGr";
            this.IdGr.MinimumWidth = 6;
            this.IdGr.Name = "IdGr";
            this.IdGr.ReadOnly = true;
            this.IdGr.Visible = false;
            // 
            // pw
            // 
            this.pw.DataPropertyName = "Pw";
            this.pw.HeaderText = "Pw";
            this.pw.MinimumWidth = 6;
            this.pw.Name = "pw";
            this.pw.ReadOnly = true;
            this.pw.Visible = false;
            // 
            // cbNhoms
            // 
            this.cbNhoms.BackColor = System.Drawing.Color.White;
            this.cbNhoms.BorderColor = System.Drawing.Color.Navy;
            this.cbNhoms.BorderSize = 1;
            this.cbNhoms.Dock = System.Windows.Forms.DockStyle.Left;
            this.cbNhoms.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNhoms.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbNhoms.ForeColor = System.Drawing.Color.Black;
            this.cbNhoms.IconColor = System.Drawing.Color.Navy;
            this.cbNhoms.ListBackColor = System.Drawing.Color.White;
            this.cbNhoms.ListTextColor = System.Drawing.Color.Black;
            this.cbNhoms.Location = new System.Drawing.Point(536, 43);
            this.cbNhoms.MinimumSize = new System.Drawing.Size(150, 40);
            this.cbNhoms.Name = "cbNhoms";
            this.cbNhoms.Padding = new System.Windows.Forms.Padding(1);
            this.cbNhoms.Size = new System.Drawing.Size(394, 40);
            this.cbNhoms.TabIndex = 1;
            this.cbNhoms.Texts = "";
            this.cbNhoms.OnSelectedIndexChanged += new System.EventHandler(this.cbNhoms_OnSelectedIndexChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(450, 89);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel1.SetRowSpan(this.tableLayoutPanel2, 2);
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(80, 661);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.btnAddOne, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnAddAll, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.btnRefesh, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.btnDelOne, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.btnDelAll, 0, 4);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 160);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 5;
            this.tableLayoutPanel2.SetRowSpan(this.tableLayoutPanel3, 3);
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(74, 340);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // btnAddOne
            // 
            this.btnAddOne.BackColor = System.Drawing.Color.Navy;
            this.btnAddOne.BackgroundColor = System.Drawing.Color.Navy;
            this.btnAddOne.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAddOne.BorderRadius = 5;
            this.btnAddOne.BorderSize = 0;
            this.btnAddOne.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddOne.FlatAppearance.BorderSize = 0;
            this.btnAddOne.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnAddOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddOne.ForeColor = System.Drawing.Color.White;
            this.btnAddOne.Image = global::GUI.Properties.Resources.arrow;
            this.btnAddOne.Location = new System.Drawing.Point(5, 5);
            this.btnAddOne.Margin = new System.Windows.Forms.Padding(5);
            this.btnAddOne.Name = "btnAddOne";
            this.btnAddOne.Size = new System.Drawing.Size(64, 58);
            this.btnAddOne.TabIndex = 0;
            this.btnAddOne.TextColor = System.Drawing.Color.White;
            this.btnAddOne.UseVisualStyleBackColor = false;
            this.btnAddOne.Click += new System.EventHandler(this.btnAddOne_Click);
            // 
            // btnAddAll
            // 
            this.btnAddAll.BackColor = System.Drawing.Color.Navy;
            this.btnAddAll.BackgroundColor = System.Drawing.Color.Navy;
            this.btnAddAll.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAddAll.BorderRadius = 5;
            this.btnAddAll.BorderSize = 0;
            this.btnAddAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddAll.FlatAppearance.BorderSize = 0;
            this.btnAddAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnAddAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAll.ForeColor = System.Drawing.Color.White;
            this.btnAddAll.Image = global::GUI.Properties.Resources.arrow__1_;
            this.btnAddAll.Location = new System.Drawing.Point(5, 73);
            this.btnAddAll.Margin = new System.Windows.Forms.Padding(5);
            this.btnAddAll.Name = "btnAddAll";
            this.btnAddAll.Size = new System.Drawing.Size(64, 58);
            this.btnAddAll.TabIndex = 1;
            this.btnAddAll.TextColor = System.Drawing.Color.White;
            this.btnAddAll.UseVisualStyleBackColor = false;
            this.btnAddAll.Click += new System.EventHandler(this.btnAddAll_Click);
            // 
            // btnRefesh
            // 
            this.btnRefesh.BackColor = System.Drawing.Color.Navy;
            this.btnRefesh.BackgroundColor = System.Drawing.Color.Navy;
            this.btnRefesh.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnRefesh.BorderRadius = 5;
            this.btnRefesh.BorderSize = 0;
            this.btnRefesh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRefesh.FlatAppearance.BorderSize = 0;
            this.btnRefesh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnRefesh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefesh.ForeColor = System.Drawing.Color.White;
            this.btnRefesh.Image = global::GUI.Properties.Resources.arrow__4_;
            this.btnRefesh.Location = new System.Drawing.Point(5, 141);
            this.btnRefesh.Margin = new System.Windows.Forms.Padding(5);
            this.btnRefesh.Name = "btnRefesh";
            this.btnRefesh.Size = new System.Drawing.Size(64, 58);
            this.btnRefesh.TabIndex = 2;
            this.btnRefesh.TextColor = System.Drawing.Color.White;
            this.btnRefesh.UseVisualStyleBackColor = false;
            this.btnRefesh.Click += new System.EventHandler(this.btnRefesh_Click);
            // 
            // btnDelOne
            // 
            this.btnDelOne.BackColor = System.Drawing.Color.Navy;
            this.btnDelOne.BackgroundColor = System.Drawing.Color.Navy;
            this.btnDelOne.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnDelOne.BorderRadius = 5;
            this.btnDelOne.BorderSize = 0;
            this.btnDelOne.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDelOne.FlatAppearance.BorderSize = 0;
            this.btnDelOne.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnDelOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelOne.ForeColor = System.Drawing.Color.White;
            this.btnDelOne.Image = global::GUI.Properties.Resources.arrow__2_;
            this.btnDelOne.Location = new System.Drawing.Point(5, 209);
            this.btnDelOne.Margin = new System.Windows.Forms.Padding(5);
            this.btnDelOne.Name = "btnDelOne";
            this.btnDelOne.Size = new System.Drawing.Size(64, 58);
            this.btnDelOne.TabIndex = 3;
            this.btnDelOne.TextColor = System.Drawing.Color.White;
            this.btnDelOne.UseVisualStyleBackColor = false;
            this.btnDelOne.Click += new System.EventHandler(this.btnDelOne_Click);
            // 
            // btnDelAll
            // 
            this.btnDelAll.BackColor = System.Drawing.Color.Navy;
            this.btnDelAll.BackgroundColor = System.Drawing.Color.Navy;
            this.btnDelAll.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnDelAll.BorderRadius = 5;
            this.btnDelAll.BorderSize = 0;
            this.btnDelAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDelAll.FlatAppearance.BorderSize = 0;
            this.btnDelAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnDelAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelAll.ForeColor = System.Drawing.Color.White;
            this.btnDelAll.Image = global::GUI.Properties.Resources.arrow__3_;
            this.btnDelAll.Location = new System.Drawing.Point(5, 277);
            this.btnDelAll.Margin = new System.Windows.Forms.Padding(5);
            this.btnDelAll.Name = "btnDelAll";
            this.btnDelAll.Size = new System.Drawing.Size(64, 58);
            this.btnDelAll.TabIndex = 4;
            this.btnDelAll.TextColor = System.Drawing.Color.White;
            this.btnDelAll.UseVisualStyleBackColor = false;
            this.btnDelAll.Click += new System.EventHandler(this.btnDelAll_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.drvNhom);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(536, 89);
            this.groupBox2.Name = "groupBox2";
            this.tableLayoutPanel1.SetRowSpan(this.groupBox2, 2);
            this.groupBox2.Size = new System.Drawing.Size(443, 661);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nhóm người dùng";
            // 
            // drvNhom
            // 
            this.drvNhom.AllowUserToAddRows = false;
            this.drvNhom.AllowUserToDeleteRows = false;
            this.drvNhom.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.drvNhom.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.drvNhom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.drvNhom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.drvNhom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No_grA,
            this.IDTK_grA,
            this.Username_grA,
            this.Ten_grA,
            this.Id_grA,
            this.Pw_nnd});
            this.drvNhom.ContextMenuStrip = this.menu;
            this.drvNhom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drvNhom.Location = new System.Drawing.Point(3, 23);
            this.drvNhom.Name = "drvNhom";
            this.drvNhom.ReadOnly = true;
            this.drvNhom.RowHeadersVisible = false;
            this.drvNhom.RowHeadersWidth = 51;
            this.drvNhom.RowTemplate.Height = 24;
            this.drvNhom.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.drvNhom.Size = new System.Drawing.Size(437, 635);
            this.drvNhom.TabIndex = 2;
            this.drvNhom.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.drvNhom_CellClick);
            this.drvNhom.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.drvNhom_RowPostPaint);
            // 
            // No_grA
            // 
            this.No_grA.HeaderText = "No";
            this.No_grA.MinimumWidth = 6;
            this.No_grA.Name = "No_grA";
            this.No_grA.ReadOnly = true;
            // 
            // IDTK_grA
            // 
            this.IDTK_grA.DataPropertyName = "IdTK";
            this.IDTK_grA.HeaderText = "ID";
            this.IDTK_grA.MinimumWidth = 6;
            this.IDTK_grA.Name = "IDTK_grA";
            this.IDTK_grA.ReadOnly = true;
            // 
            // Username_grA
            // 
            this.Username_grA.DataPropertyName = "Username";
            this.Username_grA.HeaderText = "Username";
            this.Username_grA.MinimumWidth = 6;
            this.Username_grA.Name = "Username_grA";
            this.Username_grA.ReadOnly = true;
            // 
            // Ten_grA
            // 
            this.Ten_grA.DataPropertyName = "Ten";
            this.Ten_grA.HeaderText = "Ten";
            this.Ten_grA.MinimumWidth = 6;
            this.Ten_grA.Name = "Ten_grA";
            this.Ten_grA.ReadOnly = true;
            this.Ten_grA.Visible = false;
            // 
            // Id_grA
            // 
            this.Id_grA.DataPropertyName = "IdGr";
            this.Id_grA.HeaderText = "IDGR";
            this.Id_grA.MinimumWidth = 6;
            this.Id_grA.Name = "Id_grA";
            this.Id_grA.ReadOnly = true;
            this.Id_grA.Visible = false;
            // 
            // Pw_nnd
            // 
            this.Pw_nnd.DataPropertyName = "Pw";
            this.Pw_nnd.HeaderText = "Pw";
            this.Pw_nnd.MinimumWidth = 6;
            this.Pw_nnd.Name = "Pw_nnd";
            this.Pw_nnd.ReadOnly = true;
            this.Pw_nnd.Visible = false;
            // 
            // menu
            // 
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.IsMainMenu = false;
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThem});
            this.menu.MenuItemHeight = 25;
            this.menu.MenuItemTextColor = System.Drawing.Color.Empty;
            this.menu.Name = "rjDropdownMenu1";
            this.menu.PrimaryColor = System.Drawing.Color.Empty;
            this.menu.Size = new System.Drawing.Size(211, 62);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(210, 30);
            this.btnThem.Text = "Thêm bác sĩ";
            this.btnThem.Click += new System.EventHandler(this.thêmBấcSĩToolStripMenuItem_Click);
            // 
            // frmThemNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(982, 753);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmThemNguoiDung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm người dùng vào nhóm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.frmThemNguoiDung_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmThemNguoiDung_FormClosing);
            this.Load += new System.EventHandler(this.frmThemNguoiDung_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.drvTK)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.drvNhom)).EndInit();
            this.menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private CustomControls.RJControls.RJComboBox cbNhoms;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView drvTK;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdGr;
        private System.Windows.Forms.DataGridViewTextBoxColumn pw;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView drvNhom;
        private System.Windows.Forms.DataGridViewTextBoxColumn No_grA;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDTK_grA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username_grA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten_grA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_grA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pw_nnd;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private CustomButton btnAddOne;
        private CustomButton btnAddAll;
        private CustomButton btnRefesh;
        private CustomButton btnDelOne;
        private CustomButton btnDelAll;
        private CustomControls.RJControls.RJDropdownMenu menu;
        private System.Windows.Forms.ToolStripMenuItem btnThem;
    }
}