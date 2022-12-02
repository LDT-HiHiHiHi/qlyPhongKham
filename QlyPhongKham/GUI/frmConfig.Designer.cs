namespace GUI
{
    partial class frmConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfig));
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPw = new GUI.textBoxCustom();
            this.txtUsername = new GUI.textBoxCustom();
            this.customButton2 = new GUI.CustomButton();
            this.btnLuu = new GUI.CustomButton();
            this.cbDb = new NoteWrapper.FlatCombobox();
            this.cbServername = new NoteWrapper.FlatCombobox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(19, 230);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 22);
            this.label4.TabIndex = 23;
            this.label4.Text = "Database:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(20, 188);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 22);
            this.label3.TabIndex = 22;
            this.label3.Text = "Password:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(18, 140);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 22);
            this.label2.TabIndex = 21;
            this.label2.Text = "User name:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(-2, 93);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 22);
            this.label1.TabIndex = 20;
            this.label1.Text = "Server name:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPw
            // 
            this.txtPw.BackColor = System.Drawing.Color.White;
            this.txtPw.BorderColor = System.Drawing.Color.Black;
            this.txtPw.BorderFocusColor = System.Drawing.Color.Gold;
            this.txtPw.BorderRadius = 0;
            this.txtPw.BorderSize = 1;
            this.txtPw.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPw.Location = new System.Drawing.Point(137, 183);
            this.txtPw.Margin = new System.Windows.Forms.Padding(4);
            this.txtPw.Multiline = false;
            this.txtPw.Name = "txtPw";
            this.txtPw.Padding = new System.Windows.Forms.Padding(7);
            this.txtPw.PasswordChar = true;
            this.txtPw.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPw.PlaceholderText = "";
            this.txtPw.Size = new System.Drawing.Size(235, 32);
            this.txtPw.TabIndex = 34;
            this.txtPw.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPw.Texts = "";
            this.txtPw.UnderlinedStyle = false;
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.White;
            this.txtUsername.BorderColor = System.Drawing.Color.Black;
            this.txtUsername.BorderFocusColor = System.Drawing.Color.Gold;
            this.txtUsername.BorderRadius = 0;
            this.txtUsername.BorderSize = 1;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(137, 135);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsername.Multiline = false;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Padding = new System.Windows.Forms.Padding(7);
            this.txtUsername.PasswordChar = false;
            this.txtUsername.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtUsername.PlaceholderText = "";
            this.txtUsername.Size = new System.Drawing.Size(235, 33);
            this.txtUsername.TabIndex = 33;
            this.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUsername.Texts = "";
            this.txtUsername.UnderlinedStyle = false;
            // 
            // customButton2
            // 
            this.customButton2.BackColor = System.Drawing.Color.White;
            this.customButton2.BackgroundColor = System.Drawing.Color.White;
            this.customButton2.BorderColor = System.Drawing.Color.Navy;
            this.customButton2.BorderRadius = 8;
            this.customButton2.BorderSize = 1;
            this.customButton2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.customButton2.FlatAppearance.BorderSize = 0;
            this.customButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.customButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.customButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customButton2.ForeColor = System.Drawing.Color.Navy;
            this.customButton2.Location = new System.Drawing.Point(264, 273);
            this.customButton2.Name = "customButton2";
            this.customButton2.Size = new System.Drawing.Size(110, 40);
            this.customButton2.TabIndex = 32;
            this.customButton2.Text = "Hủy";
            this.customButton2.TextColor = System.Drawing.Color.Navy;
            this.customButton2.UseVisualStyleBackColor = false;
            this.customButton2.Click += new System.EventHandler(this.customButton2_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.Navy;
            this.btnLuu.BackgroundColor = System.Drawing.Color.Navy;
            this.btnLuu.BorderColor = System.Drawing.Color.Gold;
            this.btnLuu.BorderRadius = 8;
            this.btnLuu.BorderSize = 1;
            this.btnLuu.FlatAppearance.BorderSize = 0;
            this.btnLuu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(128, 273);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(130, 40);
            this.btnLuu.TabIndex = 32;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextColor = System.Drawing.Color.White;
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // cbDb
            // 
            this.cbDb.BorderColor = System.Drawing.Color.Black;
            this.cbDb.ButtonColor = System.Drawing.Color.WhiteSmoke;
            this.cbDb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDb.FormattingEnabled = true;
            this.cbDb.Location = new System.Drawing.Point(137, 228);
            this.cbDb.Name = "cbDb";
            this.cbDb.Size = new System.Drawing.Size(235, 28);
            this.cbDb.TabIndex = 30;
            this.cbDb.DropDown += new System.EventHandler(this.cbDb_DropDown);
            // 
            // cbServername
            // 
            this.cbServername.BorderColor = System.Drawing.Color.Black;
            this.cbServername.ButtonColor = System.Drawing.Color.WhiteSmoke;
            this.cbServername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbServername.FormattingEnabled = true;
            this.cbServername.Location = new System.Drawing.Point(138, 90);
            this.cbServername.Name = "cbServername";
            this.cbServername.Size = new System.Drawing.Size(234, 28);
            this.cbServername.TabIndex = 1;
            this.cbServername.DropDown += new System.EventHandler(this.cbServername_DropDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.link;
            this.pictureBox1.Location = new System.Drawing.Point(101, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(154, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 37);
            this.label5.TabIndex = 36;
            this.label5.Text = "KẾT NỐI";
            // 
            // frmConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(399, 329);
            this.ControlBox = false;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtPw);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.customButton2);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.cbDb);
            this.Controls.Add(this.cbServername);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmConfig";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private NoteWrapper.FlatCombobox cbServername;
        private NoteWrapper.FlatCombobox cbDb;
        private CustomButton btnLuu;
        private CustomButton customButton2;
        private textBoxCustom txtUsername;
        private textBoxCustom txtPw;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
    }
}