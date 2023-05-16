namespace AUDIT
{
    partial class frmXemLuongPC
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
            this.dgvNKXemLPC = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNKXemLPC)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvNKXemLPC
            // 
            this.dgvNKXemLPC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNKXemLPC.Location = new System.Drawing.Point(10, 12);
            this.dgvNKXemLPC.Name = "dgvNKXemLPC";
            this.dgvNKXemLPC.RowHeadersWidth = 62;
            this.dgvNKXemLPC.RowTemplate.Height = 28;
            this.dgvNKXemLPC.Size = new System.Drawing.Size(778, 429);
            this.dgvNKXemLPC.TabIndex = 0;
            // 
            // frmXemLuongPC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvNKXemLPC);
            this.Name = "frmXemLuongPC";
            this.Text = "NK xem lương phụ cấp";
            this.Load += new System.EventHandler(this.frmXemLuongPC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNKXemLPC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNKXemLPC;
    }
}