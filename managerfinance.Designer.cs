
namespace PHANHE1
{
    partial class managerfinance
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
            this.btn_key = new System.Windows.Forms.Button();
            this.btn_auditlogkey = new System.Windows.Forms.Button();
            this.gbkey = new System.Windows.Forms.GroupBox();
            this.dgvkey = new System.Windows.Forms.DataGridView();
            this.gbauditlog = new System.Windows.Forms.GroupBox();
            this.dgvauditfga = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvauditlog = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtchangekey = new System.Windows.Forms.TextBox();
            this.btnchangekey = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.gbkey.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvkey)).BeginInit();
            this.gbauditlog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvauditfga)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvauditlog)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_key
            // 
            this.btn_key.Location = new System.Drawing.Point(13, 13);
            this.btn_key.Name = "btn_key";
            this.btn_key.Size = new System.Drawing.Size(121, 47);
            this.btn_key.TabIndex = 0;
            this.btn_key.Text = "key";
            this.btn_key.UseVisualStyleBackColor = true;
            this.btn_key.Click += new System.EventHandler(this.btn_key_Click);
            // 
            // btn_auditlogkey
            // 
            this.btn_auditlogkey.Location = new System.Drawing.Point(140, 13);
            this.btn_auditlogkey.Name = "btn_auditlogkey";
            this.btn_auditlogkey.Size = new System.Drawing.Size(121, 47);
            this.btn_auditlogkey.TabIndex = 1;
            this.btn_auditlogkey.Text = "auditlogkey";
            this.btn_auditlogkey.UseVisualStyleBackColor = true;
            this.btn_auditlogkey.Click += new System.EventHandler(this.btn_auditlogkey_Click);
            // 
            // gbkey
            // 
            this.gbkey.Controls.Add(this.label3);
            this.gbkey.Controls.Add(this.btnchangekey);
            this.gbkey.Controls.Add(this.txtchangekey);
            this.gbkey.Controls.Add(this.dgvkey);
            this.gbkey.Location = new System.Drawing.Point(116, 142);
            this.gbkey.Name = "gbkey";
            this.gbkey.Size = new System.Drawing.Size(520, 233);
            this.gbkey.TabIndex = 2;
            this.gbkey.TabStop = false;
            // 
            // dgvkey
            // 
            this.dgvkey.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvkey.Location = new System.Drawing.Point(44, 21);
            this.dgvkey.Name = "dgvkey";
            this.dgvkey.RowHeadersWidth = 51;
            this.dgvkey.RowTemplate.Height = 24;
            this.dgvkey.Size = new System.Drawing.Size(180, 194);
            this.dgvkey.TabIndex = 0;
            // 
            // gbauditlog
            // 
            this.gbauditlog.Controls.Add(this.dgvauditfga);
            this.gbauditlog.Controls.Add(this.label2);
            this.gbauditlog.Controls.Add(this.dgvauditlog);
            this.gbauditlog.Controls.Add(this.label1);
            this.gbauditlog.Location = new System.Drawing.Point(12, 78);
            this.gbauditlog.Name = "gbauditlog";
            this.gbauditlog.Size = new System.Drawing.Size(775, 360);
            this.gbauditlog.TabIndex = 3;
            this.gbauditlog.TabStop = false;
            // 
            // dgvauditfga
            // 
            this.dgvauditfga.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvauditfga.Location = new System.Drawing.Point(9, 224);
            this.dgvauditfga.Name = "dgvauditfga";
            this.dgvauditfga.RowHeadersWidth = 51;
            this.dgvauditfga.RowTemplate.Height = 24;
            this.dgvauditfga.Size = new System.Drawing.Size(756, 129);
            this.dgvauditfga.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "select";
            // 
            // dgvauditlog
            // 
            this.dgvauditlog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvauditlog.Location = new System.Drawing.Point(6, 47);
            this.dgvauditlog.Name = "dgvauditlog";
            this.dgvauditlog.RowHeadersWidth = 51;
            this.dgvauditlog.RowTemplate.Height = 24;
            this.dgvauditlog.Size = new System.Drawing.Size(759, 150);
            this.dgvauditlog.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "update delete";
            // 
            // txtchangekey
            // 
            this.txtchangekey.Location = new System.Drawing.Point(263, 65);
            this.txtchangekey.Name = "txtchangekey";
            this.txtchangekey.Size = new System.Drawing.Size(213, 22);
            this.txtchangekey.TabIndex = 1;
            // 
            // btnchangekey
            // 
            this.btnchangekey.Location = new System.Drawing.Point(297, 130);
            this.btnchangekey.Name = "btnchangekey";
            this.btnchangekey.Size = new System.Drawing.Size(142, 23);
            this.btnchangekey.TabIndex = 2;
            this.btnchangekey.Text = "change key";
            this.btnchangekey.UseVisualStyleBackColor = true;
            this.btnchangekey.Click += new System.EventHandler(this.btnchangekey_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(263, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "KEY";
            // 
            // managerfinance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbauditlog);
            this.Controls.Add(this.gbkey);
            this.Controls.Add(this.btn_auditlogkey);
            this.Controls.Add(this.btn_key);
            this.Name = "managerfinance";
            this.Text = "managerfinance";
            this.Load += new System.EventHandler(this.managerfinance_Load);
            this.gbkey.ResumeLayout(false);
            this.gbkey.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvkey)).EndInit();
            this.gbauditlog.ResumeLayout(false);
            this.gbauditlog.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvauditfga)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvauditlog)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_key;
        private System.Windows.Forms.Button btn_auditlogkey;
        private System.Windows.Forms.GroupBox gbkey;
        private System.Windows.Forms.DataGridView dgvkey;
        private System.Windows.Forms.GroupBox gbauditlog;
        private System.Windows.Forms.DataGridView dgvauditfga;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvauditlog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnchangekey;
        private System.Windows.Forms.TextBox txtchangekey;
    }
}