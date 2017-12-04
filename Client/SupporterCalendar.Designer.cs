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
            this.lvViewCalendar = new System.Windows.Forms.ListView();
            this.timeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bookingTypeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mclDaySelect = new System.Windows.Forms.MonthCalendar();
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
            this.btnOpretTask.Location = new System.Drawing.Point(43, 225);
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
            this.btnLogout.Location = new System.Drawing.Point(43, 264);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(117, 33);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Log ud";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lvViewCalendar
            // 
            this.lvViewCalendar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.timeHeader,
            this.bookingTypeHeader});
            this.lvViewCalendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvViewCalendar.FullRowSelect = true;
            this.lvViewCalendar.Location = new System.Drawing.Point(196, 53);
            this.lvViewCalendar.Margin = new System.Windows.Forms.Padding(2);
            this.lvViewCalendar.Name = "lvViewCalendar";
            this.lvViewCalendar.Size = new System.Drawing.Size(206, 294);
            this.lvViewCalendar.TabIndex = 7;
            this.lvViewCalendar.UseCompatibleStateImageBehavior = false;
            this.lvViewCalendar.View = System.Windows.Forms.View.Details;
            this.lvViewCalendar.ItemActivate += new System.EventHandler(this.lvViewCalendar_ItemActivate);
            // 
            // timeHeader
            // 
            this.timeHeader.Text = "Tid";
            this.timeHeader.Width = 100;
            // 
            // bookingTypeHeader
            // 
            this.bookingTypeHeader.Text = "Booking Type";
            this.bookingTypeHeader.Width = 100;
            // 
            // mclDaySelect
            // 
            this.mclDaySelect.Location = new System.Drawing.Point(16, 53);
            this.mclDaySelect.Margin = new System.Windows.Forms.Padding(7);
            this.mclDaySelect.Name = "mclDaySelect";
            this.mclDaySelect.TabIndex = 8;
            this.mclDaySelect.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.mclDaySelect_DateSelected);
            // 
            // SupporterCalendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 361);
            this.Controls.Add(this.mclDaySelect);
            this.Controls.Add(this.lvViewCalendar);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnOpretTask);
            this.Controls.Add(this.lblUserLoggedIn);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "SupporterCalendar";
            this.Text = "Supporter Kalender";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SupporterCalendar_FormClosing);
            this.Load += new System.EventHandler(this.SupporterCalendar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUserLoggedIn;
        private System.Windows.Forms.Button btnOpretTask;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.ListView lvViewCalendar;
        private System.Windows.Forms.ColumnHeader timeHeader;
        private System.Windows.Forms.ColumnHeader bookingTypeHeader;
        private System.Windows.Forms.MonthCalendar mclDaySelect;
    }
}