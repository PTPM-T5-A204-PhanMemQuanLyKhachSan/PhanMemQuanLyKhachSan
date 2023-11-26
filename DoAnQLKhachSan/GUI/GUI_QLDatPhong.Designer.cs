namespace GUI
{
    partial class GUI_QLDatPhong
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pnDSPhong = new System.Windows.Forms.Panel();
            this.btnTrong = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDangThue = new System.Windows.Forms.Button();
            this.btnDaDat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cboPhongCach = new System.Windows.Forms.ComboBox();
            this.cboTang = new System.Windows.Forms.ComboBox();
            this.cboBanCong = new System.Windows.Forms.ComboBox();
            this.cboSPA = new System.Windows.Forms.ComboBox();
            this.btnGoiY = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pnDSPhong);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 350);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1238, 410);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách phòng";
            // 
            // pnDSPhong
            // 
            this.pnDSPhong.AutoScroll = true;
            this.pnDSPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnDSPhong.Location = new System.Drawing.Point(3, 19);
            this.pnDSPhong.Name = "pnDSPhong";
            this.pnDSPhong.Size = new System.Drawing.Size(1232, 388);
            this.pnDSPhong.TabIndex = 0;
            // 
            // btnTrong
            // 
            this.btnTrong.Location = new System.Drawing.Point(12, 22);
            this.btnTrong.Name = "btnTrong";
            this.btnTrong.Size = new System.Drawing.Size(96, 63);
            this.btnTrong.TabIndex = 1;
            this.btnTrong.Text = "Trống";
            this.btnTrong.UseVisualStyleBackColor = true;
            this.btnTrong.Click += new System.EventHandler(this.btnTrong_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDangThue);
            this.groupBox2.Controls.Add(this.btnDaDat);
            this.groupBox2.Controls.Add(this.btnTrong);
            this.groupBox2.Location = new System.Drawing.Point(3, 246);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(326, 98);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Trạng thái phòng";
            // 
            // btnDangThue
            // 
            this.btnDangThue.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnDangThue.Location = new System.Drawing.Point(216, 22);
            this.btnDangThue.Name = "btnDangThue";
            this.btnDangThue.Size = new System.Drawing.Size(96, 63);
            this.btnDangThue.TabIndex = 1;
            this.btnDangThue.Text = "Đang thuê";
            this.btnDangThue.UseVisualStyleBackColor = false;
            this.btnDangThue.Click += new System.EventHandler(this.btnDangThue_Click);
            // 
            // btnDaDat
            // 
            this.btnDaDat.BackColor = System.Drawing.Color.Aquamarine;
            this.btnDaDat.Location = new System.Drawing.Point(114, 22);
            this.btnDaDat.Name = "btnDaDat";
            this.btnDaDat.Size = new System.Drawing.Size(96, 63);
            this.btnDaDat.TabIndex = 1;
            this.btnDaDat.Text = "Đã đặt";
            this.btnDaDat.UseVisualStyleBackColor = false;
            this.btnDaDat.Click += new System.EventHandler(this.btnDaDat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(535, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Quản lý đặt phòng";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(15, 202);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(162, 23);
            this.txtSDT.TabIndex = 4;
            this.txtSDT.TextChanged += new System.EventHandler(this.txtSDT_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Số điện thoại";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnGoiY);
            this.groupControl1.Controls.Add(this.cboTang);
            this.groupControl1.Controls.Add(this.cboSPA);
            this.groupControl1.Controls.Add(this.cboBanCong);
            this.groupControl1.Controls.Add(this.cboPhongCach);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Location = new System.Drawing.Point(415, 100);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(820, 244);
            this.groupControl1.TabIndex = 6;
            this.groupControl1.Text = "Gợi ý đặt phòng theo sở thích";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(244, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Phong cách trang trí phòng như thế nào ?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(282, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Bạn có quan trọng việc có ban công hay không ?";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(386, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(208, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Bạn thích tầng cao, giữa hay thấp ?";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(386, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(409, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Bạn có muốn sử dụng SPA, phòng GYM hoặc bể bơi khách sạn không ?";
            // 
            // cboPhongCach
            // 
            this.cboPhongCach.FormattingEnabled = true;
            this.cboPhongCach.Items.AddRange(new object[] {
            "Hiện đại",
            "Cổ điển",
            "Khác"});
            this.cboPhongCach.Location = new System.Drawing.Point(8, 62);
            this.cboPhongCach.Name = "cboPhongCach";
            this.cboPhongCach.Size = new System.Drawing.Size(241, 24);
            this.cboPhongCach.TabIndex = 2;
            // 
            // cboTang
            // 
            this.cboTang.FormattingEnabled = true;
            this.cboTang.Items.AddRange(new object[] {
            "Tầng cao",
            "Tầng giữa",
            "Tầng thấp"});
            this.cboTang.Location = new System.Drawing.Point(389, 62);
            this.cboTang.Name = "cboTang";
            this.cboTang.Size = new System.Drawing.Size(241, 24);
            this.cboTang.TabIndex = 2;
            // 
            // cboBanCong
            // 
            this.cboBanCong.FormattingEnabled = true;
            this.cboBanCong.Items.AddRange(new object[] {
            "Có",
            "Không"});
            this.cboBanCong.Location = new System.Drawing.Point(8, 146);
            this.cboBanCong.Name = "cboBanCong";
            this.cboBanCong.Size = new System.Drawing.Size(241, 24);
            this.cboBanCong.TabIndex = 2;
            // 
            // cboSPA
            // 
            this.cboSPA.FormattingEnabled = true;
            this.cboSPA.Items.AddRange(new object[] {
            "Có",
            "Không"});
            this.cboSPA.Location = new System.Drawing.Point(389, 146);
            this.cboSPA.Name = "cboSPA";
            this.cboSPA.Size = new System.Drawing.Size(241, 24);
            this.cboSPA.TabIndex = 2;
            // 
            // btnGoiY
            // 
            this.btnGoiY.Location = new System.Drawing.Point(673, 192);
            this.btnGoiY.Name = "btnGoiY";
            this.btnGoiY.Size = new System.Drawing.Size(107, 39);
            this.btnGoiY.TabIndex = 3;
            this.btnGoiY.Text = "Gợi Ý";
            this.btnGoiY.UseVisualStyleBackColor = true;
            this.btnGoiY.Click += new System.EventHandler(this.btnGoiY_Click);
            // 
            // GUI_QLDatPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "GUI_QLDatPhong";
            this.Size = new System.Drawing.Size(1238, 760);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel pnDSPhong;
        private System.Windows.Forms.Button btnTrong;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDangThue;
        private System.Windows.Forms.Button btnDaDat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGoiY;
        private System.Windows.Forms.ComboBox cboTang;
        private System.Windows.Forms.ComboBox cboSPA;
        private System.Windows.Forms.ComboBox cboBanCong;
        private System.Windows.Forms.ComboBox cboPhongCach;
    }
}
