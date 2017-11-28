namespace Client
{
    partial class CalendarManagement
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
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("TreeViewAllSupport");
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabCreateCal = new System.Windows.Forms.TabPage();
            this.tevAllSupport = new System.Windows.Forms.TreeView();
            this.lblHelptxt2 = new System.Windows.Forms.Label();
            this.lblHelptxt1 = new System.Windows.Forms.Label();
            this.lblTitelSuppList = new System.Windows.Forms.Label();
            this.btnCreateCal = new System.Windows.Forms.Button();
            this.tabViewCal = new System.Windows.Forms.TabPage();
            this.lvViewCalendar = new System.Windows.Forms.ListView();
            this.lblViewCalUserName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnFindCalendar = new System.Windows.Forms.Button();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabEditCal = new System.Windows.Forms.TabPage();
            this.tabDeleteCal = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblLoggedInUser = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl1.SuspendLayout();
            this.tabCreateCal.SuspendLayout();
            this.tabViewCal.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabCreateCal);
            this.tabControl1.Controls.Add(this.tabViewCal);
            this.tabControl1.Controls.Add(this.tabEditCal);
            this.tabControl1.Controls.Add(this.tabDeleteCal);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(1, 37);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1099, 478);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // tabCreateCal
            // 
            this.tabCreateCal.Controls.Add(this.tevAllSupport);
            this.tabCreateCal.Controls.Add(this.lblHelptxt2);
            this.tabCreateCal.Controls.Add(this.lblHelptxt1);
            this.tabCreateCal.Controls.Add(this.lblTitelSuppList);
            this.tabCreateCal.Controls.Add(this.btnCreateCal);
            this.tabCreateCal.Location = new System.Drawing.Point(4, 38);
            this.tabCreateCal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabCreateCal.Name = "tabCreateCal";
            this.tabCreateCal.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabCreateCal.Size = new System.Drawing.Size(1091, 436);
            this.tabCreateCal.TabIndex = 0;
            this.tabCreateCal.Text = "Opret Kalender";
            this.tabCreateCal.UseVisualStyleBackColor = true;
            // 
            // tevAllSupport
            // 
            this.tevAllSupport.Location = new System.Drawing.Point(33, 92);
            this.tevAllSupport.Margin = new System.Windows.Forms.Padding(4);
            this.tevAllSupport.Name = "tevAllSupport";
            treeNode3.Name = "TreeViewAllSupport";
            treeNode3.Text = "TreeViewAllSupport";
            this.tevAllSupport.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3});
            this.tevAllSupport.ShowLines = false;
            this.tevAllSupport.ShowPlusMinus = false;
            this.tevAllSupport.ShowRootLines = false;
            this.tevAllSupport.Size = new System.Drawing.Size(383, 166);
            this.tevAllSupport.TabIndex = 10;
            // 
            // lblHelptxt2
            // 
            this.lblHelptxt2.AutoSize = true;
            this.lblHelptxt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelptxt2.Location = new System.Drawing.Point(29, 316);
            this.lblHelptxt2.Name = "lblHelptxt2";
            this.lblHelptxt2.Size = new System.Drawing.Size(209, 20);
            this.lblHelptxt2.TabIndex = 9;
            this.lblHelptxt2.Text = "opret kalender til supporter";
            // 
            // lblHelptxt1
            // 
            this.lblHelptxt1.AutoSize = true;
            this.lblHelptxt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelptxt1.Location = new System.Drawing.Point(29, 57);
            this.lblHelptxt1.Name = "lblHelptxt1";
            this.lblHelptxt1.Size = new System.Drawing.Size(236, 20);
            this.lblHelptxt1.TabIndex = 8;
            this.lblHelptxt1.Text = "Markér den ønskede supporter";
            // 
            // lblTitelSuppList
            // 
            this.lblTitelSuppList.AutoSize = true;
            this.lblTitelSuppList.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitelSuppList.Location = new System.Drawing.Point(21, 15);
            this.lblTitelSuppList.Name = "lblTitelSuppList";
            this.lblTitelSuppList.Size = new System.Drawing.Size(250, 29);
            this.lblTitelSuppList.TabIndex = 6;
            this.lblTitelSuppList.Text = "Supporter - Oversigt";
            // 
            // btnCreateCal
            // 
            this.btnCreateCal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateCal.Location = new System.Drawing.Point(52, 354);
            this.btnCreateCal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreateCal.Name = "btnCreateCal";
            this.btnCreateCal.Size = new System.Drawing.Size(169, 52);
            this.btnCreateCal.TabIndex = 5;
            this.btnCreateCal.Text = "Opret Kalender";
            this.btnCreateCal.UseVisualStyleBackColor = true;
            this.btnCreateCal.Click += new System.EventHandler(this.btnCreateCal_Click);
            // 
            // tabViewCal
            // 
            this.tabViewCal.Controls.Add(this.lvViewCalendar);
            this.tabViewCal.Controls.Add(this.lblViewCalUserName);
            this.tabViewCal.Controls.Add(this.label3);
            this.tabViewCal.Controls.Add(this.btnFindCalendar);
            this.tabViewCal.Controls.Add(this.txtUserId);
            this.tabViewCal.Controls.Add(this.label1);
            this.tabViewCal.Location = new System.Drawing.Point(4, 38);
            this.tabViewCal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabViewCal.Name = "tabViewCal";
            this.tabViewCal.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabViewCal.Size = new System.Drawing.Size(1091, 436);
            this.tabViewCal.TabIndex = 1;
            this.tabViewCal.Text = "Se Kalender";
            this.tabViewCal.UseVisualStyleBackColor = true;
            // 
            // lvViewCalendar
            // 
            this.lvViewCalendar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.lvViewCalendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvViewCalendar.Location = new System.Drawing.Point(7, 65);
            this.lvViewCalendar.Name = "lvViewCalendar";
            this.lvViewCalendar.Size = new System.Drawing.Size(1017, 361);
            this.lvViewCalendar.TabIndex = 4;
            this.lvViewCalendar.UseCompatibleStateImageBehavior = false;
            this.lvViewCalendar.View = System.Windows.Forms.View.Details;
            // 
            // lblViewCalUserName
            // 
            this.lblViewCalUserName.AutoSize = true;
            this.lblViewCalUserName.Location = new System.Drawing.Point(431, 16);
            this.lblViewCalUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblViewCalUserName.Name = "lblViewCalUserName";
            this.lblViewCalUserName.Size = new System.Drawing.Size(31, 29);
            this.lblViewCalUserName.TabIndex = 3;
            this.lblViewCalUserName.Text = "...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(352, 16);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Navn:";
            // 
            // btnFindCalendar
            // 
            this.btnFindCalendar.Location = new System.Drawing.Point(905, 6);
            this.btnFindCalendar.Margin = new System.Windows.Forms.Padding(4);
            this.btnFindCalendar.Name = "btnFindCalendar";
            this.btnFindCalendar.Size = new System.Drawing.Size(169, 52);
            this.btnFindCalendar.TabIndex = 2;
            this.btnFindCalendar.Text = "Se Kalender";
            this.btnFindCalendar.UseVisualStyleBackColor = true;
            this.btnFindCalendar.Click += new System.EventHandler(this.btnFindCalendar_Click);
            // 
            // txtUserId
            // 
            this.txtUserId.Location = new System.Drawing.Point(740, 15);
            this.txtUserId.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(132, 34);
            this.txtUserId.TabIndex = 1;
            this.txtUserId.Text = "User ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Support - Se Kalender";
            // 
            // tabEditCal
            // 
            this.tabEditCal.Location = new System.Drawing.Point(4, 38);
            this.tabEditCal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabEditCal.Name = "tabEditCal";
            this.tabEditCal.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabEditCal.Size = new System.Drawing.Size(1091, 436);
            this.tabEditCal.TabIndex = 2;
            this.tabEditCal.Text = "Rediger Kalender";
            this.tabEditCal.UseVisualStyleBackColor = true;
            // 
            // tabDeleteCal
            // 
            this.tabDeleteCal.Location = new System.Drawing.Point(4, 38);
            this.tabDeleteCal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabDeleteCal.Name = "tabDeleteCal";
            this.tabDeleteCal.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabDeleteCal.Size = new System.Drawing.Size(1091, 436);
            this.tabDeleteCal.TabIndex = 3;
            this.tabDeleteCal.Text = "Slet Kalender";
            this.tabDeleteCal.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bruger:";
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(984, 9);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(100, 28);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Log ud";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblLoggedInUser
            // 
            this.lblLoggedInUser.AutoSize = true;
            this.lblLoggedInUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoggedInUser.Location = new System.Drawing.Point(87, 9);
            this.lblLoggedInUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLoggedInUser.Name = "lblLoggedInUser";
            this.lblLoggedInUser.Size = new System.Drawing.Size(21, 20);
            this.lblLoggedInUser.TabIndex = 4;
            this.lblLoggedInUser.Text = "...";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(875, 9);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 28);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Tilbage";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tid";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Mandag";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tirsdag";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Onsdag";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Torsdag";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Fredag";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Lørdag";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Søndag";
            // 
            // CalendarManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 513);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblLoggedInUser);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CalendarManagement";
            this.Text = "CalendarManagement";
            this.tabControl1.ResumeLayout(false);
            this.tabCreateCal.ResumeLayout(false);
            this.tabCreateCal.PerformLayout();
            this.tabViewCal.ResumeLayout(false);
            this.tabViewCal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabCreateCal;
        private System.Windows.Forms.TabPage tabViewCal;
        private System.Windows.Forms.TabPage tabEditCal;
        private System.Windows.Forms.TabPage tabDeleteCal;
        private System.Windows.Forms.Button btnCreateCal;
        private System.Windows.Forms.Label lblHelptxt1;
        private System.Windows.Forms.Label lblTitelSuppList;
        private System.Windows.Forms.Label lblHelptxt2;
        private System.Windows.Forms.Button btnFindCalendar;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView tevAllSupport;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblViewCalUserName;
        private System.Windows.Forms.Label lblLoggedInUser;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ListView lvViewCalendar;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
    }
}