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
            this.dgvSupporterCalendar = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUserLoggedIn = new System.Windows.Forms.Label();
            this.btnOpretTask = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.tid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupporterCalendar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSupporterCalendar
            // 
            this.dgvSupporterCalendar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSupporterCalendar.Location = new System.Drawing.Point(9, 61);
            this.dgvSupporterCalendar.Margin = new System.Windows.Forms.Padding(2);
            this.dgvSupporterCalendar.Name = "dgvSupporterCalendar";
            this.dgvSupporterCalendar.RowHeadersVisible = false;
            this.dgvSupporterCalendar.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvSupporterCalendar.RowTemplate.Height = 24;
            this.dgvSupporterCalendar.Size = new System.Drawing.Size(781, 353);
            this.dgvSupporterCalendar.TabIndex = 0;
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
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.tid,
            this.columnHeader2});
            this.listView1.Location = new System.Drawing.Point(17, 69);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(758, 324);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // tid
            // 
            this.tid.Text = "Tid";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Mandag";
            // 
            // SupporterCalendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 424);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnOpretTask);
            this.Controls.Add(this.lblUserLoggedIn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvSupporterCalendar);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SupporterCalendar";
            this.Text = "SupporterCalendar";
            this.Load += new System.EventHandler(this.SupporterCalendar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupporterCalendar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSupporterCalendar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUserLoggedIn;
        private System.Windows.Forms.Button btnOpretTask;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader tid;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}