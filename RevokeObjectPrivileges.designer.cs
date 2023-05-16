namespace RevokeObjectPrivileges
{
    partial class frmRevokeObjectPrivs
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
            this.dgvRevoke = new System.Windows.Forms.DataGridView();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.txtPrivs = new System.Windows.Forms.TextBox();
            this.cbbUserName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtObject = new System.Windows.Forms.TextBox();
            this.lblObject = new System.Windows.Forms.Label();
            this.btnViewPrivs = new System.Windows.Forms.Button();
            this.btnRevoke = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRevoke)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRevoke
            // 
            this.dgvRevoke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRevoke.Location = new System.Drawing.Point(526, 3);
            this.dgvRevoke.Name = "dgvRevoke";
            this.dgvRevoke.RowHeadersWidth = 62;
            this.dgvRevoke.RowTemplate.Height = 28;
            this.dgvRevoke.Size = new System.Drawing.Size(896, 605);
            this.dgvRevoke.TabIndex = 0;
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.Location = new System.Drawing.Point(5, 3);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(515, 109);
            this.lblTieuDe.TabIndex = 10;
            this.lblTieuDe.Text = "REVOKE OBJECT PRIVILEGES";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPrivs
            // 
            this.txtPrivs.Location = new System.Drawing.Point(175, 253);
            this.txtPrivs.Name = "txtPrivs";
            this.txtPrivs.Size = new System.Drawing.Size(298, 26);
            this.txtPrivs.TabIndex = 14;
            // 
            // cbbUserName
            // 
            this.cbbUserName.FormattingEnabled = true;
            this.cbbUserName.Location = new System.Drawing.Point(175, 161);
            this.cbbUserName.Name = "cbbUserName";
            this.cbbUserName.Size = new System.Drawing.Size(298, 28);
            this.cbbUserName.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "PRIVILEGES";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(20, 169);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(149, 20);
            this.lblUserName.TabIndex = 11;
            this.lblUserName.Text = "USERNAME/ROLE";
            // 
            // txtObject
            // 
            this.txtObject.Location = new System.Drawing.Point(175, 352);
            this.txtObject.Name = "txtObject";
            this.txtObject.Size = new System.Drawing.Size(298, 26);
            this.txtObject.TabIndex = 15;
            // 
            // lblObject
            // 
            this.lblObject.AutoSize = true;
            this.lblObject.Location = new System.Drawing.Point(48, 358);
            this.lblObject.Name = "lblObject";
            this.lblObject.Size = new System.Drawing.Size(121, 20);
            this.lblObject.TabIndex = 16;
            this.lblObject.Text = "OBJECT NAME";
            // 
            // btnViewPrivs
            // 
            this.btnViewPrivs.Location = new System.Drawing.Point(290, 437);
            this.btnViewPrivs.Name = "btnViewPrivs";
            this.btnViewPrivs.Size = new System.Drawing.Size(183, 62);
            this.btnViewPrivs.TabIndex = 18;
            this.btnViewPrivs.Text = "VIEW PRIVILEGES";
            this.btnViewPrivs.UseVisualStyleBackColor = true;
            this.btnViewPrivs.Click += new System.EventHandler(this.btnViewPrivs_Click);
            // 
            // btnRevoke
            // 
            this.btnRevoke.Location = new System.Drawing.Point(38, 437);
            this.btnRevoke.Name = "btnRevoke";
            this.btnRevoke.Size = new System.Drawing.Size(183, 62);
            this.btnRevoke.TabIndex = 17;
            this.btnRevoke.Text = "REVOKE PRIVILEGES";
            this.btnRevoke.UseVisualStyleBackColor = true;
            this.btnRevoke.Click += new System.EventHandler(this.btnRevoke_Click);
            // 
            // frmRevokeObjectPrivs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1426, 609);
            this.Controls.Add(this.btnViewPrivs);
            this.Controls.Add(this.btnRevoke);
            this.Controls.Add(this.lblObject);
            this.Controls.Add(this.txtObject);
            this.Controls.Add(this.txtPrivs);
            this.Controls.Add(this.cbbUserName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.dgvRevoke);
            this.Name = "frmRevokeObjectPrivs";
            this.Text = "RevokeObjectPrivileges";
            this.Load += new System.EventHandler(this.frmRevokeObjectPrivs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRevoke)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRevoke;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.TextBox txtPrivs;
        private System.Windows.Forms.ComboBox cbbUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtObject;
        private System.Windows.Forms.Label lblObject;
        private System.Windows.Forms.Button btnViewPrivs;
        private System.Windows.Forms.Button btnRevoke;
    }
}

