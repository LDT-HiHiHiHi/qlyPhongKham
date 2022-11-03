namespace GUI
{
    partial class frmLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbTDN = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDangNhap = new GUI.CustomButton();
            this.textBoxCustom1 = new GUI.textBoxCustom();
            this.txtTDN = new GUI.textBoxCustom();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 35);
            this.label1.TabIndex = 13;
            this.label1.Text = "Mật khẩu";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbTDN
            // 
            this.lbTDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTDN.Location = new System.Drawing.Point(27, 154);
            this.lbTDN.Name = "lbTDN";
            this.lbTDN.Size = new System.Drawing.Size(151, 35);
            this.lbTDN.TabIndex = 12;
            this.lbTDN.Text = "Tên đăng nhập";
            this.lbTDN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(192, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(222, 100);
            this.label3.TabIndex = 10;
            this.label3.Text = "ĐĂNG NHẬP";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.hospital;
            this.pictureBox1.Location = new System.Drawing.Point(31, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDangNhap.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.btnDangNhap.BorderColor = System.Drawing.Color.Blue;
            this.btnDangNhap.BorderRadius = 0;
            this.btnDangNhap.BorderSize = 0;
            this.btnDangNhap.FlatAppearance.BorderSize = 0;
            this.btnDangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.ForeColor = System.Drawing.Color.White;
            this.btnDangNhap.Location = new System.Drawing.Point(171, 262);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(150, 40);
            this.btnDangNhap.TabIndex = 16;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.TextColor = System.Drawing.Color.White;
            this.btnDangNhap.UseVisualStyleBackColor = false;
            // 
            // textBoxCustom1
            // 
            this.textBoxCustom1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCustom1.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxCustom1.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.textBoxCustom1.BorderFocusColor = System.Drawing.Color.Aqua;
            this.textBoxCustom1.BorderSize = 2;
            this.textBoxCustom1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCustom1.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxCustom1.Location = new System.Drawing.Point(171, 207);
            this.textBoxCustom1.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCustom1.Multiline = false;
            this.textBoxCustom1.Name = "textBoxCustom1";
            this.textBoxCustom1.Padding = new System.Windows.Forms.Padding(7);
            this.textBoxCustom1.PasswordChar = false;
            this.textBoxCustom1.Size = new System.Drawing.Size(278, 35);
            this.textBoxCustom1.TabIndex = 15;
            this.textBoxCustom1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxCustom1.Texts = "";
            this.textBoxCustom1.UnderlinedStyle = false;
            // 
            // txtTDN
            // 
            this.txtTDN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTDN.BackColor = System.Drawing.SystemColors.Window;
            this.txtTDN.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.txtTDN.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txtTDN.BorderSize = 2;
            this.txtTDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTDN.ForeColor = System.Drawing.Color.DimGray;
            this.txtTDN.Location = new System.Drawing.Point(171, 154);
            this.txtTDN.Margin = new System.Windows.Forms.Padding(4);
            this.txtTDN.Multiline = false;
            this.txtTDN.Name = "txtTDN";
            this.txtTDN.Padding = new System.Windows.Forms.Padding(7);
            this.txtTDN.PasswordChar = false;
            this.txtTDN.Size = new System.Drawing.Size(278, 35);
            this.txtTDN.TabIndex = 14;
            this.txtTDN.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTDN.Texts = "";
            this.txtTDN.UnderlinedStyle = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 332);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.textBoxCustom1);
            this.Controls.Add(this.txtTDN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbTDN);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTDN;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private textBoxCustom txtTDN;
        private textBoxCustom textBoxCustom1;
        private CustomButton btnDangNhap;
    }
}

