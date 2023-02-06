
namespace GUI
{
    partial class frmThemBacSi
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
            this.btnThem = new GUI.CustomButton();
            this.label2 = new System.Windows.Forms.Label();
            this.lbTen = new System.Windows.Forms.Label();
            this.cboPhong = new CustomControls.RJControls.RJComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Phòng";
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Navy;
            this.btnThem.BackgroundColor = System.Drawing.Color.Navy;
            this.btnThem.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnThem.BorderRadius = 5;
            this.btnThem.BorderSize = 0;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(96, 116);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(150, 49);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm bác sĩ";
            this.btnThem.TextColor = System.Drawing.Color.White;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên tài khoản";
            // 
            // lbTen
            // 
            this.lbTen.AutoSize = true;
            this.lbTen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTen.Location = new System.Drawing.Point(169, 22);
            this.lbTen.Name = "lbTen";
            this.lbTen.Size = new System.Drawing.Size(60, 22);
            this.lbTen.TabIndex = 4;
            this.lbTen.Text = "label3";
            // 
            // cboPhong
            // 
            this.cboPhong.BackColor = System.Drawing.Color.White;
            this.cboPhong.BorderColor = System.Drawing.Color.Navy;
            this.cboPhong.BorderSize = 1;
            this.cboPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPhong.ForeColor = System.Drawing.Color.Black;
            this.cboPhong.IconColor = System.Drawing.Color.Black;
            this.cboPhong.ListBackColor = System.Drawing.Color.White;
            this.cboPhong.ListTextColor = System.Drawing.Color.Black;
            this.cboPhong.Location = new System.Drawing.Point(116, 61);
            this.cboPhong.MinimumSize = new System.Drawing.Size(200, 30);
            this.cboPhong.Name = "cboPhong";
            this.cboPhong.Padding = new System.Windows.Forms.Padding(1);
            this.cboPhong.Size = new System.Drawing.Size(200, 34);
            this.cboPhong.TabIndex = 5;
            this.cboPhong.Texts = "";
            // 
            // frmThemBacSi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(328, 191);
            this.Controls.Add(this.cboPhong);
            this.Controls.Add(this.lbTen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(346, 238);
            this.MinimumSize = new System.Drawing.Size(346, 238);
            this.Name = "frmThemBacSi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm bác sĩ";
            this.Load += new System.EventHandler(this.frmThemBacSi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private CustomButton btnThem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbTen;
        private CustomControls.RJControls.RJComboBox cboPhong;
    }
}