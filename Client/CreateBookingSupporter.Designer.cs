namespace Client
{
    partial class CreateBookingSupporter
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbTaskStatDate = new System.Windows.Forms.ComboBox();
            this.cbTaskEndDate = new System.Windows.Forms.ComboBox();
            this.txtTaskName = new System.Windows.Forms.TextBox();
            this.txtTaskDescription = new System.Windows.Forms.TextBox();
            this.btnCreateTask = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(103, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Opret opgave";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Start Tid:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 109);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Slut Tid:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 144);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Opgave navn:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(86, 171);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = " Beskrivelse:";
            // 
            // cbTaskStatDate
            // 
            this.cbTaskStatDate.FormattingEnabled = true;
            this.cbTaskStatDate.Location = new System.Drawing.Point(164, 84);
            this.cbTaskStatDate.Margin = new System.Windows.Forms.Padding(2);
            this.cbTaskStatDate.Name = "cbTaskStatDate";
            this.cbTaskStatDate.Size = new System.Drawing.Size(92, 21);
            this.cbTaskStatDate.TabIndex = 5;
            // 
            // cbTaskEndDate
            // 
            this.cbTaskEndDate.FormattingEnabled = true;
            this.cbTaskEndDate.Location = new System.Drawing.Point(164, 109);
            this.cbTaskEndDate.Margin = new System.Windows.Forms.Padding(2);
            this.cbTaskEndDate.Name = "cbTaskEndDate";
            this.cbTaskEndDate.Size = new System.Drawing.Size(92, 21);
            this.cbTaskEndDate.TabIndex = 6;
            // 
            // txtTaskName
            // 
            this.txtTaskName.Location = new System.Drawing.Point(174, 144);
            this.txtTaskName.Margin = new System.Windows.Forms.Padding(2);
            this.txtTaskName.Name = "txtTaskName";
            this.txtTaskName.Size = new System.Drawing.Size(76, 20);
            this.txtTaskName.TabIndex = 7;
            // 
            // txtTaskDescription
            // 
            this.txtTaskDescription.Location = new System.Drawing.Point(174, 171);
            this.txtTaskDescription.Margin = new System.Windows.Forms.Padding(2);
            this.txtTaskDescription.Name = "txtTaskDescription";
            this.txtTaskDescription.Size = new System.Drawing.Size(76, 20);
            this.txtTaskDescription.TabIndex = 8;
            // 
            // btnCreateTask
            // 
            this.btnCreateTask.Location = new System.Drawing.Point(132, 226);
            this.btnCreateTask.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreateTask.Name = "btnCreateTask";
            this.btnCreateTask.Size = new System.Drawing.Size(85, 41);
            this.btnCreateTask.TabIndex = 9;
            this.btnCreateTask.Text = "Opret";
            this.btnCreateTask.UseVisualStyleBackColor = true;
            this.btnCreateTask.Click += new System.EventHandler(this.btnCreateTask_Click);
            // 
            // CreateBookingSupporter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 325);
            this.Controls.Add(this.btnCreateTask);
            this.Controls.Add(this.txtTaskDescription);
            this.Controls.Add(this.txtTaskName);
            this.Controls.Add(this.cbTaskEndDate);
            this.Controls.Add(this.cbTaskStatDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CreateBookingSupporter";
            this.Text = "CreateBookingSupporter";
            this.Load += new System.EventHandler(this.CreateBookingSupporter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbTaskStatDate;
        private System.Windows.Forms.ComboBox cbTaskEndDate;
        private System.Windows.Forms.TextBox txtTaskName;
        private System.Windows.Forms.TextBox txtTaskDescription;
        private System.Windows.Forms.Button btnCreateTask;
    }
}