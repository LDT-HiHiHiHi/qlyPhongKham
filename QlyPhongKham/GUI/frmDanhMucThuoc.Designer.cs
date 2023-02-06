
namespace GUI
{
    partial class frmDanhMucThuoc
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDanhMucThuoc));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvThuoc = new System.Windows.Forms.DataGridView();
            this.MAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HSD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGCN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menu = new CustomControls.RJControls.RJDropdownMenu(this.components);
            this.btnXoa = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTen = new GUI.textBoxCustom();
            this.txtHSD = new GUI.textBoxCustom();
            this.txtSL = new GUI.textBoxCustom();
            this.txtDVT = new GUI.textBoxCustom();
            this.txtDG = new GUI.textBoxCustom();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnThem = new GUI.CustomButton();
            this.btnLuu = new GUI.CustomButton();
            this.lbNgay = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTimKiem = new GUI.textBoxCustom();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuoc)).BeginInit();
            this.menu.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.49054F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.50946F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvThuoc, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.txtTen, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtHSD, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtSL, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtDVT, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtDG, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.lbNgay, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtTimKiem, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(899, 687);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 2);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(893, 71);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH MỤC THUỐC";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvThuoc
            // 
            this.dgvThuoc.AllowUserToAddRows = false;
            this.dgvThuoc.AllowUserToDeleteRows = false;
            this.dgvThuoc.BackgroundColor = System.Drawing.Color.FloralWhite;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvThuoc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvThuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThuoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAT,
            this.TENT,
            this.HSD,
            this.SL,
            this.DVT,
            this.NGCN,
            this.DG});
            this.tableLayoutPanel1.SetColumnSpan(this.dgvThuoc, 2);
            this.dgvThuoc.ContextMenuStrip = this.menu;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvThuoc.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvThuoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvThuoc.Location = new System.Drawing.Point(3, 117);
            this.dgvThuoc.Name = "dgvThuoc";
            this.dgvThuoc.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvThuoc.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvThuoc.RowHeadersVisible = false;
            this.dgvThuoc.RowHeadersWidth = 51;
            this.dgvThuoc.RowTemplate.Height = 24;
            this.dgvThuoc.Size = new System.Drawing.Size(893, 221);
            this.dgvThuoc.TabIndex = 1;
            this.dgvThuoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThuoc_CellClick);
            // 
            // MAT
            // 
            this.MAT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MAT.DataPropertyName = "MAT";
            this.MAT.HeaderText = "Mã thuốc";
            this.MAT.MinimumWidth = 6;
            this.MAT.Name = "MAT";
            this.MAT.ReadOnly = true;
            this.MAT.Visible = false;
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
            // HSD
            // 
            this.HSD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HSD.DataPropertyName = "HSD";
            this.HSD.HeaderText = "Hạn sử dụng";
            this.HSD.MinimumWidth = 6;
            this.HSD.Name = "HSD";
            this.HSD.ReadOnly = true;
            // 
            // SL
            // 
            this.SL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SL.DataPropertyName = "SL";
            this.SL.HeaderText = "Số lượng";
            this.SL.MinimumWidth = 6;
            this.SL.Name = "SL";
            this.SL.ReadOnly = true;
            // 
            // DVT
            // 
            this.DVT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DVT.DataPropertyName = "DVT";
            this.DVT.HeaderText = "Đơn vị tính";
            this.DVT.MinimumWidth = 6;
            this.DVT.Name = "DVT";
            this.DVT.ReadOnly = true;
            // 
            // NGCN
            // 
            this.NGCN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NGCN.DataPropertyName = "NGCN";
            dataGridViewCellStyle2.Format = "dd/MM/yyyy";
            this.NGCN.DefaultCellStyle = dataGridViewCellStyle2;
            this.NGCN.HeaderText = "Ngày cập nhật";
            this.NGCN.MinimumWidth = 6;
            this.NGCN.Name = "NGCN";
            this.NGCN.ReadOnly = true;
            // 
            // DG
            // 
            this.DG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DG.DataPropertyName = "DG";
            dataGridViewCellStyle3.Format = "N0";
            this.DG.DefaultCellStyle = dataGridViewCellStyle3;
            this.DG.HeaderText = "Đơn giá";
            this.DG.MinimumWidth = 6;
            this.DG.Name = "DG";
            this.DG.ReadOnly = true;
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
            this.menu.Size = new System.Drawing.Size(171, 34);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.btnXoa.Image = global::GUI.Properties.Resources.x_button1;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(170, 30);
            this.btnXoa.Text = "Xóa thuốc";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 341);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(366, 48);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên thuốc";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 389);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(366, 48);
            this.label3.TabIndex = 3;
            this.label3.Text = "Hạn sử dụng";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 437);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(366, 48);
            this.label4.TabIndex = 4;
            this.label4.Text = "Số lượng";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 485);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(366, 48);
            this.label5.TabIndex = 5;
            this.label5.Text = "Đơn vị tính";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 533);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(366, 40);
            this.label6.TabIndex = 6;
            this.label6.Text = "Ngày cập nhật";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 573);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(366, 48);
            this.label7.TabIndex = 7;
            this.label7.Text = "Đơn giá";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTen
            // 
            this.txtTen.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtTen.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtTen.BorderRadius = 0;
            this.txtTen.BorderSize = 1;
            this.txtTen.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.Location = new System.Drawing.Point(376, 345);
            this.txtTen.Margin = new System.Windows.Forms.Padding(4);
            this.txtTen.Multiline = false;
            this.txtTen.Name = "txtTen";
            this.txtTen.Padding = new System.Windows.Forms.Padding(7);
            this.txtTen.PasswordChar = false;
            this.txtTen.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTen.PlaceholderText = "";
            this.txtTen.Size = new System.Drawing.Size(250, 40);
            this.txtTen.TabIndex = 8;
            this.txtTen.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTen.Texts = "";
            this.txtTen.UnderlinedStyle = true;
            this.txtTen._TextChanged += new System.EventHandler(this.txtTen__TextChanged);
            // 
            // txtHSD
            // 
            this.txtHSD.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtHSD.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtHSD.BorderRadius = 0;
            this.txtHSD.BorderSize = 1;
            this.txtHSD.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtHSD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHSD.Location = new System.Drawing.Point(376, 393);
            this.txtHSD.Margin = new System.Windows.Forms.Padding(4);
            this.txtHSD.Multiline = false;
            this.txtHSD.Name = "txtHSD";
            this.txtHSD.Padding = new System.Windows.Forms.Padding(7);
            this.txtHSD.PasswordChar = false;
            this.txtHSD.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtHSD.PlaceholderText = "";
            this.txtHSD.Size = new System.Drawing.Size(250, 40);
            this.txtHSD.TabIndex = 9;
            this.txtHSD.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtHSD.Texts = "";
            this.txtHSD.UnderlinedStyle = true;
            this.txtHSD._TextChanged += new System.EventHandler(this.txtHSD__TextChanged);
            // 
            // txtSL
            // 
            this.txtSL.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtSL.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtSL.BorderRadius = 0;
            this.txtSL.BorderSize = 1;
            this.txtSL.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtSL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSL.Location = new System.Drawing.Point(376, 441);
            this.txtSL.Margin = new System.Windows.Forms.Padding(4);
            this.txtSL.Multiline = false;
            this.txtSL.Name = "txtSL";
            this.txtSL.Padding = new System.Windows.Forms.Padding(7);
            this.txtSL.PasswordChar = false;
            this.txtSL.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSL.PlaceholderText = "";
            this.txtSL.Size = new System.Drawing.Size(250, 40);
            this.txtSL.TabIndex = 10;
            this.txtSL.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSL.Texts = "";
            this.txtSL.UnderlinedStyle = true;
            this.txtSL._TextChanged += new System.EventHandler(this.txtSL__TextChanged);
            this.txtSL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSL_KeyPress);
            // 
            // txtDVT
            // 
            this.txtDVT.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtDVT.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtDVT.BorderRadius = 0;
            this.txtDVT.BorderSize = 1;
            this.txtDVT.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtDVT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDVT.Location = new System.Drawing.Point(376, 489);
            this.txtDVT.Margin = new System.Windows.Forms.Padding(4);
            this.txtDVT.Multiline = false;
            this.txtDVT.Name = "txtDVT";
            this.txtDVT.Padding = new System.Windows.Forms.Padding(7);
            this.txtDVT.PasswordChar = false;
            this.txtDVT.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDVT.PlaceholderText = "";
            this.txtDVT.Size = new System.Drawing.Size(250, 40);
            this.txtDVT.TabIndex = 11;
            this.txtDVT.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDVT.Texts = "";
            this.txtDVT.UnderlinedStyle = true;
            this.txtDVT._TextChanged += new System.EventHandler(this.txtDVT__TextChanged);
            // 
            // txtDG
            // 
            this.txtDG.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtDG.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtDG.BorderRadius = 0;
            this.txtDG.BorderSize = 1;
            this.txtDG.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtDG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDG.Location = new System.Drawing.Point(376, 577);
            this.txtDG.Margin = new System.Windows.Forms.Padding(4);
            this.txtDG.Multiline = false;
            this.txtDG.Name = "txtDG";
            this.txtDG.Padding = new System.Windows.Forms.Padding(7);
            this.txtDG.PasswordChar = false;
            this.txtDG.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDG.PlaceholderText = "";
            this.txtDG.Size = new System.Drawing.Size(250, 40);
            this.txtDG.TabIndex = 13;
            this.txtDG.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDG.Texts = "";
            this.txtDG.UnderlinedStyle = true;
            this.txtDG._TextChanged += new System.EventHandler(this.txtDG__TextChanged);
            this.txtDG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDG_KeyPress);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btnThem, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnLuu, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(375, 624);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(521, 60);
            this.tableLayoutPanel2.TabIndex = 14;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnThem.BackgroundColor = System.Drawing.Color.MediumSeaGreen;
            this.btnThem.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnThem.BorderRadius = 5;
            this.btnThem.BorderSize = 0;
            this.btnThem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(82, 3);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(175, 54);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextColor = System.Drawing.Color.White;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnLuu.BackgroundColor = System.Drawing.Color.MidnightBlue;
            this.btnLuu.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnLuu.BorderRadius = 5;
            this.btnLuu.BorderSize = 0;
            this.btnLuu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLuu.FlatAppearance.BorderSize = 0;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(263, 3);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(175, 54);
            this.btnLuu.TabIndex = 1;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextColor = System.Drawing.Color.White;
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // lbNgay
            // 
            this.lbNgay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbNgay.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbNgay.Location = new System.Drawing.Point(375, 533);
            this.lbNgay.Name = "lbNgay";
            this.lbNgay.Size = new System.Drawing.Size(521, 40);
            this.lbNgay.TabIndex = 15;
            this.lbNgay.Text = "label8";
            this.lbNgay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(366, 43);
            this.label8.TabIndex = 16;
            this.label8.Text = "Tìm kiếm";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtTimKiem.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtTimKiem.BorderRadius = 5;
            this.txtTimKiem.BorderSize = 1;
            this.txtTimKiem.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(376, 75);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimKiem.Multiline = false;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Padding = new System.Windows.Forms.Padding(7);
            this.txtTimKiem.PasswordChar = false;
            this.txtTimKiem.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTimKiem.PlaceholderText = "";
            this.txtTimKiem.Size = new System.Drawing.Size(470, 35);
            this.txtTimKiem.TabIndex = 17;
            this.txtTimKiem.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTimKiem.Texts = "";
            this.txtTimKiem.UnderlinedStyle = false;
            this.txtTimKiem._TextChanged += new System.EventHandler(this.textBoxCustom1__TextChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // frmDanhMucThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(899, 687);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmDanhMucThuoc";
            this.Text = "Danh mục thuốc";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.frmDanhMucThuoc_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDanhMucThuoc_FormClosing);
            this.Load += new System.EventHandler(this.frmDanhMucThuoc_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuoc)).EndInit();
            this.menu.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvThuoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private textBoxCustom txtTen;
        private textBoxCustom txtHSD;
        private textBoxCustom txtSL;
        private textBoxCustom txtDVT;
        private textBoxCustom txtDG;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private CustomButton btnThem;
        private CustomButton btnLuu;
        private System.Windows.Forms.Label lbNgay;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENT;
        private System.Windows.Forms.DataGridViewTextBoxColumn HSD;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL;
        private System.Windows.Forms.DataGridViewTextBoxColumn DVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGCN;
        private System.Windows.Forms.DataGridViewTextBoxColumn DG;
        private CustomControls.RJControls.RJDropdownMenu menu;
        private System.Windows.Forms.ToolStripMenuItem btnXoa;
        private System.Windows.Forms.Label label8;
        private textBoxCustom txtTimKiem;
    }
}