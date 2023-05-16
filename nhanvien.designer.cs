namespace NHANVIEN
{
    partial class frmNhanVien
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
            this.btnXemTTCaNhan = new System.Windows.Forms.Button();
            this.btnXemPhanCong = new System.Windows.Forms.Button();
            this.btnCapNhatTTCaNhan = new System.Windows.Forms.Button();
            this.btnXemTTPB = new System.Windows.Forms.Button();
            this.btnXemTTDeAn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnXemTTCaNhan
            // 
            this.btnXemTTCaNhan.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnXemTTCaNhan.Location = new System.Drawing.Point(140, 415);
            this.btnXemTTCaNhan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXemTTCaNhan.Name = "btnXemTTCaNhan";
            this.btnXemTTCaNhan.Size = new System.Drawing.Size(189, 62);
            this.btnXemTTCaNhan.TabIndex = 0;
            this.btnXemTTCaNhan.Text = "Xem thông tin cá nhân";
            this.btnXemTTCaNhan.UseVisualStyleBackColor = false;
            this.btnXemTTCaNhan.Click += new System.EventHandler(this.btnXemTTCaNhan_Click);
            // 
            // btnXemPhanCong
            // 
            this.btnXemPhanCong.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnXemPhanCong.Location = new System.Drawing.Point(140, 320);
            this.btnXemPhanCong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXemPhanCong.Name = "btnXemPhanCong";
            this.btnXemPhanCong.Size = new System.Drawing.Size(189, 62);
            this.btnXemPhanCong.TabIndex = 1;
            this.btnXemPhanCong.Text = "Xem phân công";
            this.btnXemPhanCong.UseVisualStyleBackColor = false;
            this.btnXemPhanCong.Click += new System.EventHandler(this.btnXemPhanCong_Click);
            // 
            // btnCapNhatTTCaNhan
            // 
            this.btnCapNhatTTCaNhan.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnCapNhatTTCaNhan.Location = new System.Drawing.Point(140, 230);
            this.btnCapNhatTTCaNhan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCapNhatTTCaNhan.Name = "btnCapNhatTTCaNhan";
            this.btnCapNhatTTCaNhan.Size = new System.Drawing.Size(189, 62);
            this.btnCapNhatTTCaNhan.TabIndex = 2;
            this.btnCapNhatTTCaNhan.Text = "Cập nhật thông tin cá nhân";
            this.btnCapNhatTTCaNhan.UseVisualStyleBackColor = false;
            this.btnCapNhatTTCaNhan.Click += new System.EventHandler(this.btnCapNhatTTCaNhan_Click);
            // 
            // btnXemTTPB
            // 
            this.btnXemTTPB.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnXemTTPB.Location = new System.Drawing.Point(140, 138);
            this.btnXemTTPB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXemTTPB.Name = "btnXemTTPB";
            this.btnXemTTPB.Size = new System.Drawing.Size(189, 62);
            this.btnXemTTPB.TabIndex = 3;
            this.btnXemTTPB.Text = "Xem thông tin phòng ban";
            this.btnXemTTPB.UseVisualStyleBackColor = false;
            this.btnXemTTPB.Click += new System.EventHandler(this.btnXemTTPB_Click);
            // 
            // btnXemTTDeAn
            // 
            this.btnXemTTDeAn.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnXemTTDeAn.Location = new System.Drawing.Point(140, 44);
            this.btnXemTTDeAn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXemTTDeAn.Name = "btnXemTTDeAn";
            this.btnXemTTDeAn.Size = new System.Drawing.Size(189, 62);
            this.btnXemTTDeAn.TabIndex = 4;
            this.btnXemTTDeAn.Text = "Xem thông tin đề án";
            this.btnXemTTDeAn.UseVisualStyleBackColor = false;
            this.btnXemTTDeAn.Click += new System.EventHandler(this.btnXemTTDeAn_Click);
            // 
            // frmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 527);
            this.Controls.Add(this.btnXemTTDeAn);
            this.Controls.Add(this.btnXemTTPB);
            this.Controls.Add(this.btnCapNhatTTCaNhan);
            this.Controls.Add(this.btnXemPhanCong);
            this.Controls.Add(this.btnXemTTCaNhan);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmNhanVien";
            this.Text = "Nhân viên";
            this.Load += new System.EventHandler(this.frmNhanVien_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnXemTTCaNhan;
        private System.Windows.Forms.Button btnXemPhanCong;
        private System.Windows.Forms.Button btnCapNhatTTCaNhan;
        private System.Windows.Forms.Button btnXemTTPB;
        private System.Windows.Forms.Button btnXemTTDeAn;
    }
}

