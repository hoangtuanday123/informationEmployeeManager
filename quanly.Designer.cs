
namespace PHANHE1
{
    partial class quanly
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
            this.lblidnvquanly = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btninfor_quanly = new System.Windows.Forms.Button();
            this.btnnhanvien_quanly = new System.Windows.Forms.Button();
            this.gbnhanvien_quanly = new System.Windows.Forms.GroupBox();
            this.dgvnhanvien_quanly = new System.Windows.Forms.DataGridView();
            this.gbphancong_quanly = new System.Windows.Forms.GroupBox();
            this.btndeletephancong_quanly = new System.Windows.Forms.Button();
            this.btnupdatephancong_quanly = new System.Windows.Forms.Button();
            this.btninsertphancong_quanly = new System.Windows.Forms.Button();
            this.txtthoigianphancong_quanly = new System.Windows.Forms.TextBox();
            this.txtmadaphancong_quanly = new System.Windows.Forms.TextBox();
            this.txtmanvphancong_quanly = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvphancong_quanly = new System.Windows.Forms.DataGridView();
            this.btnphancong_quanly = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.gbnhanvien_quanly.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvnhanvien_quanly)).BeginInit();
            this.gbphancong_quanly.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvphancong_quanly)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.lblidnvquanly);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(1, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(797, 65);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // lblidnvquanly
            // 
            this.lblidnvquanly.AutoSize = true;
            this.lblidnvquanly.Location = new System.Drawing.Point(120, 29);
            this.lblidnvquanly.Name = "lblidnvquanly";
            this.lblidnvquanly.Size = new System.Drawing.Size(46, 17);
            this.lblidnvquanly.TabIndex = 1;
            this.lblidnvquanly.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "IDNHANVIEN";
            // 
            // btninfor_quanly
            // 
            this.btninfor_quanly.Location = new System.Drawing.Point(1, 74);
            this.btninfor_quanly.Name = "btninfor_quanly";
            this.btninfor_quanly.Size = new System.Drawing.Size(102, 32);
            this.btninfor_quanly.TabIndex = 1;
            this.btninfor_quanly.Text = "information";
            this.btninfor_quanly.UseVisualStyleBackColor = true;
            this.btninfor_quanly.Click += new System.EventHandler(this.btninfor_quanly_Click);
            // 
            // btnnhanvien_quanly
            // 
            this.btnnhanvien_quanly.Location = new System.Drawing.Point(1, 113);
            this.btnnhanvien_quanly.Name = "btnnhanvien_quanly";
            this.btnnhanvien_quanly.Size = new System.Drawing.Size(102, 32);
            this.btnnhanvien_quanly.TabIndex = 2;
            this.btnnhanvien_quanly.Text = "nhanvien";
            this.btnnhanvien_quanly.UseVisualStyleBackColor = true;
            this.btnnhanvien_quanly.Click += new System.EventHandler(this.btnnhanvien_quanly_Click);
            // 
            // gbnhanvien_quanly
            // 
            this.gbnhanvien_quanly.Controls.Add(this.dgvnhanvien_quanly);
            this.gbnhanvien_quanly.Location = new System.Drawing.Point(139, 113);
            this.gbnhanvien_quanly.Name = "gbnhanvien_quanly";
            this.gbnhanvien_quanly.Size = new System.Drawing.Size(649, 288);
            this.gbnhanvien_quanly.TabIndex = 3;
            this.gbnhanvien_quanly.TabStop = false;
            // 
            // dgvnhanvien_quanly
            // 
            this.dgvnhanvien_quanly.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvnhanvien_quanly.Location = new System.Drawing.Point(6, 21);
            this.dgvnhanvien_quanly.Name = "dgvnhanvien_quanly";
            this.dgvnhanvien_quanly.RowHeadersWidth = 51;
            this.dgvnhanvien_quanly.RowTemplate.Height = 24;
            this.dgvnhanvien_quanly.Size = new System.Drawing.Size(637, 261);
            this.dgvnhanvien_quanly.TabIndex = 0;
            // 
            // gbphancong_quanly
            // 
            this.gbphancong_quanly.Controls.Add(this.btndeletephancong_quanly);
            this.gbphancong_quanly.Controls.Add(this.btnupdatephancong_quanly);
            this.gbphancong_quanly.Controls.Add(this.btninsertphancong_quanly);
            this.gbphancong_quanly.Controls.Add(this.txtthoigianphancong_quanly);
            this.gbphancong_quanly.Controls.Add(this.txtmadaphancong_quanly);
            this.gbphancong_quanly.Controls.Add(this.txtmanvphancong_quanly);
            this.gbphancong_quanly.Controls.Add(this.label4);
            this.gbphancong_quanly.Controls.Add(this.label3);
            this.gbphancong_quanly.Controls.Add(this.label2);
            this.gbphancong_quanly.Controls.Add(this.dgvphancong_quanly);
            this.gbphancong_quanly.Location = new System.Drawing.Point(124, 101);
            this.gbphancong_quanly.Name = "gbphancong_quanly";
            this.gbphancong_quanly.Size = new System.Drawing.Size(664, 321);
            this.gbphancong_quanly.TabIndex = 4;
            this.gbphancong_quanly.TabStop = false;
            this.gbphancong_quanly.Enter += new System.EventHandler(this.gbphancong_quanly_Enter);
            // 
            // btndeletephancong_quanly
            // 
            this.btndeletephancong_quanly.Location = new System.Drawing.Point(585, 182);
            this.btndeletephancong_quanly.Name = "btndeletephancong_quanly";
            this.btndeletephancong_quanly.Size = new System.Drawing.Size(75, 23);
            this.btndeletephancong_quanly.TabIndex = 9;
            this.btndeletephancong_quanly.Text = "delete";
            this.btndeletephancong_quanly.UseVisualStyleBackColor = true;
            this.btndeletephancong_quanly.Click += new System.EventHandler(this.btndeletephancong_quanly_Click);
            // 
            // btnupdatephancong_quanly
            // 
            this.btnupdatephancong_quanly.Location = new System.Drawing.Point(478, 183);
            this.btnupdatephancong_quanly.Name = "btnupdatephancong_quanly";
            this.btnupdatephancong_quanly.Size = new System.Drawing.Size(75, 23);
            this.btnupdatephancong_quanly.TabIndex = 8;
            this.btnupdatephancong_quanly.Text = "update";
            this.btnupdatephancong_quanly.UseVisualStyleBackColor = true;
            this.btnupdatephancong_quanly.Click += new System.EventHandler(this.btnupdatephancong_quanly_Click);
            // 
            // btninsertphancong_quanly
            // 
            this.btninsertphancong_quanly.Location = new System.Drawing.Point(368, 183);
            this.btninsertphancong_quanly.Name = "btninsertphancong_quanly";
            this.btninsertphancong_quanly.Size = new System.Drawing.Size(75, 23);
            this.btninsertphancong_quanly.TabIndex = 7;
            this.btninsertphancong_quanly.Text = "insert";
            this.btninsertphancong_quanly.UseVisualStyleBackColor = true;
            this.btninsertphancong_quanly.Click += new System.EventHandler(this.btninsertphancong_quanly_Click);
            // 
            // txtthoigianphancong_quanly
            // 
            this.txtthoigianphancong_quanly.Location = new System.Drawing.Point(450, 122);
            this.txtthoigianphancong_quanly.Name = "txtthoigianphancong_quanly";
            this.txtthoigianphancong_quanly.Size = new System.Drawing.Size(142, 22);
            this.txtthoigianphancong_quanly.TabIndex = 6;
            // 
            // txtmadaphancong_quanly
            // 
            this.txtmadaphancong_quanly.Location = new System.Drawing.Point(450, 76);
            this.txtmadaphancong_quanly.Name = "txtmadaphancong_quanly";
            this.txtmadaphancong_quanly.Size = new System.Drawing.Size(142, 22);
            this.txtmadaphancong_quanly.TabIndex = 5;
            // 
            // txtmanvphancong_quanly
            // 
            this.txtmanvphancong_quanly.Location = new System.Drawing.Point(450, 34);
            this.txtmanvphancong_quanly.Name = "txtmanvphancong_quanly";
            this.txtmanvphancong_quanly.Size = new System.Drawing.Size(142, 22);
            this.txtmanvphancong_quanly.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(365, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "thoigian";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(365, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "mada";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(362, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "manv";
            // 
            // dgvphancong_quanly
            // 
            this.dgvphancong_quanly.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvphancong_quanly.Location = new System.Drawing.Point(6, 21);
            this.dgvphancong_quanly.Name = "dgvphancong_quanly";
            this.dgvphancong_quanly.RowHeadersWidth = 51;
            this.dgvphancong_quanly.RowTemplate.Height = 24;
            this.dgvphancong_quanly.Size = new System.Drawing.Size(341, 294);
            this.dgvphancong_quanly.TabIndex = 0;
            this.dgvphancong_quanly.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvphancong_quanly_CellContentClick);
            // 
            // btnphancong_quanly
            // 
            this.btnphancong_quanly.Location = new System.Drawing.Point(1, 151);
            this.btnphancong_quanly.Name = "btnphancong_quanly";
            this.btnphancong_quanly.Size = new System.Drawing.Size(102, 32);
            this.btnphancong_quanly.TabIndex = 5;
            this.btnphancong_quanly.Text = "phancong";
            this.btnphancong_quanly.UseVisualStyleBackColor = true;
            this.btnphancong_quanly.Click += new System.EventHandler(this.btnphancong_quanly_Click);
            // 
            // quanly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnphancong_quanly);
            this.Controls.Add(this.gbphancong_quanly);
            this.Controls.Add(this.gbnhanvien_quanly);
            this.Controls.Add(this.btnnhanvien_quanly);
            this.Controls.Add(this.btninfor_quanly);
            this.Controls.Add(this.groupBox1);
            this.Name = "quanly";
            this.Text = "quanly";
            this.Load += new System.EventHandler(this.quanly_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbnhanvien_quanly.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvnhanvien_quanly)).EndInit();
            this.gbphancong_quanly.ResumeLayout(false);
            this.gbphancong_quanly.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvphancong_quanly)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblidnvquanly;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btninfor_quanly;
        private System.Windows.Forms.Button btnnhanvien_quanly;
        private System.Windows.Forms.GroupBox gbnhanvien_quanly;
        private System.Windows.Forms.DataGridView dgvnhanvien_quanly;
        private System.Windows.Forms.GroupBox gbphancong_quanly;
        private System.Windows.Forms.Button btndeletephancong_quanly;
        private System.Windows.Forms.Button btnupdatephancong_quanly;
        private System.Windows.Forms.Button btninsertphancong_quanly;
        private System.Windows.Forms.TextBox txtthoigianphancong_quanly;
        private System.Windows.Forms.TextBox txtmadaphancong_quanly;
        private System.Windows.Forms.TextBox txtmanvphancong_quanly;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvphancong_quanly;
        private System.Windows.Forms.Button btnphancong_quanly;
    }
}