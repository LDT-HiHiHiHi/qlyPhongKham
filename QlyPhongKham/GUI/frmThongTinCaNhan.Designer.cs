
namespace GUI
{
    partial class frmThongTinCaNhan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThongTinCaNhan));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtSDT = new GUI.textBoxCustom();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDiaChi = new GUI.textBoxCustom();
            this.txtNgaySinh = new GUI.RJDatePicker();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHoTen = new GUI.textBoxCustom();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.rdbNam = new CustomControls.RJControls.RJRadioButton();
            this.rdbNu = new CustomControls.RJControls.RJRadioButton();
            this.btnLuu = new GUI.CustomButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.95876F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.04124F));
            this.tableLayoutPanel1.Controls.Add(this.txtSDT, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtDiaChi, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtNgaySinh, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtHoTen, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnLuu, 1, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(582, 453);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // txtSDT
            // 
            this.txtSDT.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtSDT.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtSDT.BorderRadius = 0;
            this.txtSDT.BorderSize = 1;
            this.txtSDT.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtSDT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.Location = new System.Drawing.Point(189, 323);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(4);
            this.txtSDT.Multiline = false;
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Padding = new System.Windows.Forms.Padding(7);
            this.txtSDT.PasswordChar = false;
            this.txtSDT.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSDT.PlaceholderText = "";
            this.txtSDT.Size = new System.Drawing.Size(300, 37);
            this.txtSDT.TabIndex = 27;
            this.txtSDT.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSDT.Texts = "";
            this.txtSDT.UnderlinedStyle = true;
            this.txtSDT._TextChanged += new System.EventHandler(this.txtSDT__TextChanged);
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label5.Location = new System.Drawing.Point(3, 319);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.label5.Size = new System.Drawing.Size(179, 50);
            this.label5.TabIndex = 26;
            this.label5.Text = "Số điện thoại";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtDiaChi.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtDiaChi.BorderRadius = 0;
            this.txtDiaChi.BorderSize = 1;
            this.txtDiaChi.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtDiaChi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Location = new System.Drawing.Point(189, 273);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiaChi.Multiline = false;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Padding = new System.Windows.Forms.Padding(7);
            this.txtDiaChi.PasswordChar = false;
            this.txtDiaChi.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDiaChi.PlaceholderText = "";
            this.txtDiaChi.Size = new System.Drawing.Size(300, 37);
            this.txtDiaChi.TabIndex = 25;
            this.txtDiaChi.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDiaChi.Texts = "";
            this.txtDiaChi.UnderlinedStyle = true;
            this.txtDiaChi._TextChanged += new System.EventHandler(this.txtDiaChi__TextChanged);
            // 
            // txtNgaySinh
            // 
            this.txtNgaySinh.BorderColor = System.Drawing.Color.DodgerBlue;
            this.txtNgaySinh.BorderSize = 1;
            this.txtNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.txtNgaySinh.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtNgaySinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtNgaySinh.Location = new System.Drawing.Point(188, 171);
            this.txtNgaySinh.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.txtNgaySinh.MinimumSize = new System.Drawing.Size(4, 35);
            this.txtNgaySinh.Name = "txtNgaySinh";
            this.txtNgaySinh.Size = new System.Drawing.Size(300, 35);
            this.txtNgaySinh.SkinColor = System.Drawing.Color.White;
            this.txtNgaySinh.TabIndex = 23;
            this.txtNgaySinh.TextColor = System.Drawing.Color.Black;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 2);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.pictureBox1, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(576, 100);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::GUI.Properties.Resources.user__4_;
            this.pictureBox1.Location = new System.Drawing.Point(238, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label1.Location = new System.Drawing.Point(3, 113);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.label1.Size = new System.Drawing.Size(179, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "Họ tên";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 163);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.label2.Size = new System.Drawing.Size(179, 50);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ngày sinh";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label3.Location = new System.Drawing.Point(3, 213);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.label3.Size = new System.Drawing.Size(179, 56);
            this.label3.TabIndex = 3;
            this.label3.Text = "Giới tính";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label4.Location = new System.Drawing.Point(3, 269);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.label4.Size = new System.Drawing.Size(179, 50);
            this.label4.TabIndex = 4;
            this.label4.Text = "Địa chỉ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtHoTen
            // 
            this.txtHoTen.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtHoTen.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtHoTen.BorderRadius = 0;
            this.txtHoTen.BorderSize = 1;
            this.txtHoTen.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtHoTen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.Location = new System.Drawing.Point(189, 117);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(4);
            this.txtHoTen.Multiline = false;
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Padding = new System.Windows.Forms.Padding(7);
            this.txtHoTen.PasswordChar = false;
            this.txtHoTen.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtHoTen.PlaceholderText = "";
            this.txtHoTen.Size = new System.Drawing.Size(300, 37);
            this.txtHoTen.TabIndex = 6;
            this.txtHoTen.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtHoTen.Texts = "";
            this.txtHoTen.UnderlinedStyle = true;
            this.txtHoTen._TextChanged += new System.EventHandler(this.txtHoTen__TextChanged);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.76923F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.23077F));
            this.tableLayoutPanel3.Controls.Add(this.rdbNam, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.rdbNu, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel3.Location = new System.Drawing.Point(188, 216);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(391, 50);
            this.tableLayoutPanel3.TabIndex = 24;
            // 
            // rdbNam
            // 
            this.rdbNam.Checked = true;
            this.rdbNam.CheckedColor = System.Drawing.Color.Blue;
            this.rdbNam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rdbNam.Location = new System.Drawing.Point(3, 3);
            this.rdbNam.MinimumSize = new System.Drawing.Size(0, 21);
            this.rdbNam.Name = "rdbNam";
            this.rdbNam.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rdbNam.Size = new System.Drawing.Size(192, 44);
            this.rdbNam.TabIndex = 0;
            this.rdbNam.TabStop = true;
            this.rdbNam.Text = "Nam";
            this.rdbNam.UnCheckedColor = System.Drawing.Color.Blue;
            this.rdbNam.UseVisualStyleBackColor = true;
            // 
            // rdbNu
            // 
            this.rdbNu.CheckedColor = System.Drawing.Color.HotPink;
            this.rdbNu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rdbNu.Location = new System.Drawing.Point(201, 3);
            this.rdbNu.MinimumSize = new System.Drawing.Size(0, 21);
            this.rdbNu.Name = "rdbNu";
            this.rdbNu.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rdbNu.Size = new System.Drawing.Size(187, 44);
            this.rdbNu.TabIndex = 1;
            this.rdbNu.Text = "Nữ";
            this.rdbNu.UnCheckedColor = System.Drawing.Color.HotPink;
            this.rdbNu.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.Navy;
            this.btnLuu.BackgroundColor = System.Drawing.Color.Navy;
            this.btnLuu.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnLuu.BorderRadius = 5;
            this.btnLuu.BorderSize = 0;
            this.btnLuu.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnLuu.FlatAppearance.BorderSize = 0;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(382, 389);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(3, 20, 50, 3);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(150, 50);
            this.btnLuu.TabIndex = 28;
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
            // frmThongTinCaNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(582, 453);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 500);
            this.MinimumSize = new System.Drawing.Size(600, 500);
            this.Name = "frmThongTinCaNhan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin cá nhân";
            this.Load += new System.EventHandler(this.frmThongTinCaNhan_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private textBoxCustom txtHoTen;
        private textBoxCustom txtSDT;
        private System.Windows.Forms.Label label5;
        private textBoxCustom txtDiaChi;
        private RJDatePicker txtNgaySinh;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private CustomControls.RJControls.RJRadioButton rdbNam;
        private CustomControls.RJControls.RJRadioButton rdbNu;
        private CustomButton btnLuu;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
    }
}