namespace AUDIT
{
    partial class frmCapNhatLPC
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
            this.dgvCapNhatLPC = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCapNhatLPC)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCapNhatLPC
            // 
            this.dgvCapNhatLPC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCapNhatLPC.Location = new System.Drawing.Point(12, 12);
            this.dgvCapNhatLPC.Name = "dgvCapNhatLPC";
            this.dgvCapNhatLPC.RowHeadersWidth = 62;
            this.dgvCapNhatLPC.RowTemplate.Height = 28;
            this.dgvCapNhatLPC.Size = new System.Drawing.Size(775, 426);
            this.dgvCapNhatLPC.TabIndex = 0;
            // 
            // frmCapNhatLPC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvCapNhatLPC);
            this.Name = "frmCapNhatLPC";
            this.Text = "NK Cập nhật lương, phụ cấp";
            this.Load += new System.EventHandler(this.frmCapNhatLPC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCapNhatLPC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCapNhatLPC;
    }
}