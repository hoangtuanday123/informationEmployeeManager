namespace NHANVIEN
{
    partial class frmXemTTCN
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
            this.dgvTTCN = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTTCN)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTTCN
            // 
            this.dgvTTCN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTTCN.Location = new System.Drawing.Point(12, 12);
            this.dgvTTCN.Name = "dgvTTCN";
            this.dgvTTCN.RowHeadersWidth = 62;
            this.dgvTTCN.RowTemplate.Height = 28;
            this.dgvTTCN.Size = new System.Drawing.Size(775, 426);
            this.dgvTTCN.TabIndex = 0;
            // 
            // frmXemTTCN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvTTCN);
            this.Name = "frmXemTTCN";
            this.Text = "XemThongTinCaNhan";
            this.Load += new System.EventHandler(this.frmXemTTCN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTTCN)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTTCN;
    }
}