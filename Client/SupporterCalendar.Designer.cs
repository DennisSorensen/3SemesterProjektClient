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
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupporterCalendar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSupporterCalendar
            // 
            this.dgvSupporterCalendar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSupporterCalendar.Location = new System.Drawing.Point(12, 75);
            this.dgvSupporterCalendar.Name = "dgvSupporterCalendar";
            this.dgvSupporterCalendar.RowHeadersVisible = false;
            this.dgvSupporterCalendar.RowTemplate.Height = 24;
            this.dgvSupporterCalendar.Size = new System.Drawing.Size(1041, 435);
            this.dgvSupporterCalendar.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bruger:";
            // 
            // lblUserLoggedIn
            // 
            this.lblUserLoggedIn.AutoSize = true;
            this.lblUserLoggedIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserLoggedIn.Location = new System.Drawing.Point(132, 28);
            this.lblUserLoggedIn.Name = "lblUserLoggedIn";
            this.lblUserLoggedIn.Size = new System.Drawing.Size(274, 29);
            this.lblUserLoggedIn.TabIndex = 2;
            this.lblUserLoggedIn.Text = "Id og navn på bruger her";
            // 
            // SupporterCalendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 522);
            this.Controls.Add(this.lblUserLoggedIn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvSupporterCalendar);
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
    }
}