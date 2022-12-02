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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.xóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvManHinh = new System.Windows.Forms.DataGridView();
            this.IDMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIDMH = new GUI.textBoxCustom();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenMH = new GUI.textBoxCustom();
            this.btnLuu = new GUI.CustomButton();
            this.contextMenuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManHinh)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dgvManHinh, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(682, 653);
            this.tableLayoutPanel1.TabIndex = 22;
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
            this.dgvManHinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvManHinh.Location = new System.Drawing.Point(3, 83);
            this.dgvManHinh.Name = "dgvManHinh";
            this.dgvManHinh.ReadOnly = true;
            this.dgvManHinh.RowHeadersVisible = false;
            this.dgvManHinh.RowHeadersWidth = 51;
            this.dgvManHinh.RowTemplate.Height = 24;
            this.dgvManHinh.Size = new System.Drawing.Size(676, 404);
            this.dgvManHinh.TabIndex = 25;
            this.dgvManHinh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvManHinh_CellClick);
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
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(676, 80);
            this.label1.TabIndex = 26;
            this.label1.Text = "Quản lý màn hình";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtIDMH, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtTenMH, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnLuu, 1, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 493);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(676, 157);
            this.tableLayoutPanel2.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(332, 43);
            this.label2.TabIndex = 23;
            this.label2.Text = "ID Màn hình";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtIDMH
            // 
            this.txtIDMH.BorderColor = System.Drawing.Color.Navy;
            this.txtIDMH.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtIDMH.BorderRadius = 0;
            this.txtIDMH.BorderSize = 1;
            this.txtIDMH.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtIDMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDMH.Location = new System.Drawing.Point(342, 4);
            this.txtIDMH.Margin = new System.Windows.Forms.Padding(4);
            this.txtIDMH.Multiline = false;
            this.txtIDMH.Name = "txtIDMH";
            this.txtIDMH.Padding = new System.Windows.Forms.Padding(7);
            this.txtIDMH.PasswordChar = false;
            this.txtIDMH.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtIDMH.PlaceholderText = "";
            this.txtIDMH.Size = new System.Drawing.Size(250, 35);
            this.txtIDMH.TabIndex = 26;
            this.txtIDMH.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtIDMH.Texts = "";
            this.txtIDMH.UnderlinedStyle = true;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(332, 43);
            this.label3.TabIndex = 27;
            this.label3.Text = "Tên màn hình";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTenMH
            // 
            this.txtTenMH.BorderColor = System.Drawing.Color.Navy;
            this.txtTenMH.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtTenMH.BorderRadius = 0;
            this.txtTenMH.BorderSize = 1;
            this.txtTenMH.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtTenMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenMH.Location = new System.Drawing.Point(342, 47);
            this.txtTenMH.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenMH.Multiline = false;
            this.txtTenMH.Name = "txtTenMH";
            this.txtTenMH.Padding = new System.Windows.Forms.Padding(7);
            this.txtTenMH.PasswordChar = false;
            this.txtTenMH.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTenMH.PlaceholderText = "";
            this.txtTenMH.Size = new System.Drawing.Size(250, 35);
            this.txtTenMH.TabIndex = 28;
            this.txtTenMH.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTenMH.Texts = "";
            this.txtTenMH.UnderlinedStyle = true;
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.MediumBlue;
            this.btnLuu.BackgroundColor = System.Drawing.Color.MediumBlue;
            this.btnLuu.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnLuu.BorderRadius = 5;
            this.btnLuu.BorderSize = 0;
            this.btnLuu.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnLuu.FlatAppearance.BorderSize = 0;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Image = global::GUI.Properties.Resources.diskette__4_;
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(485, 96);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(3, 10, 30, 3);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnLuu.Size = new System.Drawing.Size(161, 40);
            this.btnLuu.TabIndex = 29;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextColor = System.Drawing.Color.White;
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // frmManHinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(682, 653);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmManHinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Màn hình";
            this.Activated += new System.EventHandler(this.frmManHinh_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmManHinh_FormClosing);
            this.Load += new System.EventHandler(this.frmManHinh_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvManHinh)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem xóaToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgvManHinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENMH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private textBoxCustom txtIDMH;
        private System.Windows.Forms.Label label3;
        private textBoxCustom txtTenMH;
        private CustomButton btnLuu;
    }
}