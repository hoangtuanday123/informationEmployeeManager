namespace AUDIT
{
    partial class frmCapNhatThoiGian
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
            this.dgvNKCapNhatTG = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNKCapNhatTG)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvNKCapNhatTG
            // 
            this.dgvNKCapNhatTG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNKCapNhatTG.Location = new System.Drawing.Point(12, 12);
            this.dgvNKCapNhatTG.Name = "dgvNKCapNhatTG";
            this.dgvNKCapNhatTG.RowHeadersWidth = 62;
            this.dgvNKCapNhatTG.RowTemplate.Height = 28;
            this.dgvNKCapNhatTG.Size = new System.Drawing.Size(776, 426);
            this.dgvNKCapNhatTG.TabIndex = 0;
            // 
            // frmCapNhatThoiGian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvNKCapNhatTG);
            this.Name = "frmCapNhatThoiGian";
            this.Text = "NK Cập nhật thời gian";
            this.Load += new System.EventHandler(this.frmCapNhatThoiGian_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNKCapNhatTG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNKCapNhatTG;
    }
}