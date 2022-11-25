
namespace GUI
{
    partial class frmKhamBenh
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvBenhNhan = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvDichVu = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCustom1 = new GUI.textBoxCustom();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.cboDichVu = new CustomControls.RJControls.RJComboBox();
            this.customButton2 = new GUI.CustomButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txtChanDoan = new GUI.textBoxCustom();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.btnKeToa = new GUI.CustomButton();
            this.btnToaThuoc = new GUI.CustomButton();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBenhNhan)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVu)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.60468F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.39532F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvBenhNhan, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1482, 953);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 2);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1476, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Khám bệnh";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvBenhNhan
            // 
            this.dgvBenhNhan.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.dgvBenhNhan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBenhNhan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvBenhNhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBenhNhan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.TENBN});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBenhNhan.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvBenhNhan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBenhNhan.Location = new System.Drawing.Point(3, 63);
            this.dgvBenhNhan.Name = "dgvBenhNhan";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBenhNhan.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvBenhNhan.RowHeadersVisible = false;
            this.dgvBenhNhan.RowHeadersWidth = 51;
            this.dgvBenhNhan.RowTemplate.Height = 24;
            this.dgvBenhNhan.Size = new System.Drawing.Size(314, 887);
            this.dgvBenhNhan.TabIndex = 1;
            // 
            // STT
            // 
            this.STT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.STT.DataPropertyName = "STT";
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.Width = 65;
            // 
            // TENBN
            // 
            this.TENBN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TENBN.DataPropertyName = "TENBN";
            this.TENBN.HeaderText = "Tên bệnh nhân";
            this.TENBN.MinimumWidth = 6;
            this.TENBN.Name = "TENBN";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.dgvDichVu, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(323, 63);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 73.28072F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.71928F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1156, 887);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // dgvDichVu
            // 
            this.dgvDichVu.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.dgvDichVu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel2.SetColumnSpan(this.dgvDichVu, 2);
            this.dgvDichVu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDichVu.Location = new System.Drawing.Point(3, 3);
            this.dgvDichVu.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.dgvDichVu.Name = "dgvDichVu";
            this.dgvDichVu.RowHeadersWidth = 51;
            this.dgvDichVu.RowTemplate.Height = 24;
            this.dgvDichVu.Size = new System.Drawing.Size(1150, 637);
            this.dgvDichVu.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel2.SetColumnSpan(this.tableLayoutPanel3, 2);
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.textBoxCustom1, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.txtChanDoan, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 1, 3);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 653);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 5;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1150, 231);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(569, 46);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên bệnh nhân :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxCustom1
            // 
            this.textBoxCustom1.BorderColor = System.Drawing.Color.White;
            this.textBoxCustom1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.textBoxCustom1.BorderRadius = 0;
            this.textBoxCustom1.BorderSize = 1;
            this.textBoxCustom1.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBoxCustom1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCustom1.Location = new System.Drawing.Point(579, 4);
            this.textBoxCustom1.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCustom1.Multiline = false;
            this.textBoxCustom1.Name = "textBoxCustom1";
            this.textBoxCustom1.Padding = new System.Windows.Forms.Padding(7);
            this.textBoxCustom1.PasswordChar = false;
            this.textBoxCustom1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBoxCustom1.PlaceholderText = "";
            this.textBoxCustom1.Size = new System.Drawing.Size(380, 38);
            this.textBoxCustom1.TabIndex = 1;
            this.textBoxCustom1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxCustom1.Texts = "Lê Văn A";
            this.textBoxCustom1.UnderlinedStyle = true;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(569, 51);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên dịch vụ :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.cboDichVu, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.customButton2, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(578, 49);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.Size = new System.Drawing.Size(569, 45);
            this.tableLayoutPanel4.TabIndex = 5;
            // 
            // cboDichVu
            // 
            this.cboDichVu.BackColor = System.Drawing.Color.White;
            this.cboDichVu.BorderColor = System.Drawing.Color.LightGray;
            this.cboDichVu.BorderSize = 1;
            this.cboDichVu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboDichVu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDichVu.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDichVu.ForeColor = System.Drawing.Color.DimGray;
            this.cboDichVu.IconColor = System.Drawing.Color.Black;
            this.cboDichVu.Items.AddRange(new object[] {
            "1",
            "1",
            "1",
            "3",
            "4",
            "5",
            "2"});
            this.cboDichVu.ListBackColor = System.Drawing.Color.White;
            this.cboDichVu.ListTextColor = System.Drawing.Color.Black;
            this.cboDichVu.Location = new System.Drawing.Point(3, 3);
            this.cboDichVu.MinimumSize = new System.Drawing.Size(200, 30);
            this.cboDichVu.Name = "cboDichVu";
            this.cboDichVu.Padding = new System.Windows.Forms.Padding(1);
            this.cboDichVu.Size = new System.Drawing.Size(380, 41);
            this.cboDichVu.TabIndex = 0;
            this.cboDichVu.Texts = "";
            // 
            // customButton2
            // 
            this.customButton2.BackColor = System.Drawing.Color.White;
            this.customButton2.BackgroundColor = System.Drawing.Color.White;
            this.customButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customButton2.BorderRadius = 10;
            this.customButton2.BorderSize = 0;
            this.customButton2.Dock = System.Windows.Forms.DockStyle.Left;
            this.customButton2.FlatAppearance.BorderSize = 0;
            this.customButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton2.ForeColor = System.Drawing.Color.White;
            this.customButton2.Image = global::GUI.Properties.Resources.plus;
            this.customButton2.Location = new System.Drawing.Point(389, 3);
            this.customButton2.Name = "customButton2";
            this.customButton2.Size = new System.Drawing.Size(41, 41);
            this.customButton2.TabIndex = 1;
            this.customButton2.TextColor = System.Drawing.Color.White;
            this.customButton2.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(569, 45);
            this.label4.TabIndex = 6;
            this.label4.Text = "Chẩn đoán :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtChanDoan
            // 
            this.txtChanDoan.BorderColor = System.Drawing.Color.Black;
            this.txtChanDoan.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtChanDoan.BorderRadius = 0;
            this.txtChanDoan.BorderSize = 1;
            this.txtChanDoan.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtChanDoan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChanDoan.Location = new System.Drawing.Point(579, 101);
            this.txtChanDoan.Margin = new System.Windows.Forms.Padding(4);
            this.txtChanDoan.Multiline = false;
            this.txtChanDoan.Name = "txtChanDoan";
            this.txtChanDoan.Padding = new System.Windows.Forms.Padding(7);
            this.txtChanDoan.PasswordChar = false;
            this.txtChanDoan.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtChanDoan.PlaceholderText = "";
            this.txtChanDoan.Size = new System.Drawing.Size(380, 37);
            this.txtChanDoan.TabIndex = 7;
            this.txtChanDoan.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtChanDoan.Texts = "";
            this.txtChanDoan.UnderlinedStyle = true;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.Controls.Add(this.btnKeToa, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.btnToaThuoc, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(578, 145);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(569, 60);
            this.tableLayoutPanel5.TabIndex = 8;
            // 
            // btnKeToa
            // 
            this.btnKeToa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnKeToa.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnKeToa.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnKeToa.BorderRadius = 8;
            this.btnKeToa.BorderSize = 0;
            this.btnKeToa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnKeToa.FlatAppearance.BorderSize = 0;
            this.btnKeToa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKeToa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKeToa.ForeColor = System.Drawing.Color.White;
            this.btnKeToa.Location = new System.Drawing.Point(416, 3);
            this.btnKeToa.Name = "btnKeToa";
            this.btnKeToa.Size = new System.Drawing.Size(150, 54);
            this.btnKeToa.TabIndex = 0;
            this.btnKeToa.Text = "Lưu";
            this.btnKeToa.TextColor = System.Drawing.Color.White;
            this.btnKeToa.UseVisualStyleBackColor = false;
            // 
            // btnToaThuoc
            // 
            this.btnToaThuoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnToaThuoc.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnToaThuoc.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnToaThuoc.BorderRadius = 8;
            this.btnToaThuoc.BorderSize = 0;
            this.btnToaThuoc.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnToaThuoc.FlatAppearance.BorderSize = 0;
            this.btnToaThuoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToaThuoc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToaThuoc.ForeColor = System.Drawing.Color.White;
            this.btnToaThuoc.Location = new System.Drawing.Point(260, 3);
            this.btnToaThuoc.Name = "btnToaThuoc";
            this.btnToaThuoc.Size = new System.Drawing.Size(150, 54);
            this.btnToaThuoc.TabIndex = 1;
            this.btnToaThuoc.Text = "Kê toa";
            this.btnToaThuoc.TextColor = System.Drawing.Color.White;
            this.btnToaThuoc.UseVisualStyleBackColor = false;
            // 
            // frmKhamBenh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1482, 953);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmKhamBenh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmKhamBenh";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBenhNhan)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVu)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvBenhNhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENBN;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView dgvDichVu;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label2;
        private textBoxCustom textBoxCustom1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private CustomControls.RJControls.RJComboBox cboDichVu;
        private CustomButton customButton2;
        private System.Windows.Forms.Label label4;
        private textBoxCustom txtChanDoan;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private CustomButton btnKeToa;
        private CustomButton btnToaThuoc;
    }
}