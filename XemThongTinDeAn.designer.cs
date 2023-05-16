namespace NHANVIEN
{
    partial class frmXemThongTinDeAn
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
            this.dgvTTDeAn = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTTDeAn)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTTDeAn
            // 
            this.dgvTTDeAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTTDeAn.Location = new System.Drawing.Point(12, 12);
            this.dgvTTDeAn.Name = "dgvTTDeAn";
            this.dgvTTDeAn.RowHeadersWidth = 62;
            this.dgvTTDeAn.RowTemplate.Height = 28;
            this.dgvTTDeAn.Size = new System.Drawing.Size(776, 426);
            this.dgvTTDeAn.TabIndex = 0;
            // 
            // frmXemThongTinDeAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvTTDeAn);
            this.Name = "frmXemThongTinDeAn";
            this.Text = "XemThongTinDeAn";
            this.Load += new System.EventHandler(this.frmXemThongTinDeAn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTTDeAn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTTDeAn;
    }
}