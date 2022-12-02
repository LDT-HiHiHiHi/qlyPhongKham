
namespace GUI
{
    partial class frmKhamBenh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKhamBenh));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvBenhNhan = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LSKB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MABN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.lbTenBn = new GUI.textBoxCustom();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.cboDichVu = new CustomControls.RJControls.RJComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMoTa = new GUI.textBoxCustom();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.btnLuu = new GUI.CustomButton();
            this.btnToaThuoc = new GUI.CustomButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txtChanDoan = new GUI.textBoxCustom();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvCTDV = new System.Windows.Forms.DataGridView();
            this.TENDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HINHANH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MACD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MOTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KETQUA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DONGIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menu = new CustomControls.RJControls.RJDropdownMenu(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnThem = new GUI.CustomButton();
            this.btnXoa = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBenhNhan)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTDV)).BeginInit();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.60468F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.39532F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvBenhNhan, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1482, 953);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 2);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1476, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Khám bệnh";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvBenhNhan
            // 
            this.dgvBenhNhan.AllowUserToAddRows = false;
            this.dgvBenhNhan.AllowUserToDeleteRows = false;
            this.dgvBenhNhan.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.dgvBenhNhan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBenhNhan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBenhNhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBenhNhan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.LSKB,
            this.MABN,
            this.TENBN});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBenhNhan.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBenhNhan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBenhNhan.Location = new System.Drawing.Point(3, 97);
            this.dgvBenhNhan.Margin = new System.Windows.Forms.Padding(3, 37, 3, 3);
            this.dgvBenhNhan.Name = "dgvBenhNhan";
            this.dgvBenhNhan.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBenhNhan.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBenhNhan.RowHeadersVisible = false;
            this.dgvBenhNhan.RowHeadersWidth = 51;
            this.dgvBenhNhan.RowTemplate.Height = 24;
            this.dgvBenhNhan.Size = new System.Drawing.Size(314, 853);
            this.dgvBenhNhan.TabIndex = 1;
            this.dgvBenhNhan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBenhNhan_CellClick);
            // 
            // STT
            // 
            this.STT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.STT.DataPropertyName = "STT";
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Width = 74;
            // 
            // LSKB
            // 
            this.LSKB.DataPropertyName = "LSKB";
            this.LSKB.HeaderText = "Column1";
            this.LSKB.MinimumWidth = 6;
            this.LSKB.Name = "LSKB";
            this.LSKB.ReadOnly = true;
            this.LSKB.Visible = false;
            this.LSKB.Width = 125;
            // 
            // MABN
            // 
            this.MABN.DataPropertyName = "MABN";
            this.MABN.HeaderText = "Column2";
            this.MABN.MinimumWidth = 6;
            this.MABN.Name = "MABN";
            this.MABN.ReadOnly = true;
            this.MABN.Visible = false;
            this.MABN.Width = 125;
            // 
            // TENBN
            // 
            this.TENBN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TENBN.DataPropertyName = "TENBN";
            this.TENBN.HeaderText = "Tên bệnh nhân";
            this.TENBN.MinimumWidth = 6;
            this.TENBN.Name = "TENBN";
            this.TENBN.ReadOnly = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.3564F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.6436F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(323, 63);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.40361F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.59639F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1156, 887);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel2.SetColumnSpan(this.tableLayoutPanel3, 2);
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.56522F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.43478F));
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.lbTenBn, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.txtMoTa, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.txtChanDoan, 1, 3);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 592);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 6;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1150, 292);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(472, 46);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên bệnh nhân :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbTenBn
            // 
            this.lbTenBn.BackColor = System.Drawing.Color.White;
            this.lbTenBn.BorderColor = System.Drawing.Color.White;
            this.lbTenBn.BorderFocusColor = System.Drawing.Color.HotPink;
            this.lbTenBn.BorderRadius = 0;
            this.lbTenBn.BorderSize = 1;
            this.lbTenBn.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbTenBn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenBn.Location = new System.Drawing.Point(482, 4);
            this.lbTenBn.Margin = new System.Windows.Forms.Padding(4);
            this.lbTenBn.Multiline = false;
            this.lbTenBn.Name = "lbTenBn";
            this.lbTenBn.Padding = new System.Windows.Forms.Padding(7);
            this.lbTenBn.PasswordChar = false;
            this.lbTenBn.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.lbTenBn.PlaceholderText = "";
            this.lbTenBn.Size = new System.Drawing.Size(380, 38);
            this.lbTenBn.TabIndex = 1;
            this.lbTenBn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.lbTenBn.Texts = "Lê Văn A";
            this.lbTenBn.UnderlinedStyle = true;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(472, 51);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên dịch vụ :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.cboDichVu, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnThem, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(481, 49);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.Size = new System.Drawing.Size(666, 45);
            this.tableLayoutPanel4.TabIndex = 5;
            // 
            // cboDichVu
            // 
            this.cboDichVu.BackColor = System.Drawing.Color.White;
            this.cboDichVu.BorderColor = System.Drawing.Color.LightGray;
            this.cboDichVu.BorderSize = 1;
            this.cboDichVu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboDichVu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDichVu.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDichVu.ForeColor = System.Drawing.Color.Black;
            this.cboDichVu.IconColor = System.Drawing.Color.Red;
            this.cboDichVu.Items.AddRange(new object[] {
            "1",
            "1",
            "1",
            "3",
            "4",
            "5",
            "2"});
            this.cboDichVu.ListBackColor = System.Drawing.Color.White;
            this.cboDichVu.ListTextColor = System.Drawing.Color.Black;
            this.cboDichVu.Location = new System.Drawing.Point(3, 3);
            this.cboDichVu.MinimumSize = new System.Drawing.Size(200, 30);
            this.cboDichVu.Name = "cboDichVu";
            this.cboDichVu.Padding = new System.Windows.Forms.Padding(1);
            this.cboDichVu.Size = new System.Drawing.Size(450, 41);
            this.cboDichVu.TabIndex = 0;
            this.cboDichVu.Texts = "";
            this.cboDichVu.OnSelectedIndexChanged += new System.EventHandler(this.cboDichVu_OnSelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(472, 50);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mô tả thực hiên dịch vụ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtMoTa
            // 
            this.txtMoTa.BackColor = System.Drawing.Color.White;
            this.txtMoTa.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtMoTa.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtMoTa.BorderRadius = 0;
            this.txtMoTa.BorderSize = 1;
            this.txtMoTa.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtMoTa.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMoTa.Location = new System.Drawing.Point(482, 101);
            this.txtMoTa.Margin = new System.Windows.Forms.Padding(4);
            this.txtMoTa.Multiline = false;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Padding = new System.Windows.Forms.Padding(7);
            this.txtMoTa.PasswordChar = false;
            this.txtMoTa.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtMoTa.PlaceholderText = "";
            this.txtMoTa.Size = new System.Drawing.Size(380, 42);
            this.txtMoTa.TabIndex = 7;
            this.txtMoTa.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMoTa.Texts = "";
            this.txtMoTa.UnderlinedStyle = true;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.Controls.Add(this.btnLuu, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.btnToaThuoc, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(481, 200);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(666, 60);
            this.tableLayoutPanel5.TabIndex = 8;
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.Navy;
            this.btnLuu.BackgroundColor = System.Drawing.Color.Navy;
            this.btnLuu.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnLuu.BorderRadius = 8;
            this.btnLuu.BorderSize = 0;
            this.btnLuu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLuu.FlatAppearance.BorderSize = 0;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(483, 3);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(180, 54);
            this.btnLuu.TabIndex = 0;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextColor = System.Drawing.Color.White;
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnToaThuoc
            // 
            this.btnToaThuoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnToaThuoc.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnToaThuoc.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnToaThuoc.BorderRadius = 8;
            this.btnToaThuoc.BorderSize = 0;
            this.btnToaThuoc.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnToaThuoc.FlatAppearance.BorderSize = 0;
            this.btnToaThuoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToaThuoc.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToaThuoc.ForeColor = System.Drawing.Color.White;
            this.btnToaThuoc.Location = new System.Drawing.Point(297, 3);
            this.btnToaThuoc.Name = "btnToaThuoc";
            this.btnToaThuoc.Size = new System.Drawing.Size(180, 54);
            this.btnToaThuoc.TabIndex = 1;
            this.btnToaThuoc.Text = "Kê toa";
            this.btnToaThuoc.TextColor = System.Drawing.Color.White;
            this.btnToaThuoc.UseVisualStyleBackColor = false;
            this.btnToaThuoc.Click += new System.EventHandler(this.btnToaThuoc_Click);
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(3, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(472, 50);
            this.label5.TabIndex = 9;
            this.label5.Text = "Chẩn đoán";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtChanDoan
            // 
            this.txtChanDoan.BackColor = System.Drawing.Color.White;
            this.txtChanDoan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtChanDoan.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtChanDoan.BorderRadius = 0;
            this.txtChanDoan.BorderSize = 1;
            this.txtChanDoan.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtChanDoan.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChanDoan.Location = new System.Drawing.Point(482, 151);
            this.txtChanDoan.Margin = new System.Windows.Forms.Padding(4);
            this.txtChanDoan.Multiline = false;
            this.txtChanDoan.Name = "txtChanDoan";
            this.txtChanDoan.Padding = new System.Windows.Forms.Padding(7);
            this.txtChanDoan.PasswordChar = false;
            this.txtChanDoan.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtChanDoan.PlaceholderText = "";
            this.txtChanDoan.Size = new System.Drawing.Size(380, 42);
            this.txtChanDoan.TabIndex = 10;
            this.txtChanDoan.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtChanDoan.Texts = "";
            this.txtChanDoan.UnderlinedStyle = true;
            this.txtChanDoan._TextChanged += new System.EventHandler(this.txtChanDoan__TextChanged);
            // 
            // groupBox1
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.groupBox1, 2);
            this.groupBox1.Controls.Add(this.dgvCTDV);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1150, 583);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dịch vụ";
            // 
            // dgvCTDV
            // 
            this.dgvCTDV.AllowUserToAddRows = false;
            this.dgvCTDV.AllowUserToDeleteRows = false;
            this.dgvCTDV.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.dgvCTDV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCTDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTDV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TENDV,
            this.HINHANH,
            this.MACD,
            this.MOTA,
            this.KETQUA,
            this.DONGIA});
            this.dgvCTDV.ContextMenuStrip = this.menu;
            this.dgvCTDV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCTDV.Location = new System.Drawing.Point(3, 30);
            this.dgvCTDV.Name = "dgvCTDV";
            this.dgvCTDV.ReadOnly = true;
            this.dgvCTDV.RowHeadersVisible = false;
            this.dgvCTDV.RowHeadersWidth = 51;
            this.dgvCTDV.RowTemplate.Height = 24;
            this.dgvCTDV.Size = new System.Drawing.Size(1144, 550);
            this.dgvCTDV.TabIndex = 0;
            this.dgvCTDV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCTDV_CellClick);
            // 
            // TENDV
            // 
            this.TENDV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.TENDV.DataPropertyName = "TENDV";
            this.TENDV.HeaderText = "Tên dịch vụ";
            this.TENDV.MinimumWidth = 6;
            this.TENDV.Name = "TENDV";
            this.TENDV.ReadOnly = true;
            this.TENDV.Width = 155;
            // 
            // HINHANH
            // 
            this.HINHANH.DataPropertyName = "HINHANH";
            this.HINHANH.HeaderText = "Column1";
            this.HINHANH.MinimumWidth = 6;
            this.HINHANH.Name = "HINHANH";
            this.HINHANH.ReadOnly = true;
            this.HINHANH.Visible = false;
            this.HINHANH.Width = 125;
            // 
            // MACD
            // 
            this.MACD.DataPropertyName = "MACD";
            this.MACD.HeaderText = "MACD";
            this.MACD.MinimumWidth = 6;
            this.MACD.Name = "MACD";
            this.MACD.ReadOnly = true;
            this.MACD.Visible = false;
            this.MACD.Width = 125;
            // 
            // MOTA
            // 
            this.MOTA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MOTA.DataPropertyName = "MOTA";
            this.MOTA.HeaderText = "Mô tả";
            this.MOTA.MinimumWidth = 6;
            this.MOTA.Name = "MOTA";
            this.MOTA.ReadOnly = true;
            // 
            // KETQUA
            // 
            this.KETQUA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.KETQUA.DataPropertyName = "KETQUA";
            this.KETQUA.HeaderText = "Kết quả";
            this.KETQUA.MinimumWidth = 6;
            this.KETQUA.Name = "KETQUA";
            this.KETQUA.ReadOnly = true;
            // 
            // DONGIA
            // 
            this.DONGIA.DataPropertyName = "DONGIA";
            this.DONGIA.HeaderText = "Column1";
            this.DONGIA.MinimumWidth = 6;
            this.DONGIA.Name = "DONGIA";
            this.DONGIA.ReadOnly = true;
            this.DONGIA.Visible = false;
            this.DONGIA.Width = 125;
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
            this.menu.Size = new System.Drawing.Size(184, 34);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.White;
            this.btnThem.BackgroundColor = System.Drawing.Color.White;
            this.btnThem.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnThem.BorderRadius = 10;
            this.btnThem.BorderSize = 0;
            this.btnThem.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Image = global::GUI.Properties.Resources.plus;
            this.btnThem.Location = new System.Drawing.Point(459, 3);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(41, 41);
            this.btnThem.TabIndex = 1;
            this.btnThem.TextColor = System.Drawing.Color.White;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.btnXoa.Image = global::GUI.Properties.Resources.delete__1_;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(183, 30);
            this.btnXoa.Text = "Xóa dịch vụ";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // frmKhamBenh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1482, 953);
            this.Controls.Add(this.tableLayoutPanel1);
            this.KeyPreview = true;
            this.Name = "frmKhamBenh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Khám bệnh";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.frmKhamBenh_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmKhamBenh_FormClosing);
            this.Load += new System.EventHandler(this.frmKhamBenh_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBenhNhan)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTDV)).EndInit();
            this.menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvBenhNhan;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label2;
        private textBoxCustom lbTenBn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private CustomControls.RJControls.RJComboBox cboDichVu;
        private CustomButton btnThem;
        private System.Windows.Forms.Label label4;
        private textBoxCustom txtMoTa;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private CustomButton btnLuu;
        private CustomButton btnToaThuoc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvCTDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn LSKB;
        private System.Windows.Forms.DataGridViewTextBoxColumn MABN;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENBN;
        private System.Windows.Forms.Label label5;
        private textBoxCustom txtChanDoan;
        private CustomControls.RJControls.RJDropdownMenu menu;
        private System.Windows.Forms.ToolStripMenuItem btnXoa;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HINHANH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MACD;
        private System.Windows.Forms.DataGridViewTextBoxColumn MOTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn KETQUA;
        private System.Windows.Forms.DataGridViewTextBoxColumn DONGIA;
    }
}