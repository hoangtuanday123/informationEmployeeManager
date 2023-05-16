
namespace GRANT_PRIVILEGES
{
    partial class GrantPrivileges
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
            this.btnGrantPrivilegesToUser = new System.Windows.Forms.Button();
            this.btnGrantPrivilegesToRole = new System.Windows.Forms.Button();
            this.btnGrantRoleToUser = new System.Windows.Forms.Button();
            this.grbGrantPrivilegesToUser = new System.Windows.Forms.GroupBox();
            this.btnLoadColumn = new System.Windows.Forms.Button();
            this.cbWithGrantOption = new System.Windows.Forms.CheckBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.cbDelete = new System.Windows.Forms.CheckBox();
            this.cbInsert = new System.Windows.Forms.CheckBox();
            this.cbUpdate = new System.Windows.Forms.CheckBox();
            this.cbSelect = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbTable = new System.Windows.Forms.ComboBox();
            this.cbbColumn = new System.Windows.Forms.ComboBox();
            this.cbbUser = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grbGrantPrivilegesToRole = new System.Windows.Forms.GroupBox();
            this.btnLoadColumnRole = new System.Windows.Forms.Button();
            this.btnApplyRole = new System.Windows.Forms.Button();
            this.cbDeleteRole = new System.Windows.Forms.CheckBox();
            this.cbInsertRole = new System.Windows.Forms.CheckBox();
            this.cbUpdateRole = new System.Windows.Forms.CheckBox();
            this.cbSelectRole = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbTableRole = new System.Windows.Forms.ComboBox();
            this.cbbColumnRole = new System.Windows.Forms.ComboBox();
            this.cbbRole = new System.Windows.Forms.ComboBox();
            this.grbGrantRoleToUser = new System.Windows.Forms.GroupBox();
            this.btnApplyRoleToUser = new System.Windows.Forms.Button();
            this.cbWithAdminOption = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbbUserRoleToUser = new System.Windows.Forms.ComboBox();
            this.cbbRoleRoleToUser = new System.Windows.Forms.ComboBox();
            this.grbGrantPrivilegesToUser.SuspendLayout();
            this.grbGrantPrivilegesToRole.SuspendLayout();
            this.grbGrantRoleToUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGrantPrivilegesToUser
            // 
            this.btnGrantPrivilegesToUser.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnGrantPrivilegesToUser.Location = new System.Drawing.Point(2, 1);
            this.btnGrantPrivilegesToUser.Name = "btnGrantPrivilegesToUser";
            this.btnGrantPrivilegesToUser.Size = new System.Drawing.Size(410, 56);
            this.btnGrantPrivilegesToUser.TabIndex = 0;
            this.btnGrantPrivilegesToUser.Text = "Grant Privileges To User";
            this.btnGrantPrivilegesToUser.UseVisualStyleBackColor = false;
            this.btnGrantPrivilegesToUser.Click += new System.EventHandler(this.btnGrantPrivilegesToUser_Click);
            // 
            // btnGrantPrivilegesToRole
            // 
            this.btnGrantPrivilegesToRole.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnGrantPrivilegesToRole.Location = new System.Drawing.Point(418, 1);
            this.btnGrantPrivilegesToRole.Name = "btnGrantPrivilegesToRole";
            this.btnGrantPrivilegesToRole.Size = new System.Drawing.Size(410, 56);
            this.btnGrantPrivilegesToRole.TabIndex = 1;
            this.btnGrantPrivilegesToRole.Text = "Grant Privileges To Role";
            this.btnGrantPrivilegesToRole.UseVisualStyleBackColor = false;
            this.btnGrantPrivilegesToRole.Click += new System.EventHandler(this.btnGrantPrivilegesToRole_Click);
            // 
            // btnGrantRoleToUser
            // 
            this.btnGrantRoleToUser.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnGrantRoleToUser.Location = new System.Drawing.Point(834, 1);
            this.btnGrantRoleToUser.Name = "btnGrantRoleToUser";
            this.btnGrantRoleToUser.Size = new System.Drawing.Size(410, 56);
            this.btnGrantRoleToUser.TabIndex = 2;
            this.btnGrantRoleToUser.Text = "Grant Role To User";
            this.btnGrantRoleToUser.UseVisualStyleBackColor = false;
            this.btnGrantRoleToUser.Click += new System.EventHandler(this.btnGrantRoleToUser_Click);
            // 
            // grbGrantPrivilegesToUser
            // 
            this.grbGrantPrivilegesToUser.Controls.Add(this.btnLoadColumn);
            this.grbGrantPrivilegesToUser.Controls.Add(this.cbWithGrantOption);
            this.grbGrantPrivilegesToUser.Controls.Add(this.btnApply);
            this.grbGrantPrivilegesToUser.Controls.Add(this.cbDelete);
            this.grbGrantPrivilegesToUser.Controls.Add(this.cbInsert);
            this.grbGrantPrivilegesToUser.Controls.Add(this.cbUpdate);
            this.grbGrantPrivilegesToUser.Controls.Add(this.cbSelect);
            this.grbGrantPrivilegesToUser.Controls.Add(this.label3);
            this.grbGrantPrivilegesToUser.Controls.Add(this.label2);
            this.grbGrantPrivilegesToUser.Controls.Add(this.label1);
            this.grbGrantPrivilegesToUser.Controls.Add(this.cbbTable);
            this.grbGrantPrivilegesToUser.Controls.Add(this.cbbColumn);
            this.grbGrantPrivilegesToUser.Controls.Add(this.cbbUser);
            this.grbGrantPrivilegesToUser.Location = new System.Drawing.Point(25, 63);
            this.grbGrantPrivilegesToUser.Name = "grbGrantPrivilegesToUser";
            this.grbGrantPrivilegesToUser.Size = new System.Drawing.Size(1201, 459);
            this.grbGrantPrivilegesToUser.TabIndex = 3;
            this.grbGrantPrivilegesToUser.TabStop = false;
            // 
            // btnLoadColumn
            // 
            this.btnLoadColumn.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnLoadColumn.Location = new System.Drawing.Point(461, 206);
            this.btnLoadColumn.Name = "btnLoadColumn";
            this.btnLoadColumn.Size = new System.Drawing.Size(137, 48);
            this.btnLoadColumn.TabIndex = 28;
            this.btnLoadColumn.Text = "Load Column";
            this.btnLoadColumn.UseVisualStyleBackColor = false;
            this.btnLoadColumn.Click += new System.EventHandler(this.btnLoadColumn_Click_1);
            // 
            // cbWithGrantOption
            // 
            this.cbWithGrantOption.AutoSize = true;
            this.cbWithGrantOption.Location = new System.Drawing.Point(334, 358);
            this.cbWithGrantOption.Name = "cbWithGrantOption";
            this.cbWithGrantOption.Size = new System.Drawing.Size(144, 21);
            this.cbWithGrantOption.TabIndex = 27;
            this.cbWithGrantOption.Text = "Grant With Option";
            this.cbWithGrantOption.UseVisualStyleBackColor = true;
            // 
            // btnApply
            // 
            this.btnApply.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnApply.Location = new System.Drawing.Point(908, 393);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(117, 35);
            this.btnApply.TabIndex = 26;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = false;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click_1);
            // 
            // cbDelete
            // 
            this.cbDelete.AutoSize = true;
            this.cbDelete.Location = new System.Drawing.Point(956, 197);
            this.cbDelete.Name = "cbDelete";
            this.cbDelete.Size = new System.Drawing.Size(71, 21);
            this.cbDelete.TabIndex = 25;
            this.cbDelete.Text = "Delete";
            this.cbDelete.UseVisualStyleBackColor = true;
            // 
            // cbInsert
            // 
            this.cbInsert.AutoSize = true;
            this.cbInsert.Location = new System.Drawing.Point(956, 273);
            this.cbInsert.Name = "cbInsert";
            this.cbInsert.Size = new System.Drawing.Size(65, 21);
            this.cbInsert.TabIndex = 24;
            this.cbInsert.Text = "Insert";
            this.cbInsert.UseVisualStyleBackColor = true;
            // 
            // cbUpdate
            // 
            this.cbUpdate.AutoSize = true;
            this.cbUpdate.Location = new System.Drawing.Point(956, 116);
            this.cbUpdate.Name = "cbUpdate";
            this.cbUpdate.Size = new System.Drawing.Size(76, 21);
            this.cbUpdate.TabIndex = 23;
            this.cbUpdate.Text = "Update";
            this.cbUpdate.UseVisualStyleBackColor = true;
            // 
            // cbSelect
            // 
            this.cbSelect.AutoSize = true;
            this.cbSelect.Location = new System.Drawing.Point(956, 45);
            this.cbSelect.Name = "cbSelect";
            this.cbSelect.Size = new System.Drawing.Size(69, 21);
            this.cbSelect.TabIndex = 22;
            this.cbSelect.Text = "Select";
            this.cbSelect.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(216, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Column";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Table";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(216, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "User";
            // 
            // cbbTable
            // 
            this.cbbTable.FormattingEnabled = true;
            this.cbbTable.Location = new System.Drawing.Point(334, 146);
            this.cbbTable.Name = "cbbTable";
            this.cbbTable.Size = new System.Drawing.Size(410, 24);
            this.cbbTable.TabIndex = 18;
            // 
            // cbbColumn
            // 
            this.cbbColumn.FormattingEnabled = true;
            this.cbbColumn.Location = new System.Drawing.Point(334, 293);
            this.cbbColumn.Name = "cbbColumn";
            this.cbbColumn.Size = new System.Drawing.Size(410, 24);
            this.cbbColumn.TabIndex = 17;
            // 
            // cbbUser
            // 
            this.cbbUser.FormattingEnabled = true;
            this.cbbUser.Location = new System.Drawing.Point(334, 49);
            this.cbbUser.Name = "cbbUser";
            this.cbbUser.Size = new System.Drawing.Size(410, 24);
            this.cbbUser.TabIndex = 16;
            // 
            // grbGrantPrivilegesToRole
            // 
            this.grbGrantPrivilegesToRole.Controls.Add(this.btnLoadColumnRole);
            this.grbGrantPrivilegesToRole.Controls.Add(this.btnApplyRole);
            this.grbGrantPrivilegesToRole.Controls.Add(this.cbDeleteRole);
            this.grbGrantPrivilegesToRole.Controls.Add(this.cbInsertRole);
            this.grbGrantPrivilegesToRole.Controls.Add(this.cbUpdateRole);
            this.grbGrantPrivilegesToRole.Controls.Add(this.cbSelectRole);
            this.grbGrantPrivilegesToRole.Controls.Add(this.label4);
            this.grbGrantPrivilegesToRole.Controls.Add(this.label5);
            this.grbGrantPrivilegesToRole.Controls.Add(this.label6);
            this.grbGrantPrivilegesToRole.Controls.Add(this.cbbTableRole);
            this.grbGrantPrivilegesToRole.Controls.Add(this.cbbColumnRole);
            this.grbGrantPrivilegesToRole.Controls.Add(this.cbbRole);
            this.grbGrantPrivilegesToRole.Location = new System.Drawing.Point(12, 63);
            this.grbGrantPrivilegesToRole.Name = "grbGrantPrivilegesToRole";
            this.grbGrantPrivilegesToRole.Size = new System.Drawing.Size(1228, 449);
            this.grbGrantPrivilegesToRole.TabIndex = 29;
            this.grbGrantPrivilegesToRole.TabStop = false;
            this.grbGrantPrivilegesToRole.Enter += new System.EventHandler(this.grbGrantPrivilegesToRole_Enter);
            // 
            // btnLoadColumnRole
            // 
            this.btnLoadColumnRole.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnLoadColumnRole.Location = new System.Drawing.Point(461, 206);
            this.btnLoadColumnRole.Name = "btnLoadColumnRole";
            this.btnLoadColumnRole.Size = new System.Drawing.Size(137, 48);
            this.btnLoadColumnRole.TabIndex = 41;
            this.btnLoadColumnRole.Text = "Load Column";
            this.btnLoadColumnRole.UseVisualStyleBackColor = false;
            this.btnLoadColumnRole.Click += new System.EventHandler(this.btnLoadColumnRole_Click);
            // 
            // btnApplyRole
            // 
            this.btnApplyRole.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnApplyRole.Location = new System.Drawing.Point(908, 393);
            this.btnApplyRole.Name = "btnApplyRole";
            this.btnApplyRole.Size = new System.Drawing.Size(117, 35);
            this.btnApplyRole.TabIndex = 39;
            this.btnApplyRole.Text = "Apply";
            this.btnApplyRole.UseVisualStyleBackColor = false;
            this.btnApplyRole.Click += new System.EventHandler(this.btnApplyRole_Click);
            // 
            // cbDeleteRole
            // 
            this.cbDeleteRole.AutoSize = true;
            this.cbDeleteRole.Location = new System.Drawing.Point(956, 197);
            this.cbDeleteRole.Name = "cbDeleteRole";
            this.cbDeleteRole.Size = new System.Drawing.Size(71, 21);
            this.cbDeleteRole.TabIndex = 38;
            this.cbDeleteRole.Text = "Delete";
            this.cbDeleteRole.UseVisualStyleBackColor = true;
            // 
            // cbInsertRole
            // 
            this.cbInsertRole.AutoSize = true;
            this.cbInsertRole.Location = new System.Drawing.Point(956, 273);
            this.cbInsertRole.Name = "cbInsertRole";
            this.cbInsertRole.Size = new System.Drawing.Size(65, 21);
            this.cbInsertRole.TabIndex = 37;
            this.cbInsertRole.Text = "Insert";
            this.cbInsertRole.UseVisualStyleBackColor = true;
            // 
            // cbUpdateRole
            // 
            this.cbUpdateRole.AutoSize = true;
            this.cbUpdateRole.Location = new System.Drawing.Point(956, 116);
            this.cbUpdateRole.Name = "cbUpdateRole";
            this.cbUpdateRole.Size = new System.Drawing.Size(76, 21);
            this.cbUpdateRole.TabIndex = 36;
            this.cbUpdateRole.Text = "Update";
            this.cbUpdateRole.UseVisualStyleBackColor = true;
            // 
            // cbSelectRole
            // 
            this.cbSelectRole.AutoSize = true;
            this.cbSelectRole.Location = new System.Drawing.Point(956, 45);
            this.cbSelectRole.Name = "cbSelectRole";
            this.cbSelectRole.Size = new System.Drawing.Size(69, 21);
            this.cbSelectRole.TabIndex = 35;
            this.cbSelectRole.Text = "Select";
            this.cbSelectRole.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(216, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 34;
            this.label4.Text = "Column";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(216, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
            this.label5.TabIndex = 33;
            this.label5.Text = "Table";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(216, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 17);
            this.label6.TabIndex = 32;
            this.label6.Text = "Role";
            // 
            // cbbTableRole
            // 
            this.cbbTableRole.FormattingEnabled = true;
            this.cbbTableRole.Location = new System.Drawing.Point(334, 146);
            this.cbbTableRole.Name = "cbbTableRole";
            this.cbbTableRole.Size = new System.Drawing.Size(410, 24);
            this.cbbTableRole.TabIndex = 31;
            // 
            // cbbColumnRole
            // 
            this.cbbColumnRole.FormattingEnabled = true;
            this.cbbColumnRole.Location = new System.Drawing.Point(334, 293);
            this.cbbColumnRole.Name = "cbbColumnRole";
            this.cbbColumnRole.Size = new System.Drawing.Size(410, 24);
            this.cbbColumnRole.TabIndex = 30;
            // 
            // cbbRole
            // 
            this.cbbRole.FormattingEnabled = true;
            this.cbbRole.Location = new System.Drawing.Point(334, 49);
            this.cbbRole.Name = "cbbRole";
            this.cbbRole.Size = new System.Drawing.Size(410, 24);
            this.cbbRole.TabIndex = 29;
            // 
            // grbGrantRoleToUser
            // 
            this.grbGrantRoleToUser.Controls.Add(this.btnApplyRoleToUser);
            this.grbGrantRoleToUser.Controls.Add(this.cbWithAdminOption);
            this.grbGrantRoleToUser.Controls.Add(this.label8);
            this.grbGrantRoleToUser.Controls.Add(this.label7);
            this.grbGrantRoleToUser.Controls.Add(this.cbbUserRoleToUser);
            this.grbGrantRoleToUser.Controls.Add(this.cbbRoleRoleToUser);
            this.grbGrantRoleToUser.Location = new System.Drawing.Point(2, 63);
            this.grbGrantRoleToUser.Name = "grbGrantRoleToUser";
            this.grbGrantRoleToUser.Size = new System.Drawing.Size(1242, 460);
            this.grbGrantRoleToUser.TabIndex = 42;
            this.grbGrantRoleToUser.TabStop = false;
            // 
            // btnApplyRoleToUser
            // 
            this.btnApplyRoleToUser.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnApplyRoleToUser.Location = new System.Drawing.Point(546, 307);
            this.btnApplyRoleToUser.Name = "btnApplyRoleToUser";
            this.btnApplyRoleToUser.Size = new System.Drawing.Size(147, 39);
            this.btnApplyRoleToUser.TabIndex = 5;
            this.btnApplyRoleToUser.Text = "Apply";
            this.btnApplyRoleToUser.UseVisualStyleBackColor = false;
            this.btnApplyRoleToUser.Click += new System.EventHandler(this.btnApplyRoleToUser_Click);
            // 
            // cbWithAdminOption
            // 
            this.cbWithAdminOption.AutoSize = true;
            this.cbWithAdminOption.Location = new System.Drawing.Point(416, 233);
            this.cbWithAdminOption.Name = "cbWithAdminOption";
            this.cbWithAdminOption.Size = new System.Drawing.Size(147, 21);
            this.cbWithAdminOption.TabIndex = 4;
            this.cbWithAdminOption.Text = "With Admin Option";
            this.cbWithAdminOption.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(331, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 17);
            this.label8.TabIndex = 3;
            this.label8.Text = "User ";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(331, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Role";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // cbbUserRoleToUser
            // 
            this.cbbUserRoleToUser.FormattingEnabled = true;
            this.cbbUserRoleToUser.Location = new System.Drawing.Point(416, 143);
            this.cbbUserRoleToUser.Name = "cbbUserRoleToUser";
            this.cbbUserRoleToUser.Size = new System.Drawing.Size(410, 24);
            this.cbbUserRoleToUser.TabIndex = 1;
            // 
            // cbbRoleRoleToUser
            // 
            this.cbbRoleRoleToUser.FormattingEnabled = true;
            this.cbbRoleRoleToUser.Location = new System.Drawing.Point(416, 49);
            this.cbbRoleRoleToUser.Name = "cbbRoleRoleToUser";
            this.cbbRoleRoleToUser.Size = new System.Drawing.Size(410, 24);
            this.cbbRoleRoleToUser.TabIndex = 0;
            // 
            // GrantPrivileges
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1252, 526);
            this.Controls.Add(this.grbGrantRoleToUser);
            this.Controls.Add(this.grbGrantPrivilegesToRole);
            this.Controls.Add(this.grbGrantPrivilegesToUser);
            this.Controls.Add(this.btnGrantRoleToUser);
            this.Controls.Add(this.btnGrantPrivilegesToRole);
            this.Controls.Add(this.btnGrantPrivilegesToUser);
            this.Name = "GrantPrivileges";
            this.Text = "Grant Privileges";
            this.Load += new System.EventHandler(this.GrantPrivileges_Load);
            this.grbGrantPrivilegesToUser.ResumeLayout(false);
            this.grbGrantPrivilegesToUser.PerformLayout();
            this.grbGrantPrivilegesToRole.ResumeLayout(false);
            this.grbGrantPrivilegesToRole.PerformLayout();
            this.grbGrantRoleToUser.ResumeLayout(false);
            this.grbGrantRoleToUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGrantPrivilegesToUser;
        private System.Windows.Forms.Button btnGrantPrivilegesToRole;
        private System.Windows.Forms.Button btnGrantRoleToUser;
        private System.Windows.Forms.GroupBox grbGrantPrivilegesToUser;
        private System.Windows.Forms.Button btnLoadColumn;
        private System.Windows.Forms.CheckBox cbWithGrantOption;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.CheckBox cbDelete;
        private System.Windows.Forms.CheckBox cbInsert;
        private System.Windows.Forms.CheckBox cbUpdate;
        private System.Windows.Forms.CheckBox cbSelect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbTable;
        private System.Windows.Forms.ComboBox cbbColumn;
        private System.Windows.Forms.ComboBox cbbUser;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox grbGrantPrivilegesToRole;
        private System.Windows.Forms.Button btnLoadColumnRole;
        private System.Windows.Forms.Button btnApplyRole;
        private System.Windows.Forms.CheckBox cbDeleteRole;
        private System.Windows.Forms.CheckBox cbInsertRole;
        private System.Windows.Forms.CheckBox cbUpdateRole;
        private System.Windows.Forms.CheckBox cbSelectRole;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbbTableRole;
        private System.Windows.Forms.ComboBox cbbColumnRole;
        private System.Windows.Forms.ComboBox cbbRole;
        private System.Windows.Forms.GroupBox grbGrantRoleToUser;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbbUserRoleToUser;
        private System.Windows.Forms.ComboBox cbbRoleRoleToUser;
        private System.Windows.Forms.Button btnApplyRoleToUser;
        private System.Windows.Forms.CheckBox cbWithAdminOption;
        private System.Windows.Forms.Label label8;
    }
}

