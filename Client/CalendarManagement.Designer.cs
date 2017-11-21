﻿namespace Client
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("TreeViewAllSupport");
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabCreateCal = new System.Windows.Forms.TabPage();
            this.tevAllSupport = new System.Windows.Forms.TreeView();
            this.lblHelptxt2 = new System.Windows.Forms.Label();
            this.lblHelptxt1 = new System.Windows.Forms.Label();
            this.lblTitelSuppList = new System.Windows.Forms.Label();
            this.btnCreateCal = new System.Windows.Forms.Button();
            this.tabViewCal = new System.Windows.Forms.TabPage();
            this.dgvSupportCalendar = new System.Windows.Forms.DataGridView();
            this.btnFindCalendar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabEditCal = new System.Windows.Forms.TabPage();
            this.tabDeleteCal = new System.Windows.Forms.TabPage();
            this.listAllSupport = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.tabCreateCal.SuspendLayout();
            this.tabViewCal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupportCalendar)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabCreateCal);
            this.tabControl1.Controls.Add(this.tabViewCal);
            this.tabControl1.Controls.Add(this.tabEditCal);
            this.tabControl1.Controls.Add(this.tabDeleteCal);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(1, 2);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(786, 386);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // tabCreateCal
            // 
            this.tabCreateCal.Controls.Add(this.tevAllSupport);
            this.tabCreateCal.Controls.Add(this.lblHelptxt2);
            this.tabCreateCal.Controls.Add(this.lblHelptxt1);
            this.tabCreateCal.Controls.Add(this.listAllSupport);
            this.tabCreateCal.Controls.Add(this.lblTitelSuppList);
            this.tabCreateCal.Controls.Add(this.btnCreateCal);
            this.tabCreateCal.Location = new System.Drawing.Point(4, 31);
            this.tabCreateCal.Margin = new System.Windows.Forms.Padding(2);
            this.tabCreateCal.Name = "tabCreateCal";
            this.tabCreateCal.Padding = new System.Windows.Forms.Padding(2);
            this.tabCreateCal.Size = new System.Drawing.Size(778, 351);
            this.tabCreateCal.TabIndex = 0;
            this.tabCreateCal.Text = "Opret Kalender";
            this.tabCreateCal.UseVisualStyleBackColor = true;
            // 
            // tevAllSupport
            // 
            this.tevAllSupport.Location = new System.Drawing.Point(207, 75);
            this.tevAllSupport.Name = "tevAllSupport";
            treeNode1.Name = "TreeViewAllSupport";
            treeNode1.Text = "TreeViewAllSupport";
            this.tevAllSupport.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.tevAllSupport.ShowLines = false;
            this.tevAllSupport.ShowPlusMinus = false;
            this.tevAllSupport.ShowRootLines = false;
            this.tevAllSupport.Size = new System.Drawing.Size(166, 136);
            this.tevAllSupport.TabIndex = 10;
            // 
            // lblHelptxt2
            // 
            this.lblHelptxt2.AutoSize = true;
            this.lblHelptxt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelptxt2.Location = new System.Drawing.Point(22, 257);
            this.lblHelptxt2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHelptxt2.Name = "lblHelptxt2";
            this.lblHelptxt2.Size = new System.Drawing.Size(179, 17);
            this.lblHelptxt2.TabIndex = 9;
            this.lblHelptxt2.Text = "opret kalender til supporter";
            // 
            // lblHelptxt1
            // 
            this.lblHelptxt1.AutoSize = true;
            this.lblHelptxt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelptxt1.Location = new System.Drawing.Point(22, 46);
            this.lblHelptxt1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHelptxt1.Name = "lblHelptxt1";
            this.lblHelptxt1.Size = new System.Drawing.Size(203, 17);
            this.lblHelptxt1.TabIndex = 8;
            this.lblHelptxt1.Text = "Markér den ønskede supporter";
            // 
            // lblTitelSuppList
            // 
            this.lblTitelSuppList.AutoSize = true;
            this.lblTitelSuppList.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitelSuppList.Location = new System.Drawing.Point(16, 12);
            this.lblTitelSuppList.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitelSuppList.Name = "lblTitelSuppList";
            this.lblTitelSuppList.Size = new System.Drawing.Size(198, 24);
            this.lblTitelSuppList.TabIndex = 6;
            this.lblTitelSuppList.Text = "Supporter - Oversigt";
            // 
            // btnCreateCal
            // 
            this.btnCreateCal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateCal.Location = new System.Drawing.Point(39, 288);
            this.btnCreateCal.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreateCal.Name = "btnCreateCal";
            this.btnCreateCal.Size = new System.Drawing.Size(127, 42);
            this.btnCreateCal.TabIndex = 5;
            this.btnCreateCal.Text = "Opret Kalender";
            this.btnCreateCal.UseVisualStyleBackColor = true;
            this.btnCreateCal.Click += new System.EventHandler(this.btnCreateCal_Click);
            // 
            // tabViewCal
            // 
            this.tabViewCal.Controls.Add(this.dgvSupportCalendar);
            this.tabViewCal.Controls.Add(this.btnFindCalendar);
            this.tabViewCal.Controls.Add(this.textBox1);
            this.tabViewCal.Controls.Add(this.label1);
            this.tabViewCal.Location = new System.Drawing.Point(4, 31);
            this.tabViewCal.Margin = new System.Windows.Forms.Padding(2);
            this.tabViewCal.Name = "tabViewCal";
            this.tabViewCal.Padding = new System.Windows.Forms.Padding(2);
            this.tabViewCal.Size = new System.Drawing.Size(778, 351);
            this.tabViewCal.TabIndex = 1;
            this.tabViewCal.Text = "Se Kalender";
            this.tabViewCal.UseVisualStyleBackColor = true;
            // 
            // dgvSupportCalendar
            // 
            this.dgvSupportCalendar.AllowUserToAddRows = false;
            this.dgvSupportCalendar.AllowUserToDeleteRows = false;
            this.dgvSupportCalendar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSupportCalendar.Location = new System.Drawing.Point(20, 53);
            this.dgvSupportCalendar.Name = "dgvSupportCalendar";
            this.dgvSupportCalendar.ReadOnly = true;
            this.dgvSupportCalendar.RowHeadersVisible = false;
            this.dgvSupportCalendar.Size = new System.Drawing.Size(753, 293);
            this.dgvSupportCalendar.TabIndex = 3;
            // 
            // btnFindCalendar
            // 
            this.btnFindCalendar.Location = new System.Drawing.Point(646, 5);
            this.btnFindCalendar.Name = "btnFindCalendar";
            this.btnFindCalendar.Size = new System.Drawing.Size(127, 42);
            this.btnFindCalendar.TabIndex = 2;
            this.btnFindCalendar.Text = "Se Kalender";
            this.btnFindCalendar.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(495, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 28);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Support - Se Kalender";
            // 
            // tabEditCal
            // 
            this.tabEditCal.Location = new System.Drawing.Point(4, 31);
            this.tabEditCal.Margin = new System.Windows.Forms.Padding(2);
            this.tabEditCal.Name = "tabEditCal";
            this.tabEditCal.Padding = new System.Windows.Forms.Padding(2);
            this.tabEditCal.Size = new System.Drawing.Size(778, 351);
            this.tabEditCal.TabIndex = 2;
            this.tabEditCal.Text = "Rediger Kalender";
            this.tabEditCal.UseVisualStyleBackColor = true;
            // 
            // tabDeleteCal
            // 
            this.tabDeleteCal.Location = new System.Drawing.Point(4, 31);
            this.tabDeleteCal.Margin = new System.Windows.Forms.Padding(2);
            this.tabDeleteCal.Name = "tabDeleteCal";
            this.tabDeleteCal.Padding = new System.Windows.Forms.Padding(2);
            this.tabDeleteCal.Size = new System.Drawing.Size(778, 351);
            this.tabDeleteCal.TabIndex = 3;
            this.tabDeleteCal.Text = "Slet Kalender";
            this.tabDeleteCal.UseVisualStyleBackColor = true;
            // 
            // listAllSupport
            // 
            this.listAllSupport.FormattingEnabled = true;
            this.listAllSupport.ItemHeight = 22;
            this.listAllSupport.Location = new System.Drawing.Point(26, 75);
            this.listAllSupport.Margin = new System.Windows.Forms.Padding(2);
            this.listAllSupport.Name = "listAllSupport";
            this.listAllSupport.Size = new System.Drawing.Size(166, 136);
            this.listAllSupport.TabIndex = 7;
            // 
            // CalendarManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 394);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CalendarManagement";
            this.Text = "CalendarManagement";
            this.tabControl1.ResumeLayout(false);
            this.tabCreateCal.ResumeLayout(false);
            this.tabCreateCal.PerformLayout();
            this.tabViewCal.ResumeLayout(false);
            this.tabViewCal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupportCalendar)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.DataGridView dgvSupportCalendar;
        private System.Windows.Forms.Button btnFindCalendar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView tevAllSupport;
        private System.Windows.Forms.ListBox listAllSupport;
    }
}