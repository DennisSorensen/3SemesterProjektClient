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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabCreateCal = new System.Windows.Forms.TabPage();
            this.lblHelptxt2 = new System.Windows.Forms.Label();
            this.lblHelptxt1 = new System.Windows.Forms.Label();
            this.listAllSupport = new System.Windows.Forms.ListBox();
            this.lblTitelSuppList = new System.Windows.Forms.Label();
            this.btnCreateCal = new System.Windows.Forms.Button();
            this.tabViewCal = new System.Windows.Forms.TabPage();
            this.tabEditCal = new System.Windows.Forms.TabPage();
            this.tabDeleteCal = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabCreateCal.SuspendLayout();
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
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1048, 475);
            this.tabControl1.TabIndex = 0;
            // 
            // tabCreateCal
            // 
            this.tabCreateCal.Controls.Add(this.lblHelptxt2);
            this.tabCreateCal.Controls.Add(this.lblHelptxt1);
            this.tabCreateCal.Controls.Add(this.listAllSupport);
            this.tabCreateCal.Controls.Add(this.lblTitelSuppList);
            this.tabCreateCal.Controls.Add(this.btnCreateCal);
            this.tabCreateCal.Location = new System.Drawing.Point(4, 38);
            this.tabCreateCal.Name = "tabCreateCal";
            this.tabCreateCal.Padding = new System.Windows.Forms.Padding(3);
            this.tabCreateCal.Size = new System.Drawing.Size(1040, 433);
            this.tabCreateCal.TabIndex = 0;
            this.tabCreateCal.Text = "Opret Kalender";
            this.tabCreateCal.UseVisualStyleBackColor = true;
            // 
            // lblHelptxt2
            // 
            this.lblHelptxt2.AutoSize = true;
            this.lblHelptxt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelptxt2.Location = new System.Drawing.Point(30, 316);
            this.lblHelptxt2.Name = "lblHelptxt2";
            this.lblHelptxt2.Size = new System.Drawing.Size(209, 20);
            this.lblHelptxt2.TabIndex = 9;
            this.lblHelptxt2.Text = "opret kalender til supporter";
            // 
            // lblHelptxt1
            // 
            this.lblHelptxt1.AutoSize = true;
            this.lblHelptxt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelptxt1.Location = new System.Drawing.Point(30, 57);
            this.lblHelptxt1.Name = "lblHelptxt1";
            this.lblHelptxt1.Size = new System.Drawing.Size(236, 20);
            this.lblHelptxt1.TabIndex = 8;
            this.lblHelptxt1.Text = "Markér den ønskede supporter";
            // 
            // listAllSupport
            // 
            this.listAllSupport.FormattingEnabled = true;
            this.listAllSupport.ItemHeight = 29;
            this.listAllSupport.Location = new System.Drawing.Point(34, 92);
            this.listAllSupport.Name = "listAllSupport";
            this.listAllSupport.Size = new System.Drawing.Size(220, 178);
            this.listAllSupport.TabIndex = 7;
            // 
            // lblTitelSuppList
            // 
            this.lblTitelSuppList.AutoSize = true;
            this.lblTitelSuppList.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitelSuppList.Location = new System.Drawing.Point(21, 15);
            this.lblTitelSuppList.Name = "lblTitelSuppList";
            this.lblTitelSuppList.Size = new System.Drawing.Size(245, 29);
            this.lblTitelSuppList.TabIndex = 6;
            this.lblTitelSuppList.Text = "Supporter - oversigt";
            // 
            // btnCreateCal
            // 
            this.btnCreateCal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateCal.Location = new System.Drawing.Point(52, 355);
            this.btnCreateCal.Name = "btnCreateCal";
            this.btnCreateCal.Size = new System.Drawing.Size(169, 52);
            this.btnCreateCal.TabIndex = 5;
            this.btnCreateCal.Text = "Opret Kalender";
            this.btnCreateCal.UseVisualStyleBackColor = true;
            this.btnCreateCal.Click += new System.EventHandler(this.btnCreateCal_Click);
            // 
            // tabViewCal
            // 
            this.tabViewCal.Location = new System.Drawing.Point(4, 38);
            this.tabViewCal.Name = "tabViewCal";
            this.tabViewCal.Padding = new System.Windows.Forms.Padding(3);
            this.tabViewCal.Size = new System.Drawing.Size(1040, 433);
            this.tabViewCal.TabIndex = 1;
            this.tabViewCal.Text = "Se Kalender";
            this.tabViewCal.UseVisualStyleBackColor = true;
            // 
            // tabEditCal
            // 
            this.tabEditCal.Location = new System.Drawing.Point(4, 38);
            this.tabEditCal.Name = "tabEditCal";
            this.tabEditCal.Padding = new System.Windows.Forms.Padding(3);
            this.tabEditCal.Size = new System.Drawing.Size(1040, 433);
            this.tabEditCal.TabIndex = 2;
            this.tabEditCal.Text = "Rediger Kalender";
            this.tabEditCal.UseVisualStyleBackColor = true;
            // 
            // tabDeleteCal
            // 
            this.tabDeleteCal.Location = new System.Drawing.Point(4, 38);
            this.tabDeleteCal.Name = "tabDeleteCal";
            this.tabDeleteCal.Padding = new System.Windows.Forms.Padding(3);
            this.tabDeleteCal.Size = new System.Drawing.Size(1040, 433);
            this.tabDeleteCal.TabIndex = 3;
            this.tabDeleteCal.Text = "Slet Kalender";
            this.tabDeleteCal.UseVisualStyleBackColor = true;
            // 
            // CalendarManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 479);
            this.Controls.Add(this.tabControl1);
            this.Name = "CalendarManagement";
            this.Text = "CalendarManagement";
          
            this.tabControl1.ResumeLayout(false);
            this.tabCreateCal.ResumeLayout(false);
            this.tabCreateCal.PerformLayout();
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
        private System.Windows.Forms.ListBox listAllSupport;
        private System.Windows.Forms.Label lblTitelSuppList;
        private System.Windows.Forms.Label lblHelptxt2;
    }
}