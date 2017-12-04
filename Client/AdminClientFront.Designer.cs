namespace Client
{
    partial class AdminClientFront
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
            this.btnUserManagement = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCalManagement = new System.Windows.Forms.Button();
            this.btnLogUd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUserManagement
            // 
            this.btnUserManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserManagement.Location = new System.Drawing.Point(71, 108);
            this.btnUserManagement.Margin = new System.Windows.Forms.Padding(2);
            this.btnUserManagement.Name = "btnUserManagement";
            this.btnUserManagement.Size = new System.Drawing.Size(184, 71);
            this.btnUserManagement.TabIndex = 0;
            this.btnUserManagement.Text = "Brugerhåndtering";
            this.btnUserManagement.UseVisualStyleBackColor = true;
            this.btnUserManagement.Click += new System.EventHandler(this.btnUserManagement_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Administration";
            // 
            // btnCalManagement
            // 
            this.btnCalManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalManagement.Location = new System.Drawing.Point(71, 197);
            this.btnCalManagement.Margin = new System.Windows.Forms.Padding(2);
            this.btnCalManagement.Name = "btnCalManagement";
            this.btnCalManagement.Size = new System.Drawing.Size(184, 71);
            this.btnCalManagement.TabIndex = 2;
            this.btnCalManagement.Text = "Kalenderhåndtering";
            this.btnCalManagement.UseVisualStyleBackColor = true;
            this.btnCalManagement.Click += new System.EventHandler(this.btnCalManagement_Click);
            // 
            // btnLogUd
            // 
            this.btnLogUd.Location = new System.Drawing.Point(247, 289);
            this.btnLogUd.Name = "btnLogUd";
            this.btnLogUd.Size = new System.Drawing.Size(75, 23);
            this.btnLogUd.TabIndex = 3;
            this.btnLogUd.Text = "Log ud";
            this.btnLogUd.UseVisualStyleBackColor = true;
            this.btnLogUd.Click += new System.EventHandler(this.btnLogUd_Click);
            // 
            // AdminClientFront
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 324);
            this.Controls.Add(this.btnLogUd);
            this.Controls.Add(this.btnCalManagement);
            this.Controls.Add(this.btnUserManagement);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AdminClientFront";
            this.Text = "Elgiganten Administration";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminClientFront_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnUserManagement;
        private System.Windows.Forms.Button btnCalManagement;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogUd;
    }
}