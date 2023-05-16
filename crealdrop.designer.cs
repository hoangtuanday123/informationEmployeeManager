namespace PH1_5
{
    partial class CreateAlterDrop
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
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnAlter = new System.Windows.Forms.Button();
            this.btnDrop = new System.Windows.Forms.Button();
            this.lblUserName = new System.Windows.Forms.Label();
            this.cbRole = new System.Windows.Forms.CheckBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbPassword = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(11, 10);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(241, 48);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "CREATE USER/ROLE PRIVILEGE";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnAlter
            // 
            this.btnAlter.Location = new System.Drawing.Point(257, 10);
            this.btnAlter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAlter.Name = "btnAlter";
            this.btnAlter.Size = new System.Drawing.Size(241, 48);
            this.btnAlter.TabIndex = 1;
            this.btnAlter.Text = "MODIFY USER/ROLE PRIVILEGE";
            this.btnAlter.UseVisualStyleBackColor = true;
            this.btnAlter.Click += new System.EventHandler(this.btnAlter_Click);
            // 
            // btnDrop
            // 
            this.btnDrop.Location = new System.Drawing.Point(503, 10);
            this.btnDrop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDrop.Name = "btnDrop";
            this.btnDrop.Size = new System.Drawing.Size(241, 48);
            this.btnDrop.TabIndex = 2;
            this.btnDrop.Text = "DROP USER/ROLE PRIVILEGE";
            this.btnDrop.UseVisualStyleBackColor = true;
            this.btnDrop.Click += new System.EventHandler(this.btnDrop_Click);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(150, 166);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(85, 17);
            this.lblUserName.TabIndex = 4;
            this.lblUserName.Text = "USERNAME";
            // 
            // cbRole
            // 
            this.cbRole.AutoSize = true;
            this.cbRole.Location = new System.Drawing.Point(541, 163);
            this.cbRole.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbRole.Name = "cbRole";
            this.cbRole.Size = new System.Drawing.Size(59, 21);
            this.cbRole.TabIndex = 5;
            this.cbRole.Text = "Role";
            this.cbRole.UseVisualStyleBackColor = true;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(257, 162);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(255, 22);
            this.txtUserName.TabIndex = 6;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(257, 207);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(255, 22);
            this.txtPassword.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "PASSWORD";
            // 
            // cbPassword
            // 
            this.cbPassword.AutoSize = true;
            this.cbPassword.Location = new System.Drawing.Point(607, 163);
            this.cbPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbPassword.Name = "cbPassword";
            this.cbPassword.Size = new System.Drawing.Size(91, 21);
            this.cbPassword.TabIndex = 9;
            this.cbPassword.Text = "Password";
            this.cbPassword.UseVisualStyleBackColor = true;
            // 
            // CreateAlterDrop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 360);
            this.Controls.Add(this.cbPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.cbRole);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.btnDrop);
            this.Controls.Add(this.btnAlter);
            this.Controls.Add(this.btnCreate);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CreateAlterDrop";
            this.Text = "CreateAlterDrop";
            this.Load += new System.EventHandler(this.CreateAlterDrop_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnAlter;
        private System.Windows.Forms.Button btnDrop;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.CheckBox cbRole;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbPassword;
    }
}

