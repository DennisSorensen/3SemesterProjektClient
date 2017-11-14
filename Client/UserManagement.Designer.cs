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
            this.tpViewUser = new System.Windows.Forms.TabPage();
            this.tpEditUser = new System.Windows.Forms.TabPage();
            this.tpDeleteUser = new System.Windows.Forms.TabPage();
            this.btnCreateUser = new System.Windows.Forms.Button();
            this.tbUserId = new System.Windows.Forms.TextBox();
            this.tbUserFirstName = new System.Windows.Forms.TextBox();
            this.tbUserLastName = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.cbUserRole = new System.Windows.Forms.ComboBox();
            this.Id = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tpCreateUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpCreateUser);
            this.tabControl1.Controls.Add(this.tpViewUser);
            this.tabControl1.Controls.Add(this.tpEditUser);
            this.tabControl1.Controls.Add(this.tpDeleteUser);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(540, 449);
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
            this.tpCreateUser.Location = new System.Drawing.Point(4, 25);
            this.tpCreateUser.Name = "tpCreateUser";
            this.tpCreateUser.Padding = new System.Windows.Forms.Padding(3);
            this.tpCreateUser.Size = new System.Drawing.Size(532, 420);
            this.tpCreateUser.TabIndex = 0;
            this.tpCreateUser.Text = "Opret Bruger";
            this.tpCreateUser.UseVisualStyleBackColor = true;
            // 
            // tpViewUser
            // 
            this.tpViewUser.Location = new System.Drawing.Point(4, 25);
            this.tpViewUser.Name = "tpViewUser";
            this.tpViewUser.Padding = new System.Windows.Forms.Padding(3);
            this.tpViewUser.Size = new System.Drawing.Size(532, 420);
            this.tpViewUser.TabIndex = 1;
            this.tpViewUser.Text = "Se Bruger";
            this.tpViewUser.UseVisualStyleBackColor = true;
            // 
            // tpEditUser
            // 
            this.tpEditUser.Location = new System.Drawing.Point(4, 25);
            this.tpEditUser.Name = "tpEditUser";
            this.tpEditUser.Size = new System.Drawing.Size(532, 420);
            this.tpEditUser.TabIndex = 2;
            this.tpEditUser.Text = "Rediger Bruger";
            this.tpEditUser.UseVisualStyleBackColor = true;
            // 
            // tpDeleteUser
            // 
            this.tpDeleteUser.Location = new System.Drawing.Point(4, 25);
            this.tpDeleteUser.Name = "tpDeleteUser";
            this.tpDeleteUser.Size = new System.Drawing.Size(532, 420);
            this.tpDeleteUser.TabIndex = 3;
            this.tpDeleteUser.Text = "Slet Bruger";
            this.tpDeleteUser.UseVisualStyleBackColor = true;
            // 
            // btnCreateUser
            // 
            this.btnCreateUser.Location = new System.Drawing.Point(382, 366);
            this.btnCreateUser.Name = "btnCreateUser";
            this.btnCreateUser.Size = new System.Drawing.Size(121, 34);
            this.btnCreateUser.TabIndex = 0;
            this.btnCreateUser.Text = "Opret Bruger";
            this.btnCreateUser.UseVisualStyleBackColor = true;
            this.btnCreateUser.Click += new System.EventHandler(this.btnCreateUser_Click);
            // 
            // tbUserId
            // 
            this.tbUserId.Location = new System.Drawing.Point(78, 70);
            this.tbUserId.Name = "tbUserId";
            this.tbUserId.Size = new System.Drawing.Size(100, 22);
            this.tbUserId.TabIndex = 1;
            // 
            // tbUserFirstName
            // 
            this.tbUserFirstName.Location = new System.Drawing.Point(81, 169);
            this.tbUserFirstName.Name = "tbUserFirstName";
            this.tbUserFirstName.Size = new System.Drawing.Size(100, 22);
            this.tbUserFirstName.TabIndex = 2;
            // 
            // tbUserLastName
            // 
            this.tbUserLastName.Location = new System.Drawing.Point(78, 214);
            this.tbUserLastName.Name = "tbUserLastName";
            this.tbUserLastName.Size = new System.Drawing.Size(100, 22);
            this.tbUserLastName.TabIndex = 3;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(78, 286);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(100, 22);
            this.tbPassword.TabIndex = 4;
            // 
            // cbUserRole
            // 
            this.cbUserRole.FormattingEnabled = true;
            this.cbUserRole.Items.AddRange(new object[] {
            "Admin",
            "Supporter",
            "Sælger"});
            this.cbUserRole.Location = new System.Drawing.Point(78, 125);
            this.cbUserRole.Name = "cbUserRole";
            this.cbUserRole.Size = new System.Drawing.Size(121, 24);
            this.cbUserRole.TabIndex = 5;
            // 
            // Id
            // 
            this.Id.AutoSize = true;
            this.Id.Location = new System.Drawing.Point(75, 50);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(19, 17);
            this.Id.TabIndex = 6;
            this.Id.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Fornavn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Efternavn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Kodeord";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(75, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Rolle";
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
    }
}