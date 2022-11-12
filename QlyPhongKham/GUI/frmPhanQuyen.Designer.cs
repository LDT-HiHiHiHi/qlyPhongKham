namespace GUI
{
    partial class frmPhanQuyen
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhanQuyen));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.drvNhomNguoiDung = new System.Windows.Forms.DataGridView();
            this.MAQUYEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.drvPhanQuyen = new System.Windows.Forms.DataGridView();
            this.ID_PQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COQUYEN = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ckAll = new System.Windows.Forms.CheckBox();
            this.btnLuu = new GUI.CustomButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drvNhomNguoiDung)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drvPhanQuyen)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.drvNhomNguoiDung);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 492);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhóm người dùng";
            // 
            // drvNhomNguoiDung
            // 
            this.drvNhomNguoiDung.AllowUserToAddRows = false;
            this.drvNhomNguoiDung.AllowUserToDeleteRows = false;
            this.drvNhomNguoiDung.BackgroundColor = System.Drawing.SystemColors.Info;
            this.drvNhomNguoiDung.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.drvNhomNguoiDung.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.drvNhomNguoiDung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.drvNhomNguoiDung.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAQUYEN,
            this.Column5,
            this.Column6});
            this.drvNhomNguoiDung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drvNhomNguoiDung.EnableHeadersVisualStyles = false;
            this.drvNhomNguoiDung.Location = new System.Drawing.Point(3, 23);
            this.drvNhomNguoiDung.Name = "drvNhomNguoiDung";
            this.drvNhomNguoiDung.ReadOnly = true;
            this.drvNhomNguoiDung.RowHeadersVisible = false;
            this.drvNhomNguoiDung.RowHeadersWidth = 51;
            this.drvNhomNguoiDung.RowTemplate.Height = 24;
            this.drvNhomNguoiDung.Size = new System.Drawing.Size(304, 466);
            this.drvNhomNguoiDung.TabIndex = 0;
            this.drvNhomNguoiDung.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.drvNhomNguoiDung_CellClick);
            // 
            // MAQUYEN
            // 
            this.MAQUYEN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.MAQUYEN.DataPropertyName = "MAQUYEN";
            this.MAQUYEN.HeaderText = "Mã quyền";
            this.MAQUYEN.MinimumWidth = 6;
            this.MAQUYEN.Name = "MAQUYEN";
            this.MAQUYEN.ReadOnly = true;
            this.MAQUYEN.Visible = false;
            this.MAQUYEN.Width = 125;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.DataPropertyName = "TENQUYEN";
            this.Column5.HeaderText = "Tên nhóm";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "CODE";
            this.Column6.HeaderText = "Column6";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Visible = false;
            this.Column6.Width = 125;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.drvPhanQuyen);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(328, 11);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(578, 422);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Màn hình";
            // 
            // drvPhanQuyen
            // 
            this.drvPhanQuyen.AllowUserToAddRows = false;
            this.drvPhanQuyen.AllowUserToDeleteRows = false;
            this.drvPhanQuyen.BackgroundColor = System.Drawing.SystemColors.Info;
            this.drvPhanQuyen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.drvPhanQuyen.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.drvPhanQuyen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.drvPhanQuyen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_PQ,
            this.Column2,
            this.COQUYEN});
            this.drvPhanQuyen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drvPhanQuyen.EnableHeadersVisualStyles = false;
            this.drvPhanQuyen.Location = new System.Drawing.Point(3, 23);
            this.drvPhanQuyen.Name = "drvPhanQuyen";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.drvPhanQuyen.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.drvPhanQuyen.RowHeadersVisible = false;
            this.drvPhanQuyen.RowHeadersWidth = 51;
            this.drvPhanQuyen.RowTemplate.Height = 24;
            this.drvPhanQuyen.Size = new System.Drawing.Size(572, 396);
            this.drvPhanQuyen.TabIndex = 0;
            // 
            // ID_PQ
            // 
            this.ID_PQ.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ID_PQ.DataPropertyName = "ID";
            this.ID_PQ.HeaderText = "ID";
            this.ID_PQ.MinimumWidth = 6;
            this.ID_PQ.Name = "ID_PQ";
            this.ID_PQ.Visible = false;
            this.ID_PQ.Width = 125;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "TENMH";
            this.Column2.HeaderText = "Tên màn hình";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // COQUYEN
            // 
            this.COQUYEN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.COQUYEN.DataPropertyName = "COQUYEN";
            this.COQUYEN.HeaderText = "Quyền";
            this.COQUYEN.MinimumWidth = 6;
            this.COQUYEN.Name = "COQUYEN";
            this.COQUYEN.Width = 59;
            // 
            // ckAll
            // 
            this.ckAll.AutoSize = true;
            this.ckAll.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckAll.Location = new System.Drawing.Point(331, 436);
            this.ckAll.Name = "ckAll";
            this.ckAll.Size = new System.Drawing.Size(107, 23);
            this.ckAll.TabIndex = 7;
            this.ckAll.Text = "Chọn tất cả";
            this.ckAll.UseVisualStyleBackColor = true;
            this.ckAll.Click += new System.EventHandler(this.ckAll_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.Blue;
            this.btnLuu.BackgroundColor = System.Drawing.Color.Blue;
            this.btnLuu.BorderColor = System.Drawing.Color.White;
            this.btnLuu.BorderRadius = 5;
            this.btnLuu.BorderSize = 0;
            this.btnLuu.FlatAppearance.BorderSize = 0;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Image = global::GUI.Properties.Resources.diskette__4_;
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(753, 460);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Padding = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.btnLuu.Size = new System.Drawing.Size(150, 45);
            this.btnLuu.TabIndex = 6;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextColor = System.Drawing.Color.White;
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // frmPhanQuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(918, 516);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.ckAll);
            this.Controls.Add(this.btnLuu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(936, 563);
            this.MinimumSize = new System.Drawing.Size(936, 563);
            this.Name = "frmPhanQuyen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phân quyền";
            this.Load += new System.EventHandler(this.frmPhanQuyen_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.drvNhomNguoiDung)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.drvPhanQuyen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView drvNhomNguoiDung;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView drvPhanQuyen;
        private System.Windows.Forms.CheckBox ckAll;
        private CustomButton btnLuu;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_PQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn COQUYEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAQUYEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;

    }
}