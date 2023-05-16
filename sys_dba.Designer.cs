namespace PHANHE1
{
    partial class sys_dba
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbluser = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.btnlistuser = new System.Windows.Forms.Button();
            this.gblistuser = new System.Windows.Forms.GroupBox();
            this.dgvlistuser = new System.Windows.Forms.DataGridView();
            this.btnprivileges = new System.Windows.Forms.Button();
            this.gbprivileges = new System.Windows.Forms.GroupBox();
            this.gbprirole = new System.Windows.Forms.GroupBox();
            this.btnrolesearch = new System.Windows.Forms.Button();
            this.dgvprirole = new System.Windows.Forms.DataGridView();
            this.btnpriuser = new System.Windows.Forms.Button();
            this.cbseach = new System.Windows.Forms.ComboBox();
            this.gbpriuser = new System.Windows.Forms.GroupBox();
            this.btnsearch = new System.Windows.Forms.Button();
            this.dgvusercolumn = new System.Windows.Forms.DataGridView();
            this.dgvusertable = new System.Windows.Forms.DataGridView();
            this.btnprirole = new System.Windows.Forms.Button();
            this.btnupdateuserrole = new System.Windows.Forms.Button();
            this.btnGrantPrivileges = new System.Windows.Forms.Button();
            this.btncreatealterdrop = new System.Windows.Forms.Button();
            this.btnRevokeObjectPrivileges = new System.Windows.Forms.Button();
            this.btnRevokeSystemPrivileges = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.gblistuser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlistuser)).BeginInit();
            this.gbprivileges.SuspendLayout();
            this.gbprirole.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvprirole)).BeginInit();
            this.gbpriuser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvusercolumn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvusertable)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.lbluser);
            this.groupBox1.Controls.Add(this.lbl);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Location = new System.Drawing.Point(0, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1002, 71);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // lbluser
            // 
            this.lbluser.AutoSize = true;
            this.lbluser.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluser.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbluser.Location = new System.Drawing.Point(140, 18);
            this.lbluser.Name = "lbluser";
            this.lbluser.Size = new System.Drawing.Size(109, 39);
            this.lbluser.TabIndex = 1;
            this.lbluser.Text = "label1";
            this.lbluser.Click += new System.EventHandler(this.lbluser_Click);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl.Location = new System.Drawing.Point(12, 18);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(122, 39);
            this.lbl.TabIndex = 0;
            this.lbl.Text = "USER:";
            // 
            // btnlistuser
            // 
            this.btnlistuser.Location = new System.Drawing.Point(0, 79);
            this.btnlistuser.Name = "btnlistuser";
            this.btnlistuser.Size = new System.Drawing.Size(134, 48);
            this.btnlistuser.TabIndex = 1;
            this.btnlistuser.Text = "list user";
            this.btnlistuser.UseVisualStyleBackColor = true;
            this.btnlistuser.Click += new System.EventHandler(this.btnlistuser_Click);
            // 
            // gblistuser
            // 
            this.gblistuser.Controls.Add(this.dgvlistuser);
            this.gblistuser.Location = new System.Drawing.Point(174, 101);
            this.gblistuser.Name = "gblistuser";
            this.gblistuser.Size = new System.Drawing.Size(762, 346);
            this.gblistuser.TabIndex = 2;
            this.gblistuser.TabStop = false;
            // 
            // dgvlistuser
            // 
            this.dgvlistuser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvlistuser.Location = new System.Drawing.Point(17, 15);
            this.dgvlistuser.Name = "dgvlistuser";
            this.dgvlistuser.RowHeadersWidth = 51;
            this.dgvlistuser.RowTemplate.Height = 24;
            this.dgvlistuser.Size = new System.Drawing.Size(781, 316);
            this.dgvlistuser.TabIndex = 0;
            // 
            // btnprivileges
            // 
            this.btnprivileges.Location = new System.Drawing.Point(0, 133);
            this.btnprivileges.Name = "btnprivileges";
            this.btnprivileges.Size = new System.Drawing.Size(134, 48);
            this.btnprivileges.TabIndex = 3;
            this.btnprivileges.Text = "select privileges";
            this.btnprivileges.UseVisualStyleBackColor = true;
            this.btnprivileges.Click += new System.EventHandler(this.btnprivileges_Click);
            // 
            // gbprivileges
            // 
            this.gbprivileges.Controls.Add(this.gbprirole);
            this.gbprivileges.Controls.Add(this.btnpriuser);
            this.gbprivileges.Controls.Add(this.cbseach);
            this.gbprivileges.Controls.Add(this.gbpriuser);
            this.gbprivileges.Controls.Add(this.btnprirole);
            this.gbprivileges.Location = new System.Drawing.Point(147, 79);
            this.gbprivileges.Name = "gbprivileges";
            this.gbprivileges.Size = new System.Drawing.Size(847, 375);
            this.gbprivileges.TabIndex = 4;
            this.gbprivileges.TabStop = false;
            // 
            // gbprirole
            // 
            this.gbprirole.Controls.Add(this.btnrolesearch);
            this.gbprirole.Controls.Add(this.dgvprirole);
            this.gbprirole.Location = new System.Drawing.Point(0, 69);
            this.gbprirole.Name = "gbprirole";
            this.gbprirole.Size = new System.Drawing.Size(847, 315);
            this.gbprirole.TabIndex = 3;
            this.gbprirole.TabStop = false;
            // 
            // btnrolesearch
            // 
            this.btnrolesearch.Location = new System.Drawing.Point(335, 243);
            this.btnrolesearch.Name = "btnrolesearch";
            this.btnrolesearch.Size = new System.Drawing.Size(128, 44);
            this.btnrolesearch.TabIndex = 1;
            this.btnrolesearch.Text = "search";
            this.btnrolesearch.UseVisualStyleBackColor = true;
            this.btnrolesearch.Click += new System.EventHandler(this.btnrolesearch_Click);
            // 
            // dgvprirole
            // 
            this.dgvprirole.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvprirole.Location = new System.Drawing.Point(6, 0);
            this.dgvprirole.Name = "dgvprirole";
            this.dgvprirole.RowHeadersWidth = 51;
            this.dgvprirole.RowTemplate.Height = 24;
            this.dgvprirole.Size = new System.Drawing.Size(835, 218);
            this.dgvprirole.TabIndex = 0;
            // 
            // btnpriuser
            // 
            this.btnpriuser.Location = new System.Drawing.Point(6, 15);
            this.btnpriuser.Name = "btnpriuser";
            this.btnpriuser.Size = new System.Drawing.Size(246, 48);
            this.btnpriuser.TabIndex = 0;
            this.btnpriuser.Text = "user";
            this.btnpriuser.UseVisualStyleBackColor = true;
            this.btnpriuser.Click += new System.EventHandler(this.btnpriuser_Click);
            // 
            // cbseach
            // 
            this.cbseach.FormattingEnabled = true;
            this.cbseach.Location = new System.Drawing.Point(504, 21);
            this.cbseach.Name = "cbseach";
            this.cbseach.Size = new System.Drawing.Size(301, 24);
            this.cbseach.TabIndex = 3;
            this.cbseach.Text = "search user/role";
            // 
            // gbpriuser
            // 
            this.gbpriuser.Controls.Add(this.btnsearch);
            this.gbpriuser.Controls.Add(this.dgvusercolumn);
            this.gbpriuser.Controls.Add(this.dgvusertable);
            this.gbpriuser.Location = new System.Drawing.Point(4, 69);
            this.gbpriuser.Name = "gbpriuser";
            this.gbpriuser.Size = new System.Drawing.Size(828, 315);
            this.gbpriuser.TabIndex = 2;
            this.gbpriuser.TabStop = false;
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(383, 256);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(97, 31);
            this.btnsearch.TabIndex = 2;
            this.btnsearch.Text = "search";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // dgvusercolumn
            // 
            this.dgvusercolumn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvusercolumn.Location = new System.Drawing.Point(432, 11);
            this.dgvusercolumn.Name = "dgvusercolumn";
            this.dgvusercolumn.RowHeadersWidth = 51;
            this.dgvusercolumn.RowTemplate.Height = 24;
            this.dgvusercolumn.Size = new System.Drawing.Size(390, 230);
            this.dgvusercolumn.TabIndex = 1;
            // 
            // dgvusertable
            // 
            this.dgvusertable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvusertable.Location = new System.Drawing.Point(3, 11);
            this.dgvusertable.Name = "dgvusertable";
            this.dgvusertable.RowHeadersWidth = 51;
            this.dgvusertable.RowTemplate.Height = 24;
            this.dgvusertable.Size = new System.Drawing.Size(390, 230);
            this.dgvusertable.TabIndex = 0;
            // 
            // btnprirole
            // 
            this.btnprirole.Location = new System.Drawing.Point(252, 15);
            this.btnprirole.Name = "btnprirole";
            this.btnprirole.Size = new System.Drawing.Size(246, 48);
            this.btnprirole.TabIndex = 1;
            this.btnprirole.Text = "role";
            this.btnprirole.UseVisualStyleBackColor = true;
            this.btnprirole.Click += new System.EventHandler(this.btnprirole_Click);
            // 
            // btnupdateuserrole
            // 
            this.btnupdateuserrole.Location = new System.Drawing.Point(0, 187);
            this.btnupdateuserrole.Name = "btnupdateuserrole";
            this.btnupdateuserrole.Size = new System.Drawing.Size(134, 48);
            this.btnupdateuserrole.TabIndex = 5;
            this.btnupdateuserrole.Text = "update_user/role";
            this.btnupdateuserrole.UseVisualStyleBackColor = true;
            this.btnupdateuserrole.Click += new System.EventHandler(this.btnupdateuserrole_Click);
            // 
            // btnGrantPrivileges
            // 
            this.btnGrantPrivileges.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnGrantPrivileges.Location = new System.Drawing.Point(0, 241);
            this.btnGrantPrivileges.Name = "btnGrantPrivileges";
            this.btnGrantPrivileges.Size = new System.Drawing.Size(134, 48);
            this.btnGrantPrivileges.TabIndex = 7;
            this.btnGrantPrivileges.Text = "Grant Privileges";
            this.btnGrantPrivileges.UseVisualStyleBackColor = true;
            this.btnGrantPrivileges.Click += new System.EventHandler(this.btnGrantPrivileges_Click);
            // 
            // btncreatealterdrop
            // 
            this.btncreatealterdrop.Location = new System.Drawing.Point(0, 295);
            this.btncreatealterdrop.Name = "btncreatealterdrop";
            this.btncreatealterdrop.Size = new System.Drawing.Size(134, 48);
            this.btncreatealterdrop.TabIndex = 8;
            this.btncreatealterdrop.Text = "CreateAlterDrop";
            this.btncreatealterdrop.UseVisualStyleBackColor = true;
            this.btncreatealterdrop.Click += new System.EventHandler(this.btncreatealterdrop_Click);
            // 
            // btnRevokeObjectPrivileges
            // 
            this.btnRevokeObjectPrivileges.Location = new System.Drawing.Point(0, 349);
            this.btnRevokeObjectPrivileges.Name = "btnRevokeObjectPrivileges";
            this.btnRevokeObjectPrivileges.Size = new System.Drawing.Size(134, 48);
            this.btnRevokeObjectPrivileges.TabIndex = 9;
            this.btnRevokeObjectPrivileges.Text = "RevokeObjectPrivileges";
            this.btnRevokeObjectPrivileges.UseVisualStyleBackColor = true;
            this.btnRevokeObjectPrivileges.Click += new System.EventHandler(this.btnRevokeObjectPrivileges_Click);
            // 
            // btnRevokeSystemPrivileges
            // 
            this.btnRevokeSystemPrivileges.Location = new System.Drawing.Point(0, 404);
            this.btnRevokeSystemPrivileges.Name = "btnRevokeSystemPrivileges";
            this.btnRevokeSystemPrivileges.Size = new System.Drawing.Size(134, 48);
            this.btnRevokeSystemPrivileges.TabIndex = 10;
            this.btnRevokeSystemPrivileges.Text = "RevokeSystemPrivileges";
            this.btnRevokeSystemPrivileges.UseVisualStyleBackColor = true;
            this.btnRevokeSystemPrivileges.Click += new System.EventHandler(this.btnRevokeSystemPrivileges_Click);
            // 
            // sys_dba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1014, 479);
            this.Controls.Add(this.btnRevokeSystemPrivileges);
            this.Controls.Add(this.btnRevokeObjectPrivileges);
            this.Controls.Add(this.btncreatealterdrop);
            this.Controls.Add(this.btnGrantPrivileges);
            this.Controls.Add(this.btnupdateuserrole);
            this.Controls.Add(this.gbprivileges);
            this.Controls.Add(this.btnprivileges);
            this.Controls.Add(this.gblistuser);
            this.Controls.Add(this.btnlistuser);
            this.Controls.Add(this.groupBox1);
            this.Name = "sys_dba";
            this.Text = "sys_dba";
            this.Load += new System.EventHandler(this.sys_dba_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gblistuser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvlistuser)).EndInit();
            this.gbprivileges.ResumeLayout(false);
            this.gbprirole.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvprirole)).EndInit();
            this.gbpriuser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvusercolumn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvusertable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbluser;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Button btnlistuser;
        private System.Windows.Forms.GroupBox gblistuser;
        private System.Windows.Forms.DataGridView dgvlistuser;
        private System.Windows.Forms.Button btnprivileges;
        private System.Windows.Forms.GroupBox gbprivileges;
        private System.Windows.Forms.ComboBox cbseach;
        private System.Windows.Forms.GroupBox gbpriuser;
        private System.Windows.Forms.Button btnprirole;
        private System.Windows.Forms.Button btnpriuser;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.DataGridView dgvusercolumn;
        private System.Windows.Forms.DataGridView dgvusertable;
        private System.Windows.Forms.GroupBox gbprirole;
        private System.Windows.Forms.Button btnrolesearch;
        private System.Windows.Forms.DataGridView dgvprirole;
        private System.Windows.Forms.Button btnupdateuserrole;
        private System.Windows.Forms.Button btnGrantPrivileges;
        private System.Windows.Forms.Button btncreatealterdrop;
        private System.Windows.Forms.Button btnRevokeObjectPrivileges;
        private System.Windows.Forms.Button btnRevokeSystemPrivileges;
    }
}