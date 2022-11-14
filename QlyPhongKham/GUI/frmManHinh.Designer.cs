namespace GUI
{
    partial class frmManHinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManHinh));
            this.dgvManHinh = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.xóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenMH = new GUI.textBoxCustom();
            this.txtIDMH = new GUI.textBoxCustom();
            this.btnLuu = new GUI.CustomButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.IDMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManHinh)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvManHinh
            // 
            this.dgvManHinh.AllowUserToAddRows = false;
            this.dgvManHinh.AllowUserToDeleteRows = false;
            this.dgvManHinh.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.dgvManHinh.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvManHinh.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvManHinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvManHinh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDMH,
            this.TENMH});
            this.dgvManHinh.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvManHinh.Location = new System.Drawing.Point(1, 64);
            this.dgvManHinh.Name = "dgvManHinh";
            this.dgvManHinh.ReadOnly = true;
            this.dgvManHinh.RowHeadersVisible = false;
            this.dgvManHinh.RowHeadersWidth = 51;
            this.dgvManHinh.RowTemplate.Height = 24;
            this.dgvManHinh.Size = new System.Drawing.Size(581, 293);
            this.dgvManHinh.TabIndex = 18;
            this.dgvManHinh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvManHinh_CellClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xóaToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(176, 30);
            // 
            // xóaToolStripMenuItem
            // 
            this.xóaToolStripMenuItem.Image = global::GUI.Properties.Resources.delete__1_;
            this.xóaToolStripMenuItem.Name = "xóaToolStripMenuItem";
            this.xóaToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
            this.xóaToolStripMenuItem.Text = "Xóa màn hình";
            this.xóaToolStripMenuItem.Click += new System.EventHandler(this.xóaToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(85, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 19);
            this.label3.TabIndex = 17;
            this.label3.Text = "Tên màn hình";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(88, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 19);
            this.label2.TabIndex = 16;
            this.label2.Text = "ID Màn hình";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 13, 0, 0);
            this.label1.Size = new System.Drawing.Size(582, 51);
            this.label1.TabIndex = 15;
            this.label1.Text = "MÀN HÌNH";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtTenMH
            // 
            this.txtTenMH.BorderColor = System.Drawing.Color.Navy;
            this.txtTenMH.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtTenMH.BorderRadius = 0;
            this.txtTenMH.BorderSize = 1;
            this.txtTenMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenMH.Location = new System.Drawing.Point(208, 68);
            this.txtTenMH.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenMH.Multiline = false;
            this.txtTenMH.Name = "txtTenMH";
            this.txtTenMH.Padding = new System.Windows.Forms.Padding(7);
            this.txtTenMH.PasswordChar = false;
            this.txtTenMH.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTenMH.PlaceholderText = "";
            this.txtTenMH.Size = new System.Drawing.Size(250, 35);
            this.txtTenMH.TabIndex = 21;
            this.txtTenMH.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTenMH.Texts = "";
            this.txtTenMH.UnderlinedStyle = true;
            // 
            // txtIDMH
            // 
            this.txtIDMH.BorderColor = System.Drawing.Color.Navy;
            this.txtIDMH.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtIDMH.BorderRadius = 0;
            this.txtIDMH.BorderSize = 1;
            this.txtIDMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDMH.Location = new System.Drawing.Point(208, 11);
            this.txtIDMH.Margin = new System.Windows.Forms.Padding(4);
            this.txtIDMH.Multiline = false;
            this.txtIDMH.Name = "txtIDMH";
            this.txtIDMH.Padding = new System.Windows.Forms.Padding(7);
            this.txtIDMH.PasswordChar = false;
            this.txtIDMH.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtIDMH.PlaceholderText = "";
            this.txtIDMH.Size = new System.Drawing.Size(250, 35);
            this.txtIDMH.TabIndex = 20;
            this.txtIDMH.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtIDMH.Texts = "";
            this.txtIDMH.UnderlinedStyle = true;
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.MediumBlue;
            this.btnLuu.BackgroundColor = System.Drawing.Color.MediumBlue;
            this.btnLuu.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnLuu.BorderRadius = 5;
            this.btnLuu.BorderSize = 0;
            this.btnLuu.FlatAppearance.BorderSize = 0;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Image = global::GUI.Properties.Resources.diskette__4_;
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(410, 133);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnLuu.Size = new System.Drawing.Size(150, 40);
            this.btnLuu.TabIndex = 19;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextColor = System.Drawing.Color.White;
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtIDMH);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtTenMH);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnLuu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 363);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(582, 190);
            this.panel1.TabIndex = 22;
            // 
            // IDMH
            // 
            this.IDMH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IDMH.DataPropertyName = "ID";
            this.IDMH.HeaderText = "ID MÀN HÌNH";
            this.IDMH.MinimumWidth = 6;
            this.IDMH.Name = "IDMH";
            this.IDMH.ReadOnly = true;
            // 
            // TENMH
            // 
            this.TENMH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TENMH.DataPropertyName = "TENMH";
            this.TENMH.HeaderText = "TÊN MÀN HÌNH";
            this.TENMH.MinimumWidth = 6;
            this.TENMH.Name = "TENMH";
            this.TENMH.ReadOnly = true;
            // 
            // frmManHinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(582, 553);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvManHinh);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 600);
            this.MinimumSize = new System.Drawing.Size(600, 600);
            this.Name = "frmManHinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Màn hình";
            this.Load += new System.EventHandler(this.frmManHinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvManHinh)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvManHinh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem xóaToolStripMenuItem;
        private CustomButton btnLuu;
        private textBoxCustom txtIDMH;
        private textBoxCustom txtTenMH;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENMH;
    }
}