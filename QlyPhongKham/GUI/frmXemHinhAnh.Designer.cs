
namespace GUI
{
    partial class frmXemHinhAnh
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
            this.hienThi = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.hienThi)).BeginInit();
            this.SuspendLayout();
            // 
            // hienThi
            // 
            this.hienThi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hienThi.Location = new System.Drawing.Point(0, 0);
            this.hienThi.Name = "hienThi";
            this.hienThi.Size = new System.Drawing.Size(982, 753);
            this.hienThi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hienThi.TabIndex = 0;
            this.hienThi.TabStop = false;
            // 
            // frmXemHinhAnh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 753);
            this.Controls.Add(this.hienThi);
            this.Name = "frmXemHinhAnh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmXemHinhAnh";
            this.Load += new System.EventHandler(this.frmXemHinhAnh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hienThi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox hienThi;
    }
}