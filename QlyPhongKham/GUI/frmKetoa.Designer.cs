
namespace GUI
{
    partial class frmKetoa
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKetoa));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbHeader = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTimKiem = new GUI.textBoxCustom();
            this.btnTimKiem = new GUI.CustomButton();
            this.dgvThuoc = new System.Windows.Forms.DataGridView();
            this.MAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvToaThuoc = new System.Windows.Forms.DataGridView();
            this.MATT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOBUOI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOVIEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menu = new CustomControls.RJControls.RJDropdownMenu(this.components);
            this.btnXoa = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNgay = new GUI.textBoxCustom();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenThuoc = new GUI.textBoxCustom();
            this.cboBuoi = new CustomControls.RJControls.RJComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSoVien = new GUI.textBoxCustom();
            this.btnLuu = new GUI.CustomButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuoc)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvToaThuoc)).BeginInit();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.81242F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.18758F));
            this.tableLayoutPanel1.Controls.Add(this.lbHeader, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1482, 953);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lbHeader
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.lbHeader, 2);
            this.lbHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbHeader.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeader.Location = new System.Drawing.Point(3, 0);
            this.lbHeader.Name = "lbHeader";
            this.lbHeader.Size = new System.Drawing.Size(1476, 70);
            this.lbHeader.TabIndex = 0;
            this.lbHeader.Text = "TOA THUỐC";
            this.lbHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtTimKiem, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnTimKiem, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.dgvThuoc, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 73);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(421, 877);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tìm Kiếm";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtTimKiem.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtTimKiem.BorderRadius = 8;
            this.txtTimKiem.BorderSize = 1;
            this.txtTimKiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTimKiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(129, 4);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimKiem.Multiline = false;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Padding = new System.Windows.Forms.Padding(7);
            this.txtTimKiem.PasswordChar = false;
            this.txtTimKiem.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTimKiem.PlaceholderText = "";
            this.txtTimKiem.Size = new System.Drawing.Size(242, 37);
            this.txtTimKiem.TabIndex = 11;
            this.txtTimKiem.TabStop = false;
            this.txtTimKiem.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTimKiem.Texts = "";
            this.txtTimKiem.UnderlinedStyle = false;
            this.txtTimKiem.Click += new System.EventHandler(this.txtTimKiem_Click);
            this.txtTimKiem.Leave += new System.EventHandler(this.txtTimKiem_Leave);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.White;
            this.btnTimKiem.BackgroundColor = System.Drawing.Color.White;
            this.btnTimKiem.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnTimKiem.BorderRadius = 0;
            this.btnTimKiem.BorderSize = 0;
            this.btnTimKiem.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnTimKiem.FlatAppearance.BorderSize = 0;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Image = global::GUI.Properties.Resources.search__1_;
            this.btnTimKiem.Location = new System.Drawing.Point(378, 3);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(40, 40);
            this.btnTimKiem.TabIndex = 2;
            this.btnTimKiem.TextColor = System.Drawing.Color.White;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // dgvThuoc
            // 
            this.dgvThuoc.AllowUserToAddRows = false;
            this.dgvThuoc.AllowUserToDeleteRows = false;
            this.dgvThuoc.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.dgvThuoc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvThuoc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvThuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThuoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAT,
            this.TENT});
            this.tableLayoutPanel2.SetColumnSpan(this.dgvThuoc, 3);
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvThuoc.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvThuoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvThuoc.Location = new System.Drawing.Point(3, 49);
            this.dgvThuoc.Name = "dgvThuoc";
            this.dgvThuoc.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvThuoc.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvThuoc.RowHeadersVisible = false;
            this.dgvThuoc.RowHeadersWidth = 51;
            this.dgvThuoc.RowTemplate.Height = 24;
            this.dgvThuoc.Size = new System.Drawing.Size(415, 805);
            this.dgvThuoc.TabIndex = 3;
            this.dgvThuoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThuoc_CellClick);
            // 
            // MAT
            // 
            this.MAT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.MAT.DataPropertyName = "MAT";
            this.MAT.HeaderText = "Mã thuốc";
            this.MAT.MinimumWidth = 6;
            this.MAT.Name = "MAT";
            this.MAT.ReadOnly = true;
            this.MAT.Width = 112;
            // 
            // TENT
            // 
            this.TENT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TENT.DataPropertyName = "TENT";
            this.TENT.HeaderText = "Tên thuốc";
            this.TENT.MinimumWidth = 6;
            this.TENT.Name = "TENT";
            this.TENT.ReadOnly = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.txtNgay, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.txtTenThuoc, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.cboBuoi, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.txtSoVien, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.btnLuu, 1, 5);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(430, 73);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 7;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1049, 877);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.groupBox1, 2);
            this.groupBox1.Controls.Add(this.dgvToaThuoc);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1043, 620);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Toa thuốc";
            // 
            // dgvToaThuoc
            // 
            this.dgvToaThuoc.AllowUserToAddRows = false;
            this.dgvToaThuoc.AllowUserToDeleteRows = false;
            this.dgvToaThuoc.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.dgvToaThuoc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvToaThuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvToaThuoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MATT,
            this.Column1,
            this.TENTT,
            this.SOBUOI,
            this.SOVIEN,
            this.TONG});
            this.dgvToaThuoc.ContextMenuStrip = this.menu;
            this.dgvToaThuoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvToaThuoc.Location = new System.Drawing.Point(3, 30);
            this.dgvToaThuoc.Name = "dgvToaThuoc";
            this.dgvToaThuoc.ReadOnly = true;
            this.dgvToaThuoc.RowHeadersVisible = false;
            this.dgvToaThuoc.RowHeadersWidth = 51;
            this.dgvToaThuoc.RowTemplate.Height = 24;
            this.dgvToaThuoc.Size = new System.Drawing.Size(1037, 587);
            this.dgvToaThuoc.TabIndex = 0;
            this.dgvToaThuoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvToaThuoc_CellClick);
            // 
            // MATT
            // 
            this.MATT.DataPropertyName = "MATT";
            this.MATT.HeaderText = "Mã toa thuốc";
            this.MATT.MinimumWidth = 6;
            this.MATT.Name = "MATT";
            this.MATT.ReadOnly = true;
            this.MATT.Visible = false;
            this.MATT.Width = 125;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "DONGIA";
            this.Column1.HeaderText = "Column1";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            this.Column1.Width = 125;
            // 
            // TENTT
            // 
            this.TENTT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TENTT.DataPropertyName = "TENT";
            this.TENTT.HeaderText = "Tên thuốc";
            this.TENTT.MinimumWidth = 6;
            this.TENTT.Name = "TENTT";
            this.TENTT.ReadOnly = true;
            // 
            // SOBUOI
            // 
            this.SOBUOI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.SOBUOI.DataPropertyName = "SB";
            this.SOBUOI.HeaderText = "Số buổi";
            this.SOBUOI.MinimumWidth = 6;
            this.SOBUOI.Name = "SOBUOI";
            this.SOBUOI.ReadOnly = true;
            this.SOBUOI.Width = 113;
            // 
            // SOVIEN
            // 
            this.SOVIEN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.SOVIEN.DataPropertyName = "SL";
            this.SOVIEN.HeaderText = "Số viên / lần";
            this.SOVIEN.MinimumWidth = 6;
            this.SOVIEN.Name = "SOVIEN";
            this.SOVIEN.ReadOnly = true;
            this.SOVIEN.Width = 120;
            // 
            // TONG
            // 
            this.TONG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.TONG.DataPropertyName = "TONG";
            this.TONG.HeaderText = "Tổng số viên";
            this.TONG.MinimumWidth = 6;
            this.TONG.Name = "TONG";
            this.TONG.ReadOnly = true;
            this.TONG.Width = 113;
            // 
            // menu
            // 
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.IsMainMenu = false;
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnXoa});
            this.menu.MenuItemHeight = 25;
            this.menu.MenuItemTextColor = System.Drawing.Color.Empty;
            this.menu.Name = "menu";
            this.menu.PrimaryColor = System.Drawing.Color.Empty;
            this.menu.Size = new System.Drawing.Size(118, 34);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.btnXoa.Image = global::GUI.Properties.Resources.delete__1_;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(117, 30);
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 626);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(518, 45);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sô ngày điều trị cần thiết";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNgay
            // 
            this.txtNgay.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtNgay.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtNgay.BorderRadius = 0;
            this.txtNgay.BorderSize = 1;
            this.txtNgay.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtNgay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgay.Location = new System.Drawing.Point(528, 630);
            this.txtNgay.Margin = new System.Windows.Forms.Padding(4);
            this.txtNgay.Multiline = false;
            this.txtNgay.Name = "txtNgay";
            this.txtNgay.Padding = new System.Windows.Forms.Padding(7);
            this.txtNgay.PasswordChar = false;
            this.txtNgay.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNgay.PlaceholderText = "";
            this.txtNgay.Size = new System.Drawing.Size(199, 37);
            this.txtNgay.TabIndex = 2;
            this.txtNgay.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNgay.Texts = "";
            this.txtNgay.UnderlinedStyle = false;
            this.txtNgay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNgay_KeyPress);
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.label3.Location = new System.Drawing.Point(3, 671);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(518, 45);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên thuốc";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.label4.Location = new System.Drawing.Point(3, 716);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(518, 40);
            this.label4.TabIndex = 5;
            this.label4.Text = "Số buổi dùng";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTenThuoc
            // 
            this.txtTenThuoc.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtTenThuoc.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtTenThuoc.BorderRadius = 0;
            this.txtTenThuoc.BorderSize = 1;
            this.txtTenThuoc.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtTenThuoc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenThuoc.Location = new System.Drawing.Point(528, 675);
            this.txtTenThuoc.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenThuoc.Multiline = false;
            this.txtTenThuoc.Name = "txtTenThuoc";
            this.txtTenThuoc.Padding = new System.Windows.Forms.Padding(7);
            this.txtTenThuoc.PasswordChar = false;
            this.txtTenThuoc.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTenThuoc.PlaceholderText = "";
            this.txtTenThuoc.Size = new System.Drawing.Size(350, 37);
            this.txtTenThuoc.TabIndex = 7;
            this.txtTenThuoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTenThuoc.Texts = "";
            this.txtTenThuoc.UnderlinedStyle = false;
            this.txtTenThuoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTenThuoc_KeyPress);
            // 
            // cboBuoi
            // 
            this.cboBuoi.BackColor = System.Drawing.Color.White;
            this.cboBuoi.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cboBuoi.BorderSize = 1;
            this.cboBuoi.Dock = System.Windows.Forms.DockStyle.Left;
            this.cboBuoi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBuoi.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.cboBuoi.ForeColor = System.Drawing.Color.Black;
            this.cboBuoi.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cboBuoi.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cboBuoi.ListBackColor = System.Drawing.Color.White;
            this.cboBuoi.ListTextColor = System.Drawing.Color.Black;
            this.cboBuoi.Location = new System.Drawing.Point(527, 719);
            this.cboBuoi.MinimumSize = new System.Drawing.Size(200, 30);
            this.cboBuoi.Name = "cboBuoi";
            this.cboBuoi.Padding = new System.Windows.Forms.Padding(1);
            this.cboBuoi.Size = new System.Drawing.Size(200, 34);
            this.cboBuoi.TabIndex = 8;
            this.cboBuoi.Texts = "";
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.label5.Location = new System.Drawing.Point(3, 756);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(518, 45);
            this.label5.TabIndex = 9;
            this.label5.Text = "Số viên / buổi";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSoVien
            // 
            this.txtSoVien.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtSoVien.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtSoVien.BorderRadius = 0;
            this.txtSoVien.BorderSize = 1;
            this.txtSoVien.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtSoVien.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtSoVien.Location = new System.Drawing.Point(528, 760);
            this.txtSoVien.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoVien.Multiline = false;
            this.txtSoVien.Name = "txtSoVien";
            this.txtSoVien.Padding = new System.Windows.Forms.Padding(7);
            this.txtSoVien.PasswordChar = false;
            this.txtSoVien.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSoVien.PlaceholderText = "";
            this.txtSoVien.Size = new System.Drawing.Size(199, 37);
            this.txtSoVien.TabIndex = 10;
            this.txtSoVien.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSoVien.Texts = "";
            this.txtSoVien.UnderlinedStyle = false;
            this.txtSoVien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoVien_KeyPress);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.Navy;
            this.btnLuu.BackgroundColor = System.Drawing.Color.Navy;
            this.btnLuu.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnLuu.BorderRadius = 0;
            this.btnLuu.BorderSize = 0;
            this.btnLuu.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnLuu.FlatAppearance.BorderSize = 0;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(527, 804);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(150, 50);
            this.btnLuu.TabIndex = 11;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextColor = System.Drawing.Color.White;
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            this.errorProvider2.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider2.Icon")));
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            this.errorProvider3.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider3.Icon")));
            // 
            // frmKetoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1482, 953);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmKetoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kê toa";
            this.Load += new System.EventHandler(this.frmKetoa_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuoc)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvToaThuoc)).EndInit();
            this.menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbHeader;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private textBoxCustom txtTimKiem;
        private CustomButton btnTimKiem;
        private System.Windows.Forms.DataGridView dgvThuoc;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvToaThuoc;
        private System.Windows.Forms.Label label2;
        private textBoxCustom txtNgay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private textBoxCustom txtTenThuoc;
        private CustomControls.RJControls.RJComboBox cboBuoi;
        private System.Windows.Forms.Label label5;
        private textBoxCustom txtSoVien;
        private CustomButton btnLuu;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENT;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.DataGridViewTextBoxColumn MATT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOBUOI;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOVIEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn TONG;
        private CustomControls.RJControls.RJDropdownMenu menu;
        private System.Windows.Forms.ToolStripMenuItem btnXoa;
    }
}