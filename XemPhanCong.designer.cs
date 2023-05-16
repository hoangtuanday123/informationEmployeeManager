namespace NHANVIEN
{
    partial class frmXemPC
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
            this.dgvXemPC = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXemPC)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvXemPC
            // 
            this.dgvXemPC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvXemPC.Location = new System.Drawing.Point(14, 13);
            this.dgvXemPC.Name = "dgvXemPC";
            this.dgvXemPC.RowHeadersWidth = 62;
            this.dgvXemPC.RowTemplate.Height = 28;
            this.dgvXemPC.Size = new System.Drawing.Size(793, 424);
            this.dgvXemPC.TabIndex = 0;
            // 
            // frmXemPC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 450);
            this.Controls.Add(this.dgvXemPC);
            this.Name = "frmXemPC";
            this.Text = "XemPhanCong";
            this.Load += new System.EventHandler(this.frmXemPC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvXemPC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvXemPC;
    }
}