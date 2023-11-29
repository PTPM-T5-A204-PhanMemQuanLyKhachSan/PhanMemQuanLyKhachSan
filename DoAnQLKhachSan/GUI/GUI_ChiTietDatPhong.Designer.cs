namespace GUI
{
    partial class GUI_ChiTietDatPhong
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
            this.txtTenPhong = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTaoKH = new System.Windows.Forms.Button();
            this.cbxKH = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtCCCD = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHoTenKH = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTamTinh = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnXoaDV = new System.Windows.Forms.Button();
            this.btnThemDV = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSoLg = new System.Windows.Forms.TextBox();
            this.cbxDichVu = new System.Windows.Forms.ComboBox();
            this.dgvDichVu = new System.Windows.Forms.DataGridView();
            this.txtGiaPhong = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dateCheckOut = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dateCheckIn = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDatPhong = new System.Windows.Forms.Button();
            this.btnNhanPhong = new System.Windows.Forms.Button();
            this.btnChuyenP = new System.Windows.Forms.Button();
            this.btnHuyDat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVu)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTenPhong
            // 
            this.txtTenPhong.AutoSize = true;
            this.txtTenPhong.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenPhong.Location = new System.Drawing.Point(250, 9);
            this.txtTenPhong.Name = "txtTenPhong";
            this.txtTenPhong.Size = new System.Drawing.Size(96, 21);
            this.txtTenPhong.TabIndex = 0;
            this.txtTenPhong.Text = "TenPhong";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTaoKH);
            this.groupBox1.Controls.Add(this.cbxKH);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.txtCCCD);
            this.groupBox1.Controls.Add(this.txtPhone);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtHoTenKH);
            this.groupBox1.Location = new System.Drawing.Point(12, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(560, 140);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khách hàng";
            // 
            // btnTaoKH
            // 
            this.btnTaoKH.Image = global::GUI.Properties.Resources.them;
            this.btnTaoKH.Location = new System.Drawing.Point(394, 82);
            this.btnTaoKH.Name = "btnTaoKH";
            this.btnTaoKH.Size = new System.Drawing.Size(78, 42);
            this.btnTaoKH.TabIndex = 9;
            this.btnTaoKH.UseVisualStyleBackColor = true;
            this.btnTaoKH.Click += new System.EventHandler(this.btnTaoKH_Click);
            // 
            // cbxKH
            // 
            this.cbxKH.FormattingEnabled = true;
            this.cbxKH.Location = new System.Drawing.Point(394, 47);
            this.cbxKH.Name = "cbxKH";
            this.cbxKH.Size = new System.Drawing.Size(157, 24);
            this.cbxKH.TabIndex = 8;
            this.cbxKH.SelectedIndexChanged += new System.EventHandler(this.cbxKH_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(391, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 16);
            this.label11.TabIndex = 7;
            this.label11.Text = "Chọn khách hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Địa chỉ";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(9, 101);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(197, 23);
            this.txtDiaChi.TabIndex = 5;
            // 
            // txtCCCD
            // 
            this.txtCCCD.Location = new System.Drawing.Point(231, 101);
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.Size = new System.Drawing.Size(140, 23);
            this.txtCCCD.TabIndex = 5;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(231, 47);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(140, 23);
            this.txtPhone.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(228, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "CCCD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(228, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Điện thoại";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Họ và tên";
            // 
            // txtHoTenKH
            // 
            this.txtHoTenKH.Location = new System.Drawing.Point(6, 47);
            this.txtHoTenKH.Name = "txtHoTenKH";
            this.txtHoTenKH.Size = new System.Drawing.Size(200, 23);
            this.txtHoTenKH.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtTamTinh);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.dgvDichVu);
            this.groupBox2.Controls.Add(this.txtGiaPhong);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.dateCheckOut);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.dateCheckIn);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(12, 197);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(560, 322);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết đặt phòng";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(334, 262);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 16);
            this.label10.TabIndex = 10;
            this.label10.Text = "Tạm tính";
            // 
            // txtTamTinh
            // 
            this.txtTamTinh.Location = new System.Drawing.Point(334, 284);
            this.txtTamTinh.Name = "txtTamTinh";
            this.txtTamTinh.ReadOnly = true;
            this.txtTamTinh.Size = new System.Drawing.Size(217, 23);
            this.txtTamTinh.TabIndex = 9;
            this.txtTamTinh.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.btnXoaDV);
            this.groupBox3.Controls.Add(this.btnThemDV);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtSoLg);
            this.groupBox3.Controls.Add(this.cbxDichVu);
            this.groupBox3.Location = new System.Drawing.Point(334, 92);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(217, 156);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sử dụng dịch vụ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 16);
            this.label9.TabIndex = 5;
            this.label9.Text = "Tên dịch vụ";
            // 
            // btnXoaDV
            // 
            this.btnXoaDV.Image = global::GUI.Properties.Resources.xoa;
            this.btnXoaDV.Location = new System.Drawing.Point(149, 92);
            this.btnXoaDV.Name = "btnXoaDV";
            this.btnXoaDV.Size = new System.Drawing.Size(55, 44);
            this.btnXoaDV.TabIndex = 4;
            this.btnXoaDV.UseVisualStyleBackColor = true;
            this.btnXoaDV.Click += new System.EventHandler(this.btnXoaDV_Click);
            // 
            // btnThemDV
            // 
            this.btnThemDV.Image = global::GUI.Properties.Resources.them;
            this.btnThemDV.Location = new System.Drawing.Point(88, 92);
            this.btnThemDV.Name = "btnThemDV";
            this.btnThemDV.Size = new System.Drawing.Size(55, 44);
            this.btnThemDV.TabIndex = 3;
            this.btnThemDV.UseVisualStyleBackColor = true;
            this.btnThemDV.Click += new System.EventHandler(this.btnThemDV_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 16);
            this.label8.TabIndex = 2;
            this.label8.Text = "Số lượng";
            // 
            // txtSoLg
            // 
            this.txtSoLg.Location = new System.Drawing.Point(9, 111);
            this.txtSoLg.Name = "txtSoLg";
            this.txtSoLg.Size = new System.Drawing.Size(58, 23);
            this.txtSoLg.TabIndex = 1;
            this.txtSoLg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSoLg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoLg_KeyPress);
            // 
            // cbxDichVu
            // 
            this.cbxDichVu.FormattingEnabled = true;
            this.cbxDichVu.Location = new System.Drawing.Point(6, 50);
            this.cbxDichVu.Name = "cbxDichVu";
            this.cbxDichVu.Size = new System.Drawing.Size(198, 24);
            this.cbxDichVu.TabIndex = 0;
            // 
            // dgvDichVu
            // 
            this.dgvDichVu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDichVu.Location = new System.Drawing.Point(9, 92);
            this.dgvDichVu.Name = "dgvDichVu";
            this.dgvDichVu.RowHeadersWidth = 51;
            this.dgvDichVu.RowTemplate.Height = 24;
            this.dgvDichVu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDichVu.Size = new System.Drawing.Size(309, 215);
            this.dgvDichVu.TabIndex = 6;
            // 
            // txtGiaPhong
            // 
            this.txtGiaPhong.Location = new System.Drawing.Point(411, 48);
            this.txtGiaPhong.Name = "txtGiaPhong";
            this.txtGiaPhong.ReadOnly = true;
            this.txtGiaPhong.Size = new System.Drawing.Size(140, 23);
            this.txtGiaPhong.TabIndex = 5;
            this.txtGiaPhong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(408, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "Giá phòng";
            // 
            // dateCheckOut
            // 
            this.dateCheckOut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateCheckOut.Location = new System.Drawing.Point(218, 48);
            this.dateCheckOut.Name = "dateCheckOut";
            this.dateCheckOut.Size = new System.Drawing.Size(140, 23);
            this.dateCheckOut.TabIndex = 3;
            this.dateCheckOut.ValueChanged += new System.EventHandler(this.dateCheckOut_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(215, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Check-out";
            // 
            // dateCheckIn
            // 
            this.dateCheckIn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateCheckIn.Location = new System.Drawing.Point(14, 48);
            this.dateCheckIn.Name = "dateCheckIn";
            this.dateCheckIn.Size = new System.Drawing.Size(140, 23);
            this.dateCheckIn.TabIndex = 1;
            this.dateCheckIn.ValueChanged += new System.EventHandler(this.dateCheckIn_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Check-in";
            // 
            // btnDatPhong
            // 
            this.btnDatPhong.Location = new System.Drawing.Point(466, 538);
            this.btnDatPhong.Name = "btnDatPhong";
            this.btnDatPhong.Size = new System.Drawing.Size(106, 44);
            this.btnDatPhong.TabIndex = 3;
            this.btnDatPhong.Text = "Đặt phòng";
            this.btnDatPhong.UseVisualStyleBackColor = true;
            this.btnDatPhong.Click += new System.EventHandler(this.btnDatPhong_Click);
            // 
            // btnNhanPhong
            // 
            this.btnNhanPhong.Location = new System.Drawing.Point(349, 538);
            this.btnNhanPhong.Name = "btnNhanPhong";
            this.btnNhanPhong.Size = new System.Drawing.Size(106, 44);
            this.btnNhanPhong.TabIndex = 3;
            this.btnNhanPhong.Text = "Nhận phòng";
            this.btnNhanPhong.UseVisualStyleBackColor = true;
            this.btnNhanPhong.Click += new System.EventHandler(this.btnNhanPhong_Click);
            // 
            // btnChuyenP
            // 
            this.btnChuyenP.Location = new System.Drawing.Point(12, 538);
            this.btnChuyenP.Name = "btnChuyenP";
            this.btnChuyenP.Size = new System.Drawing.Size(118, 44);
            this.btnChuyenP.TabIndex = 4;
            this.btnChuyenP.Text = "Chuyển phòng";
            this.btnChuyenP.UseVisualStyleBackColor = true;
            this.btnChuyenP.Click += new System.EventHandler(this.btnChuyenP_Click);
            // 
            // btnHuyDat
            // 
            this.btnHuyDat.Location = new System.Drawing.Point(136, 538);
            this.btnHuyDat.Name = "btnHuyDat";
            this.btnHuyDat.Size = new System.Drawing.Size(106, 44);
            this.btnHuyDat.TabIndex = 5;
            this.btnHuyDat.Text = "Hủy đặt";
            this.btnHuyDat.UseVisualStyleBackColor = true;
            this.btnHuyDat.Click += new System.EventHandler(this.btnHuyDat_Click);
            // 
            // GUI_ChiTietDatPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 594);
            this.Controls.Add(this.btnHuyDat);
            this.Controls.Add(this.btnChuyenP);
            this.Controls.Add(this.btnNhanPhong);
            this.Controls.Add(this.btnDatPhong);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtTenPhong);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "GUI_ChiTietDatPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChiTietDatPhong";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GUI_ChiTietDatPhong_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ChiTietDatPhong_FormClosed);
            this.Load += new System.EventHandler(this.ChiTietDatPhong_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtTenPhong;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHoTenKH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCCCD;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateCheckIn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateCheckOut;
        private System.Windows.Forms.TextBox txtGiaPhong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvDichVu;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbxDichVu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSoLg;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTamTinh;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnXoaDV;
        private System.Windows.Forms.Button btnThemDV;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Button btnDatPhong;
        private System.Windows.Forms.Button btnNhanPhong;
        private System.Windows.Forms.ComboBox cbxKH;
        private System.Windows.Forms.Button btnTaoKH;
        private System.Windows.Forms.Button btnChuyenP;
        private System.Windows.Forms.Button btnHuyDat;
    }
}