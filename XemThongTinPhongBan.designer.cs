namespace NHANVIEN
{
    partial class frmXemTTPB
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
            this.dgvTTBP = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTTBP)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTTBP
            // 
            this.dgvTTBP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTTBP.Location = new System.Drawing.Point(12, 12);
            this.dgvTTBP.Name = "dgvTTBP";
            this.dgvTTBP.RowHeadersWidth = 62;
            this.dgvTTBP.RowTemplate.Height = 28;
            this.dgvTTBP.Size = new System.Drawing.Size(565, 426);
            this.dgvTTBP.TabIndex = 0;
            // 
            // frmXemTTPB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 450);
            this.Controls.Add(this.dgvTTBP);
            this.Name = "frmXemTTPB";
            this.Text = "XemThongTinPhongBan";
            this.Load += new System.EventHandler(this.frmXemTTPB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTTBP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTTBP;
    }
}