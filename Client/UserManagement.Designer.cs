namespace Client
{
    partial class UserManagement
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpCreateUser = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.Label();
            this.cbUserRole = new System.Windows.Forms.ComboBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbUserLastName = new System.Windows.Forms.TextBox();
            this.tbUserFirstName = new System.Windows.Forms.TextBox();
            this.tbUserId = new System.Windows.Forms.TextBox();
            this.btnCreateUser = new System.Windows.Forms.Button();
            this.tpViewUser = new System.Windows.Forms.TabPage();
            this.tpEditUser = new System.Windows.Forms.TabPage();
            this.tpDeleteUser = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInputUserId = new System.Windows.Forms.TextBox();
            this.btnSearchUser = new System.Windows.Forms.Button();
            this.firstName = new System.Windows.Forms.Label();
            this.lastName = new System.Windows.Forms.Label();
            this.role = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tpCreateUser.SuspendLayout();
            this.tpViewUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpCreateUser);
            this.tabControl1.Controls.Add(this.tpViewUser);
            this.tabControl1.Controls.Add(this.tpEditUser);
            this.tabControl1.Controls.Add(this.tpDeleteUser);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(894, 589);
            this.tabControl1.TabIndex = 0;
            // 
            // tpCreateUser
            // 
            this.tpCreateUser.Controls.Add(this.label5);
            this.tpCreateUser.Controls.Add(this.label4);
            this.tpCreateUser.Controls.Add(this.label3);
            this.tpCreateUser.Controls.Add(this.label2);
            this.tpCreateUser.Controls.Add(this.Id);
            this.tpCreateUser.Controls.Add(this.cbUserRole);
            this.tpCreateUser.Controls.Add(this.tbPassword);
            this.tpCreateUser.Controls.Add(this.tbUserLastName);
            this.tpCreateUser.Controls.Add(this.tbUserFirstName);
            this.tpCreateUser.Controls.Add(this.tbUserId);
            this.tpCreateUser.Controls.Add(this.btnCreateUser);
            this.tpCreateUser.Location = new System.Drawing.Point(4, 35);
            this.tpCreateUser.Name = "tpCreateUser";
            this.tpCreateUser.Padding = new System.Windows.Forms.Padding(3);
            this.tpCreateUser.Size = new System.Drawing.Size(532, 410);
            this.tpCreateUser.TabIndex = 0;
            this.tpCreateUser.Text = "Opret Bruger";
            this.tpCreateUser.UseVisualStyleBackColor = true;
            this.tpCreateUser.Click += new System.EventHandler(this.tpCreateUser_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 26);
            this.label5.TabIndex = 10;
            this.label5.Text = "Rolle";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 26);
            this.label4.TabIndex = 9;
            this.label4.Text = "Kodeord";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 26);
            this.label3.TabIndex = 8;
            this.label3.Text = "Efternavn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 26);
            this.label2.TabIndex = 7;
            this.label2.Text = "Fornavn";
            // 
            // Id
            // 
            this.Id.AutoSize = true;
            this.Id.Location = new System.Drawing.Point(29, 24);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(30, 26);
            this.Id.TabIndex = 6;
            this.Id.Text = "Id";
            // 
            // cbUserRole
            // 
            this.cbUserRole.FormattingEnabled = true;
            this.cbUserRole.Items.AddRange(new object[] {
            "Admin",
            "Supporter",
            "Sælger"});
            this.cbUserRole.Location = new System.Drawing.Point(29, 126);
            this.cbUserRole.Name = "cbUserRole";
            this.cbUserRole.Size = new System.Drawing.Size(121, 34);
            this.cbUserRole.TabIndex = 5;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(29, 338);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(100, 32);
            this.tbPassword.TabIndex = 4;
            // 
            // tbUserLastName
            // 
            this.tbUserLastName.Location = new System.Drawing.Point(29, 268);
            this.tbUserLastName.Name = "tbUserLastName";
            this.tbUserLastName.Size = new System.Drawing.Size(100, 32);
            this.tbUserLastName.TabIndex = 3;
            // 
            // tbUserFirstName
            // 
            this.tbUserFirstName.Location = new System.Drawing.Point(29, 198);
            this.tbUserFirstName.Name = "tbUserFirstName";
            this.tbUserFirstName.Size = new System.Drawing.Size(100, 32);
            this.tbUserFirstName.TabIndex = 2;
            // 
            // tbUserId
            // 
            this.tbUserId.Location = new System.Drawing.Point(29, 56);
            this.tbUserId.Name = "tbUserId";
            this.tbUserId.Size = new System.Drawing.Size(100, 32);
            this.tbUserId.TabIndex = 1;
            // 
            // btnCreateUser
            // 
            this.btnCreateUser.Location = new System.Drawing.Point(336, 338);
            this.btnCreateUser.Name = "btnCreateUser";
            this.btnCreateUser.Size = new System.Drawing.Size(169, 52);
            this.btnCreateUser.TabIndex = 0;
            this.btnCreateUser.Text = "Opret Bruger";
            this.btnCreateUser.UseVisualStyleBackColor = true;
            this.btnCreateUser.Click += new System.EventHandler(this.btnCreateUser_Click);
            // 
            // tpViewUser
            // 
            this.tpViewUser.Controls.Add(this.lblRole);
            this.tpViewUser.Controls.Add(this.lblLastName);
            this.tpViewUser.Controls.Add(this.lblFirstName);
            this.tpViewUser.Controls.Add(this.role);
            this.tpViewUser.Controls.Add(this.lastName);
            this.tpViewUser.Controls.Add(this.firstName);
            this.tpViewUser.Controls.Add(this.btnSearchUser);
            this.tpViewUser.Controls.Add(this.txtInputUserId);
            this.tpViewUser.Controls.Add(this.label1);
            this.tpViewUser.Location = new System.Drawing.Point(4, 35);
            this.tpViewUser.Name = "tpViewUser";
            this.tpViewUser.Padding = new System.Windows.Forms.Padding(3);
            this.tpViewUser.Size = new System.Drawing.Size(886, 550);
            this.tpViewUser.TabIndex = 1;
            this.tpViewUser.Text = "Se Bruger";
            this.tpViewUser.UseVisualStyleBackColor = true;
            // 
            // tpEditUser
            // 
            this.tpEditUser.Location = new System.Drawing.Point(4, 35);
            this.tpEditUser.Name = "tpEditUser";
            this.tpEditUser.Size = new System.Drawing.Size(532, 410);
            this.tpEditUser.TabIndex = 2;
            this.tpEditUser.Text = "Rediger Bruger";
            this.tpEditUser.UseVisualStyleBackColor = true;
            // 
            // tpDeleteUser
            // 
            this.tpDeleteUser.Location = new System.Drawing.Point(4, 35);
            this.tpDeleteUser.Name = "tpDeleteUser";
            this.tpDeleteUser.Size = new System.Drawing.Size(532, 410);
            this.tpDeleteUser.TabIndex = 3;
            this.tpDeleteUser.Text = "Slet Bruger";
            this.tpDeleteUser.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bruger id";
            // 
            // txtInputUserId
            // 
            this.txtInputUserId.Location = new System.Drawing.Point(38, 59);
            this.txtInputUserId.Name = "txtInputUserId";
            this.txtInputUserId.Size = new System.Drawing.Size(100, 32);
            this.txtInputUserId.TabIndex = 1;
            // 
            // btnSearchUser
            // 
            this.btnSearchUser.Location = new System.Drawing.Point(38, 104);
            this.btnSearchUser.Name = "btnSearchUser";
            this.btnSearchUser.Size = new System.Drawing.Size(105, 54);
            this.btnSearchUser.TabIndex = 2;
            this.btnSearchUser.Text = "Søg";
            this.btnSearchUser.UseVisualStyleBackColor = true;
            this.btnSearchUser.Click += new System.EventHandler(this.btnSearchUser_Click);
            // 
            // firstName
            // 
            this.firstName.AutoSize = true;
            this.firstName.Location = new System.Drawing.Point(38, 231);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(97, 26);
            this.firstName.TabIndex = 3;
            this.firstName.Text = "Fornavn:";
            // 
            // lastName
            // 
            this.lastName.AutoSize = true;
            this.lastName.Location = new System.Drawing.Point(38, 270);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(111, 26);
            this.lastName.TabIndex = 4;
            this.lastName.Text = "Efternavn:";
            // 
            // role
            // 
            this.role.AutoSize = true;
            this.role.Location = new System.Drawing.Point(38, 192);
            this.role.Name = "role";
            this.role.Size = new System.Drawing.Size(68, 26);
            this.role.TabIndex = 5;
            this.role.Text = "Rolle:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(156, 231);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(70, 26);
            this.lblFirstName.TabIndex = 6;
            this.lblFirstName.Text = "label9";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(156, 270);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(82, 26);
            this.lblLastName.TabIndex = 7;
            this.lblLastName.Text = "label10";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(156, 192);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(82, 26);
            this.lblRole.TabIndex = 8;
            this.lblRole.Text = "label11";
            // 
            // UserManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 611);
            this.Controls.Add(this.tabControl1);
            this.Name = "UserManagement";
            this.Text = "UserManagement";
            this.Load += new System.EventHandler(this.UserManagement_Load);
            this.tabControl1.ResumeLayout(false);
            this.tpCreateUser.ResumeLayout(false);
            this.tpCreateUser.PerformLayout();
            this.tpViewUser.ResumeLayout(false);
            this.tpViewUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpCreateUser;
        private System.Windows.Forms.TabPage tpViewUser;
        private System.Windows.Forms.TabPage tpEditUser;
        private System.Windows.Forms.TabPage tpDeleteUser;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Id;
        private System.Windows.Forms.ComboBox cbUserRole;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbUserLastName;
        private System.Windows.Forms.TextBox tbUserFirstName;
        private System.Windows.Forms.TextBox tbUserId;
        private System.Windows.Forms.Button btnCreateUser;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label role;
        private System.Windows.Forms.Label lastName;
        private System.Windows.Forms.Label firstName;
        private System.Windows.Forms.Button btnSearchUser;
        private System.Windows.Forms.TextBox txtInputUserId;
        private System.Windows.Forms.Label label1;
    }
}