namespace Client
{
    partial class SupporterCalendar
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
            this.lblUserLoggedIn = new System.Windows.Forms.Label();
            this.btnOpretTask = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.ListViewSupport = new System.Windows.Forms.ListView();
            this.time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.monday = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tuesday = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.wednesday = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.thursday = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.friday = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.saturday = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sundag = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bruger:";
            // 
            // lblUserLoggedIn
            // 
            this.lblUserLoggedIn.AutoSize = true;
            this.lblUserLoggedIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserLoggedIn.Location = new System.Drawing.Point(99, 14);
            this.lblUserLoggedIn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUserLoggedIn.Name = "lblUserLoggedIn";
            this.lblUserLoggedIn.Size = new System.Drawing.Size(206, 22);
            this.lblUserLoggedIn.TabIndex = 2;
            this.lblUserLoggedIn.Text = "Id og navn på bruger her";
            // 
            // btnOpretTask
            // 
            this.btnOpretTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpretTask.Location = new System.Drawing.Point(547, 14);
            this.btnOpretTask.Name = "btnOpretTask";
            this.btnOpretTask.Size = new System.Drawing.Size(117, 33);
            this.btnOpretTask.TabIndex = 3;
            this.btnOpretTask.Text = "Opret Task";
            this.btnOpretTask.UseVisualStyleBackColor = true;
            this.btnOpretTask.Click += new System.EventHandler(this.btnOpretTask_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(670, 14);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(117, 33);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Log ud";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // ListViewSupport
            // 
            this.ListViewSupport.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.time,
            this.monday,
            this.tuesday,
            this.wednesday,
            this.thursday,
            this.friday,
            this.saturday,
            this.sundag});
            this.ListViewSupport.Location = new System.Drawing.Point(12, 53);
            this.ListViewSupport.Name = "ListViewSupport";
            this.ListViewSupport.Size = new System.Drawing.Size(775, 344);
            this.ListViewSupport.TabIndex = 5;
            this.ListViewSupport.UseCompatibleStateImageBehavior = false;
            this.ListViewSupport.View = System.Windows.Forms.View.Details;
            // 
            // time
            // 
            this.time.Text = "Tid";
            // 
            // monday
            // 
            this.monday.Text = "Mandag";
            // 
            // tuesday
            // 
            this.tuesday.Text = "Tirsdag";
            // 
            // wednesday
            // 
            this.wednesday.Text = "Onsdag";
            // 
            // thursday
            // 
            this.thursday.Text = "Torsdag";
            // 
            // friday
            // 
            this.friday.Text = "Fridag";
            // 
            // saturday
            // 
            this.saturday.Text = "Lørdag";
            // 
            // sundag
            // 
            this.sundag.Text = "Søndag";
            // 
            // SupporterCalendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 409);
            this.Controls.Add(this.ListViewSupport);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnOpretTask);
            this.Controls.Add(this.lblUserLoggedIn);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SupporterCalendar";
            this.Text = "SupporterCalendar";
            this.Load += new System.EventHandler(this.SupporterCalendar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUserLoggedIn;
        private System.Windows.Forms.Button btnOpretTask;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.ListView ListViewSupport;
        private System.Windows.Forms.ColumnHeader time;
        private System.Windows.Forms.ColumnHeader monday;
        private System.Windows.Forms.ColumnHeader tuesday;
        private System.Windows.Forms.ColumnHeader wednesday;
        private System.Windows.Forms.ColumnHeader thursday;
        private System.Windows.Forms.ColumnHeader friday;
        private System.Windows.Forms.ColumnHeader saturday;
        private System.Windows.Forms.ColumnHeader sundag;
    }
}