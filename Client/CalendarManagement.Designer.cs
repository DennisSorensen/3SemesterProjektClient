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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
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
            this.tabCreateCal.Controls.Add(this.textBox2);
            this.tabCreateCal.Controls.Add(this.label3);
            this.tabCreateCal.Controls.Add(this.label2);
            this.tabCreateCal.Controls.Add(this.label1);
            this.tabCreateCal.Controls.Add(this.textBox1);
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(151, 62);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(187, 34);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Find bruger:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fornavn:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Efternavn:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(151, 110);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(187, 34);
            this.textBox2.TabIndex = 4;
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
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabPage tabDeleteCal;
    }
}