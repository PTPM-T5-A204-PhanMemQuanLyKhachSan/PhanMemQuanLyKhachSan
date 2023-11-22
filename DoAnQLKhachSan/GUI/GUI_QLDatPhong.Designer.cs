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
            this.btnDaDat = new System.Windows.Forms.Button();
            this.btnDangThue = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.txtSDT.Location = new System.Drawing.Point(734, 268);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(162, 23);
            this.txtSDT.TabIndex = 4;
            this.txtSDT.TextChanged += new System.EventHandler(this.txtSDT_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(731, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Số điện thoại";
            // 
            // GUI_QLDatPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "GUI_QLDatPhong";
            this.Size = new System.Drawing.Size(1238, 760);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
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
    }
}
