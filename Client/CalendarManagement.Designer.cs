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
            this.tabViewCal = new System.Windows.Forms.TabPage();
            this.tabEditCal = new System.Windows.Forms.TabPage();
            this.tabDeleteCal = new System.Windows.Forms.TabPage();
            this.btnCreateCal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
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
            this.tabCreateCal.Controls.Add(this.label2);
            this.tabCreateCal.Controls.Add(this.listBox1);
            this.tabCreateCal.Controls.Add(this.label1);
            this.tabCreateCal.Controls.Add(this.btnCreateCal);
            this.tabCreateCal.Location = new System.Drawing.Point(4, 38);
            this.tabCreateCal.Name = "tabCreateCal";
            this.tabCreateCal.Padding = new System.Windows.Forms.Padding(3);
            this.tabCreateCal.Size = new System.Drawing.Size(1040, 433);
            this.tabCreateCal.TabIndex = 0;
            this.tabCreateCal.Text = "Opret Kalender";
            this.tabCreateCal.UseVisualStyleBackColor = true;
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
            // btnCreateCal
            // 
            this.btnCreateCal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateCal.Location = new System.Drawing.Point(70, 349);
            this.btnCreateCal.Name = "btnCreateCal";
            this.btnCreateCal.Size = new System.Drawing.Size(154, 42);
            this.btnCreateCal.TabIndex = 5;
            this.btnCreateCal.Text = "Opret Kalender";
            this.btnCreateCal.UseVisualStyleBackColor = true;
            this.btnCreateCal.Click += new System.EventHandler(this.btnCreateCal_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Supporter - oversigt";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 29;
            this.listBox1.Location = new System.Drawing.Point(34, 120);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(220, 178);
            this.listBox1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Markér den ønskede supporter";
            // 
            // CalendarManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 479);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
    }
}