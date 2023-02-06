
namespace GUI
{
    partial class frmThemTaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThemTaiKhoan));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRPW = new GUI.textBoxCustom();
            this.txtPW = new GUI.textBoxCustom();
            this.txtTenDN = new GUI.textBoxCustom();
            this.btnXacNhan = new GUI.CustomButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên đăng nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(76, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mật khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nhập lại mật khẩu";
            // 
            // txtRPW
            // 
            this.txtRPW.BorderColor = System.Drawing.Color.Navy;
            this.txtRPW.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtRPW.BorderRadius = 0;
            this.txtRPW.BorderSize = 1;
            this.txtRPW.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRPW.Location = new System.Drawing.Point(187, 239);
            this.txtRPW.Margin = new System.Windows.Forms.Padding(4);
            this.txtRPW.Multiline = false;
            this.txtRPW.Name = "txtRPW";
            this.txtRPW.Padding = new System.Windows.Forms.Padding(7);
            this.txtRPW.PasswordChar = true;
            this.txtRPW.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtRPW.PlaceholderText = "";
            this.txtRPW.Size = new System.Drawing.Size(250, 34);
            this.txtRPW.TabIndex = 4;
            this.txtRPW.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtRPW.Texts = "";
            this.txtRPW.UnderlinedStyle = true;
            // 
            // txtPW
            // 
            this.txtPW.BorderColor = System.Drawing.Color.Navy;
            this.txtPW.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtPW.BorderRadius = 0;
            this.txtPW.BorderSize = 1;
            this.txtPW.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPW.Location = new System.Drawing.Point(187, 185);
            this.txtPW.Margin = new System.Windows.Forms.Padding(4);
            this.txtPW.Multiline = false;
            this.txtPW.Name = "txtPW";
            this.txtPW.Padding = new System.Windows.Forms.Padding(7);
            this.txtPW.PasswordChar = true;
            this.txtPW.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPW.PlaceholderText = "";
            this.txtPW.Size = new System.Drawing.Size(250, 34);
            this.txtPW.TabIndex = 4;
            this.txtPW.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPW.Texts = "";
            this.txtPW.UnderlinedStyle = true;
            this.txtPW.Leave += new System.EventHandler(this.txtPW_Leave);
            // 
            // txtTenDN
            // 
            this.txtTenDN.BorderColor = System.Drawing.Color.Navy;
            this.txtTenDN.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtTenDN.BorderRadius = 0;
            this.txtTenDN.BorderSize = 1;
            this.txtTenDN.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDN.Location = new System.Drawing.Point(187, 125);
            this.txtTenDN.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenDN.Multiline = false;
            this.txtTenDN.Name = "txtTenDN";
            this.txtTenDN.Padding = new System.Windows.Forms.Padding(7);
            this.txtTenDN.PasswordChar = false;
            this.txtTenDN.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTenDN.PlaceholderText = "";
            this.txtTenDN.Size = new System.Drawing.Size(250, 34);
            this.txtTenDN.TabIndex = 4;
            this.txtTenDN.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTenDN.Texts = "";
            this.txtTenDN.UnderlinedStyle = true;
            this.txtTenDN.Leave += new System.EventHandler(this.txtTenDN_Leave);
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.BackColor = System.Drawing.Color.Navy;
            this.btnXacNhan.BackgroundColor = System.Drawing.Color.Navy;
            this.btnXacNhan.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnXacNhan.BorderRadius = 8;
            this.btnXacNhan.BorderSize = 0;
            this.btnXacNhan.FlatAppearance.BorderSize = 0;
            this.btnXacNhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXacNhan.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacNhan.ForeColor = System.Drawing.Color.White;
            this.btnXacNhan.Location = new System.Drawing.Point(271, 305);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(150, 40);
            this.btnXacNhan.TabIndex = 5;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.TextColor = System.Drawing.Color.White;
            this.btnXacNhan.UseVisualStyleBackColor = false;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
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
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.user__4_;
            this.pictureBox1.Location = new System.Drawing.Point(189, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmThemTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(471, 370);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.txtTenDN);
            this.Controls.Add(this.txtPW);
            this.Controls.Add(this.txtRPW);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(489, 417);
            this.MinimumSize = new System.Drawing.Size(489, 417);
            this.Name = "frmThemTaiKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm tài khoản";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private textBoxCustom txtRPW;
        private textBoxCustom txtPW;
        private textBoxCustom txtTenDN;
        private CustomButton btnXacNhan;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}