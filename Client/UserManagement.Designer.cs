﻿namespace Client
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
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.lblButik22 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
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
            this.lblDepartment = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tevAllUsers = new System.Windows.Forms.TreeView();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.role = new System.Windows.Forms.Label();
            this.lastName = new System.Windows.Forms.Label();
            this.firstName = new System.Windows.Forms.Label();
            this.btnSearchUser = new System.Windows.Forms.Button();
            this.txtInputUserId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tpEditUser = new System.Windows.Forms.TabPage();
            this.tpDeleteUser = new System.Windows.Forms.TabPage();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblLoggedInUser = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
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
            this.tabControl1.Location = new System.Drawing.Point(1, 30);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(593, 514);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // tpCreateUser
            // 
            this.tpCreateUser.Controls.Add(this.txtDepartment);
            this.tpCreateUser.Controls.Add(this.lblButik22);
            this.tpCreateUser.Controls.Add(this.label7);
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
            this.tpCreateUser.Location = new System.Drawing.Point(4, 31);
            this.tpCreateUser.Margin = new System.Windows.Forms.Padding(2);
            this.tpCreateUser.Name = "tpCreateUser";
            this.tpCreateUser.Padding = new System.Windows.Forms.Padding(2);
            this.tpCreateUser.Size = new System.Drawing.Size(585, 479);
            this.tpCreateUser.TabIndex = 0;
            this.tpCreateUser.Text = "Opret Bruger";
            this.tpCreateUser.UseVisualStyleBackColor = true;
            this.tpCreateUser.Click += new System.EventHandler(this.tpCreateUser_Click);
            // 
            // txtDepartment
            // 
            this.txtDepartment.Location = new System.Drawing.Point(26, 373);
            this.txtDepartment.Margin = new System.Windows.Forms.Padding(2);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(76, 27);
            this.txtDepartment.TabIndex = 13;
            // 
            // lblButik22
            // 
            this.lblButik22.AutoSize = true;
            this.lblButik22.Location = new System.Drawing.Point(26, 347);
            this.lblButik22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblButik22.Name = "lblButik22";
            this.lblButik22.Size = new System.Drawing.Size(74, 22);
            this.lblButik22.TabIndex = 12;
            this.lblButik22.Text = "Butik Nr";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 20);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 24);
            this.label7.TabIndex = 11;
            this.label7.Text = "Udfyld felterne";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 118);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 22);
            this.label5.TabIndex = 10;
            this.label5.Text = "Rolle";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 290);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 22);
            this.label4.TabIndex = 9;
            this.label4.Text = "Kodeord";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 233);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "Efternavn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 176);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "Fornavn";
            // 
            // Id
            // 
            this.Id.AutoSize = true;
            this.Id.Location = new System.Drawing.Point(26, 61);
            this.Id.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(24, 22);
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
            this.cbUserRole.Location = new System.Drawing.Point(26, 144);
            this.cbUserRole.Margin = new System.Windows.Forms.Padding(2);
            this.cbUserRole.Name = "cbUserRole";
            this.cbUserRole.Size = new System.Drawing.Size(113, 30);
            this.cbUserRole.TabIndex = 5;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(26, 316);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(2);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(113, 27);
            this.tbPassword.TabIndex = 4;
            // 
            // tbUserLastName
            // 
            this.tbUserLastName.Location = new System.Drawing.Point(26, 259);
            this.tbUserLastName.Margin = new System.Windows.Forms.Padding(2);
            this.tbUserLastName.Name = "tbUserLastName";
            this.tbUserLastName.Size = new System.Drawing.Size(113, 27);
            this.tbUserLastName.TabIndex = 3;
            // 
            // tbUserFirstName
            // 
            this.tbUserFirstName.Location = new System.Drawing.Point(26, 202);
            this.tbUserFirstName.Margin = new System.Windows.Forms.Padding(2);
            this.tbUserFirstName.Name = "tbUserFirstName";
            this.tbUserFirstName.Size = new System.Drawing.Size(113, 27);
            this.tbUserFirstName.TabIndex = 2;
            // 
            // tbUserId
            // 
            this.tbUserId.Location = new System.Drawing.Point(26, 87);
            this.tbUserId.Margin = new System.Windows.Forms.Padding(2);
            this.tbUserId.Name = "tbUserId";
            this.tbUserId.Size = new System.Drawing.Size(113, 27);
            this.tbUserId.TabIndex = 1;
            // 
            // btnCreateUser
            // 
            this.btnCreateUser.Location = new System.Drawing.Point(22, 414);
            this.btnCreateUser.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreateUser.Name = "btnCreateUser";
            this.btnCreateUser.Size = new System.Drawing.Size(127, 42);
            this.btnCreateUser.TabIndex = 0;
            this.btnCreateUser.Text = "Opret Bruger";
            this.btnCreateUser.UseVisualStyleBackColor = true;
            this.btnCreateUser.Click += new System.EventHandler(this.btnCreateUser_Click);
            // 
            // tpViewUser
            // 
            this.tpViewUser.Controls.Add(this.lblDepartment);
            this.tpViewUser.Controls.Add(this.label13);
            this.tpViewUser.Controls.Add(this.tevAllUsers);
            this.tpViewUser.Controls.Add(this.label12);
            this.tpViewUser.Controls.Add(this.label11);
            this.tpViewUser.Controls.Add(this.label10);
            this.tpViewUser.Controls.Add(this.label9);
            this.tpViewUser.Controls.Add(this.label8);
            this.tpViewUser.Controls.Add(this.lblPassword);
            this.tpViewUser.Controls.Add(this.label6);
            this.tpViewUser.Controls.Add(this.lblRole);
            this.tpViewUser.Controls.Add(this.lblLastName);
            this.tpViewUser.Controls.Add(this.lblFirstName);
            this.tpViewUser.Controls.Add(this.role);
            this.tpViewUser.Controls.Add(this.lastName);
            this.tpViewUser.Controls.Add(this.firstName);
            this.tpViewUser.Controls.Add(this.btnSearchUser);
            this.tpViewUser.Controls.Add(this.txtInputUserId);
            this.tpViewUser.Controls.Add(this.label1);
            this.tpViewUser.Location = new System.Drawing.Point(4, 31);
            this.tpViewUser.Margin = new System.Windows.Forms.Padding(2);
            this.tpViewUser.Name = "tpViewUser";
            this.tpViewUser.Padding = new System.Windows.Forms.Padding(2);
            this.tpViewUser.Size = new System.Drawing.Size(585, 479);
            this.tpViewUser.TabIndex = 1;
            this.tpViewUser.Text = "Se Bruger";
            this.tpViewUser.UseVisualStyleBackColor = true;
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(124, 356);
            this.lblDepartment.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(25, 22);
            this.lblDepartment.TabIndex = 19;
            this.lblDepartment.Text = "...";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(32, 356);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 22);
            this.label13.TabIndex = 18;
            this.label13.Text = "Butik:";
            // 
            // tevAllUsers
            // 
            this.tevAllUsers.Location = new System.Drawing.Point(316, 102);
            this.tevAllUsers.Margin = new System.Windows.Forms.Padding(2);
            this.tevAllUsers.Name = "tevAllUsers";
            this.tevAllUsers.ShowLines = false;
            this.tevAllUsers.ShowPlusMinus = false;
            this.tevAllUsers.ShowRootLines = false;
            this.tevAllUsers.Size = new System.Drawing.Size(252, 294);
            this.tevAllUsers.TabIndex = 17;
            this.tevAllUsers.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tevAllUsers_AfterSelect);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(14, 11);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(168, 26);
            this.label12.TabIndex = 16;
            this.label12.Text = "Søg efter bruger";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(313, 46);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(259, 41);
            this.label11.TabIndex = 15;
            this.label11.Text = "Markér bruger og tryk søg for at se yderligere information";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(348, 11);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(188, 26);
            this.label10.TabIndex = 14;
            this.label10.Text = "Oprettede brugere";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(14, 158);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(185, 26);
            this.label9.TabIndex = 13;
            this.label9.Text = "Brugerinformation";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(58, 52);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Indsæt brugerid";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(124, 324);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(25, 22);
            this.lblPassword.TabIndex = 10;
            this.lblPassword.Text = "...";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 324);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 22);
            this.label6.TabIndex = 9;
            this.label6.Text = "Kode:";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(124, 219);
            this.lblRole.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(25, 22);
            this.lblRole.TabIndex = 8;
            this.lblRole.Text = "...";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(124, 289);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(25, 22);
            this.lblLastName.TabIndex = 7;
            this.lblLastName.Text = "...";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(124, 251);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(25, 22);
            this.lblFirstName.TabIndex = 6;
            this.lblFirstName.Text = "...";
            // 
            // role
            // 
            this.role.AutoSize = true;
            this.role.Location = new System.Drawing.Point(32, 219);
            this.role.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.role.Name = "role";
            this.role.Size = new System.Drawing.Size(56, 22);
            this.role.TabIndex = 5;
            this.role.Text = "Rolle:";
            // 
            // lastName
            // 
            this.lastName.AutoSize = true;
            this.lastName.Location = new System.Drawing.Point(32, 289);
            this.lastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(92, 22);
            this.lastName.TabIndex = 4;
            this.lastName.Text = "Efternavn:";
            // 
            // firstName
            // 
            this.firstName.AutoSize = true;
            this.firstName.Location = new System.Drawing.Point(32, 251);
            this.firstName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(81, 22);
            this.firstName.TabIndex = 3;
            this.firstName.Text = "Fornavn:";
            // 
            // btnSearchUser
            // 
            this.btnSearchUser.Location = new System.Drawing.Point(200, 91);
            this.btnSearchUser.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchUser.Name = "btnSearchUser";
            this.btnSearchUser.Size = new System.Drawing.Size(56, 29);
            this.btnSearchUser.TabIndex = 2;
            this.btnSearchUser.Text = "Søg";
            this.btnSearchUser.UseVisualStyleBackColor = true;
            this.btnSearchUser.Click += new System.EventHandler(this.btnSearchUser_Click);
            // 
            // txtInputUserId
            // 
            this.txtInputUserId.Location = new System.Drawing.Point(112, 93);
            this.txtInputUserId.Margin = new System.Windows.Forms.Padding(2);
            this.txtInputUserId.Name = "txtInputUserId";
            this.txtInputUserId.Size = new System.Drawing.Size(76, 27);
            this.txtInputUserId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 95);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Brugerid:";
            // 
            // tpEditUser
            // 
            this.tpEditUser.Location = new System.Drawing.Point(4, 31);
            this.tpEditUser.Margin = new System.Windows.Forms.Padding(2);
            this.tpEditUser.Name = "tpEditUser";
            this.tpEditUser.Size = new System.Drawing.Size(585, 479);
            this.tpEditUser.TabIndex = 2;
            this.tpEditUser.Text = "Rediger Bruger";
            this.tpEditUser.UseVisualStyleBackColor = true;
            // 
            // tpDeleteUser
            // 
            this.tpDeleteUser.Location = new System.Drawing.Point(4, 31);
            this.tpDeleteUser.Margin = new System.Windows.Forms.Padding(2);
            this.tpDeleteUser.Name = "tpDeleteUser";
            this.tpDeleteUser.Size = new System.Drawing.Size(585, 479);
            this.tpDeleteUser.TabIndex = 3;
            this.tpDeleteUser.Text = "Slet Bruger";
            this.tpDeleteUser.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(427, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Tilbage";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblLoggedInUser
            // 
            this.lblLoggedInUser.AutoSize = true;
            this.lblLoggedInUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoggedInUser.Location = new System.Drawing.Point(65, 7);
            this.lblLoggedInUser.Name = "lblLoggedInUser";
            this.lblLoggedInUser.Size = new System.Drawing.Size(17, 16);
            this.lblLoggedInUser.TabIndex = 8;
            this.lblLoggedInUser.Text = "...";
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(509, 4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Log ud";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(12, 7);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 16);
            this.label14.TabIndex = 6;
            this.label14.Text = "Bruger:";
            // 
            // UserManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 543);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblLoggedInUser);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UserManagement";
            this.Text = "Bruger Styring";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserManagement_FormClosing);
            this.Load += new System.EventHandler(this.UserManagement_Load);
            this.tabControl1.ResumeLayout(false);
            this.tpCreateUser.ResumeLayout(false);
            this.tpCreateUser.PerformLayout();
            this.tpViewUser.ResumeLayout(false);
            this.tpViewUser.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TreeView tevAllUsers;
        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.Label lblButik22;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblLoggedInUser;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label label14;
    }
}