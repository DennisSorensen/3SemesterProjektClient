namespace Client
{
    partial class Login
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
            this.btnAdminFront = new System.Windows.Forms.Button();
            this.btnSupportFront = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdminFront
            // 
            this.btnAdminFront.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminFront.Location = new System.Drawing.Point(131, 255);
            this.btnAdminFront.Name = "btnAdminFront";
            this.btnAdminFront.Size = new System.Drawing.Size(143, 59);
            this.btnAdminFront.TabIndex = 0;
            this.btnAdminFront.Text = "Admin Front";
            this.btnAdminFront.UseVisualStyleBackColor = true;
            this.btnAdminFront.Click += new System.EventHandler(this.btnAdminFront_Click);
            // 
            // btnSupportFront
            // 
            this.btnSupportFront.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupportFront.Location = new System.Drawing.Point(131, 320);
            this.btnSupportFront.Name = "btnSupportFront";
            this.btnSupportFront.Size = new System.Drawing.Size(143, 59);
            this.btnSupportFront.TabIndex = 1;
            this.btnSupportFront.Text = "Support Front";
            this.btnSupportFront.UseVisualStyleBackColor = true;
            this.btnSupportFront.Click += new System.EventHandler(this.btnSupportFront_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 387);
            this.Controls.Add(this.btnSupportFront);
            this.Controls.Add(this.btnAdminFront);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdminFront;
        private System.Windows.Forms.Button btnSupportFront;
    }
}

