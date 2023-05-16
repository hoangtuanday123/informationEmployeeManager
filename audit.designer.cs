namespace AUDIT
{
    partial class frmAudit
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
            this.btnNKCapNhatTG = new System.Windows.Forms.Button();
            this.btnNKXemLPC = new System.Windows.Forms.Button();
            this.btnNKCapNhatLPC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNKCapNhatTG
            // 
            this.btnNKCapNhatTG.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnNKCapNhatTG.Location = new System.Drawing.Point(110, 42);
            this.btnNKCapNhatTG.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNKCapNhatTG.Name = "btnNKCapNhatTG";
            this.btnNKCapNhatTG.Size = new System.Drawing.Size(269, 72);
            this.btnNKCapNhatTG.TabIndex = 5;
            this.btnNKCapNhatTG.Text = "NHẬT KÝ CẬP NHẬT THỜI GIAN";
            this.btnNKCapNhatTG.UseVisualStyleBackColor = false;
            this.btnNKCapNhatTG.Click += new System.EventHandler(this.btnNKCapNhatTG_Click);
            // 
            // btnNKXemLPC
            // 
            this.btnNKXemLPC.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnNKXemLPC.Location = new System.Drawing.Point(110, 142);
            this.btnNKXemLPC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNKXemLPC.Name = "btnNKXemLPC";
            this.btnNKXemLPC.Size = new System.Drawing.Size(269, 72);
            this.btnNKXemLPC.TabIndex = 6;
            this.btnNKXemLPC.Text = "NHẬT KÝ XEM LƯƠNG, PHỤ CẤP";
            this.btnNKXemLPC.UseVisualStyleBackColor = false;
            this.btnNKXemLPC.Click += new System.EventHandler(this.btnNKXemLPC_Click);
            // 
            // btnNKCapNhatLPC
            // 
            this.btnNKCapNhatLPC.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnNKCapNhatLPC.Location = new System.Drawing.Point(110, 244);
            this.btnNKCapNhatLPC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNKCapNhatLPC.Name = "btnNKCapNhatLPC";
            this.btnNKCapNhatLPC.Size = new System.Drawing.Size(269, 72);
            this.btnNKCapNhatLPC.TabIndex = 7;
            this.btnNKCapNhatLPC.Text = "NHẬT KÝ CẬP NHẬT LƯƠNG, PHỤ CẤP";
            this.btnNKCapNhatLPC.UseVisualStyleBackColor = false;
            this.btnNKCapNhatLPC.Click += new System.EventHandler(this.btnNKCapNhatLPC_Click);
            // 
            // frmAudit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 360);
            this.Controls.Add(this.btnNKCapNhatLPC);
            this.Controls.Add(this.btnNKXemLPC);
            this.Controls.Add(this.btnNKCapNhatTG);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmAudit";
            this.Text = "AUDIT";
            this.Load += new System.EventHandler(this.frmAudit_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNKCapNhatTG;
        private System.Windows.Forms.Button btnNKXemLPC;
        private System.Windows.Forms.Button btnNKCapNhatLPC;
    }
}

