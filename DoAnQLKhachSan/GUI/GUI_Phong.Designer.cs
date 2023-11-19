namespace GUI
{
    partial class GUI_Phong
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
            this.btnPhong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPhong
            // 
            this.btnPhong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPhong.Location = new System.Drawing.Point(0, 0);
            this.btnPhong.Name = "btnPhong";
            this.btnPhong.Size = new System.Drawing.Size(96, 63);
            this.btnPhong.TabIndex = 0;
            this.btnPhong.UseVisualStyleBackColor = true;
            // 
            // GUI_Phong
            // 
            this.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnPhong);
            this.Name = "GUI_Phong";
            this.Size = new System.Drawing.Size(96, 63);
            this.Load += new System.EventHandler(this.GUI_Phong_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPhong;
    }
}
