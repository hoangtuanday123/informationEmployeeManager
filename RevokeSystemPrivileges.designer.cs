namespace RevokeSystemPrivileges
{
    partial class frmRevoke
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
            this.btnRevoke = new System.Windows.Forms.Button();
            this.lblUserName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbUserName = new System.Windows.Forms.ComboBox();
            this.txtPrivs = new System.Windows.Forms.TextBox();
            this.dgvPrivs = new System.Windows.Forms.DataGridView();
            this.btnViewPrivs = new System.Windows.Forms.Button();
            this.lblTieuDe = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrivs)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRevoke
            // 
            this.btnRevoke.Location = new System.Drawing.Point(47, 318);
            this.btnRevoke.Name = "btnRevoke";
            this.btnRevoke.Size = new System.Drawing.Size(183, 62);
            this.btnRevoke.TabIndex = 0;
            this.btnRevoke.Text = "REVOKE PRIVILEGES";
            this.btnRevoke.UseVisualStyleBackColor = true;
            this.btnRevoke.Click += new System.EventHandler(this.btnRevoke_Click);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(43, 164);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(101, 20);
            this.lblUserName.TabIndex = 3;
            this.lblUserName.Text = "USERNAME";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "PRIVILEGES";
            // 
            // cbbUserName
            // 
            this.cbbUserName.FormattingEnabled = true;
            this.cbbUserName.Location = new System.Drawing.Point(183, 156);
            this.cbbUserName.Name = "cbbUserName";
            this.cbbUserName.Size = new System.Drawing.Size(298, 28);
            this.cbbUserName.TabIndex = 5;
            this.cbbUserName.SelectedIndexChanged += new System.EventHandler(this.cbbUserName_SelectedIndexChanged);
            // 
            // txtPrivs
            // 
            this.txtPrivs.Location = new System.Drawing.Point(183, 248);
            this.txtPrivs.Name = "txtPrivs";
            this.txtPrivs.Size = new System.Drawing.Size(298, 26);
            this.txtPrivs.TabIndex = 6;
            // 
            // dgvPrivs
            // 
            this.dgvPrivs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrivs.Location = new System.Drawing.Point(526, 4);
            this.dgvPrivs.Name = "dgvPrivs";
            this.dgvPrivs.RowHeadersWidth = 62;
            this.dgvPrivs.RowTemplate.Height = 28;
            this.dgvPrivs.Size = new System.Drawing.Size(756, 601);
            this.dgvPrivs.TabIndex = 7;
            // 
            // btnViewPrivs
            // 
            this.btnViewPrivs.Location = new System.Drawing.Point(298, 318);
            this.btnViewPrivs.Name = "btnViewPrivs";
            this.btnViewPrivs.Size = new System.Drawing.Size(183, 62);
            this.btnViewPrivs.TabIndex = 8;
            this.btnViewPrivs.Text = "VIEW PRIVILEGES";
            this.btnViewPrivs.UseVisualStyleBackColor = true;
            this.btnViewPrivs.Click += new System.EventHandler(this.btnViewPrivs_Click);
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.Location = new System.Drawing.Point(5, 4);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(515, 109);
            this.lblTieuDe.TabIndex = 9;
            this.lblTieuDe.Text = "REVOKE SYSTEM PRIVILEGES";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmRevoke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1285, 609);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.btnViewPrivs);
            this.Controls.Add(this.dgvPrivs);
            this.Controls.Add(this.txtPrivs);
            this.Controls.Add(this.cbbUserName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.btnRevoke);
            this.Name = "frmRevoke";
            this.Text = "Revoke System Privilege";
            this.Load += new System.EventHandler(this.frmRevoke_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrivs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRevoke;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbUserName;
        private System.Windows.Forms.TextBox txtPrivs;
        private System.Windows.Forms.DataGridView dgvPrivs;
        private System.Windows.Forms.Button btnViewPrivs;
        private System.Windows.Forms.Label lblTieuDe;
    }
}

