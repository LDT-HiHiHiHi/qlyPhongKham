
namespace GUI
{
    partial class frmDoiMatKhau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDoiMatKhau));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnXacNhan = new GUI.CustomButton();
            this.txtPW = new GUI.textBoxCustom();
            this.txtRPW = new GUI.textBoxCustom();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nhập lại mật khẩu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mật khẩu mới";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tên tài khoản";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(206, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "none";
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
            this.btnXacNhan.Location = new System.Drawing.Point(309, 285);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(150, 45);
            this.btnXacNhan.TabIndex = 10;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.TextColor = System.Drawing.Color.White;
            this.btnXacNhan.UseVisualStyleBackColor = false;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // txtPW
            // 
            this.txtPW.BorderColor = System.Drawing.Color.Navy;
            this.txtPW.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtPW.BorderRadius = 0;
            this.txtPW.BorderSize = 1;
            this.txtPW.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPW.Location = new System.Drawing.Point(209, 175);
            this.txtPW.Margin = new System.Windows.Forms.Padding(4);
            this.txtPW.Multiline = false;
            this.txtPW.Name = "txtPW";
            this.txtPW.Padding = new System.Windows.Forms.Padding(7);
            this.txtPW.PasswordChar = true;
            this.txtPW.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPW.PlaceholderText = "";
            this.txtPW.Size = new System.Drawing.Size(250, 34);
            this.txtPW.TabIndex = 7;
            this.txtPW.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPW.Texts = "";
            this.txtPW.UnderlinedStyle = true;
            this.txtPW._TextChanged += new System.EventHandler(this.txtPW__TextChanged);
            // 
            // txtRPW
            // 
            this.txtRPW.BorderColor = System.Drawing.Color.Navy;
            this.txtRPW.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtRPW.BorderRadius = 0;
            this.txtRPW.BorderSize = 1;
            this.txtRPW.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRPW.Location = new System.Drawing.Point(209, 229);
            this.txtRPW.Margin = new System.Windows.Forms.Padding(4);
            this.txtRPW.Multiline = false;
            this.txtRPW.Name = "txtRPW";
            this.txtRPW.Padding = new System.Windows.Forms.Padding(7);
            this.txtRPW.PasswordChar = true;
            this.txtRPW.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtRPW.PlaceholderText = "";
            this.txtRPW.Size = new System.Drawing.Size(250, 34);
            this.txtRPW.TabIndex = 8;
            this.txtRPW.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtRPW.Texts = "";
            this.txtRPW.UnderlinedStyle = true;
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
            this.pictureBox1.Location = new System.Drawing.Point(206, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // frmDoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(502, 343);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtPW);
            this.Controls.Add(this.txtRPW);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(520, 390);
            this.MinimumSize = new System.Drawing.Size(520, 390);
            this.Name = "frmDoiMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi mật khẩu";
            this.Load += new System.EventHandler(this.frmDoiMatKhau_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private textBoxCustom txtPW;
        private textBoxCustom txtRPW;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private CustomButton btnXacNhan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}