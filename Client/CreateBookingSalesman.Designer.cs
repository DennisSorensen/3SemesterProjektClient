﻿namespace Client
{
    partial class CreateBookingSalesman
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
            this.cbService = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbEndDate = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.rbYesContract = new System.Windows.Forms.RadioButton();
            this.rbNoContract = new System.Windows.Forms.RadioButton();
            this.txtProductNr = new System.Windows.Forms.TextBox();
            this.txtAppendixNr = new System.Windows.Forms.TextBox();
            this.chbInstallPrinter = new System.Windows.Forms.CheckBox();
            this.chbOffice = new System.Windows.Forms.CheckBox();
            this.btnCreateRTG = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Solgt service";
            // 
            // cbService
            // 
            this.cbService.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbService.FormattingEnabled = true;
            this.cbService.Items.AddRange(new object[] {
            "Pc",
            "Tv",
            "Mobil",
            "Tablet",
            "Gps",
            "Ur",
            "Spillekonsol"});
            this.cbService.Location = new System.Drawing.Point(27, 135);
            this.cbService.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbService.Name = "cbService";
            this.cbService.Size = new System.Drawing.Size(193, 24);
            this.cbService.TabIndex = 1;
            this.cbService.TextChanged += new System.EventHandler(this.cbService_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tillægsydelser";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Vælg slut tid";
            // 
            // cbEndDate
            // 
            this.cbEndDate.FormattingEnabled = true;
            this.cbEndDate.Location = new System.Drawing.Point(111, 357);
            this.cbEndDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbEndDate.Name = "cbEndDate";
            this.cbEndDate.Size = new System.Drawing.Size(112, 24);
            this.cbEndDate.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 401);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Udfyld felter";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 437);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Produkt nr:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 474);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Bilags nr:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 511);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Kontrakt:";
            // 
            // rbYesContract
            // 
            this.rbYesContract.AutoSize = true;
            this.rbYesContract.Location = new System.Drawing.Point(111, 510);
            this.rbYesContract.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbYesContract.Name = "rbYesContract";
            this.rbYesContract.Size = new System.Drawing.Size(44, 21);
            this.rbYesContract.TabIndex = 13;
            this.rbYesContract.TabStop = true;
            this.rbYesContract.Text = "Ja";
            this.rbYesContract.UseVisualStyleBackColor = true;
            // 
            // rbNoContract
            // 
            this.rbNoContract.AutoSize = true;
            this.rbNoContract.Location = new System.Drawing.Point(173, 510);
            this.rbNoContract.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbNoContract.Name = "rbNoContract";
            this.rbNoContract.Size = new System.Drawing.Size(50, 21);
            this.rbNoContract.TabIndex = 14;
            this.rbNoContract.TabStop = true;
            this.rbNoContract.Text = "Nej";
            this.rbNoContract.UseVisualStyleBackColor = true;
            // 
            // txtProductNr
            // 
            this.txtProductNr.Location = new System.Drawing.Point(111, 434);
            this.txtProductNr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProductNr.Name = "txtProductNr";
            this.txtProductNr.Size = new System.Drawing.Size(112, 22);
            this.txtProductNr.TabIndex = 15;
            // 
            // txtAppendixNr
            // 
            this.txtAppendixNr.Location = new System.Drawing.Point(111, 471);
            this.txtAppendixNr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAppendixNr.Name = "txtAppendixNr";
            this.txtAppendixNr.Size = new System.Drawing.Size(112, 22);
            this.txtAppendixNr.TabIndex = 16;
            // 
            // chbInstallPrinter
            // 
            this.chbInstallPrinter.AutoSize = true;
            this.chbInstallPrinter.Location = new System.Drawing.Point(29, 246);
            this.chbInstallPrinter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbInstallPrinter.Name = "chbInstallPrinter";
            this.chbInstallPrinter.Size = new System.Drawing.Size(158, 21);
            this.chbInstallPrinter.TabIndex = 18;
            this.chbInstallPrinter.Text = "Installation af printer";
            this.chbInstallPrinter.UseVisualStyleBackColor = true;
            // 
            // chbOffice
            // 
            this.chbOffice.AutoSize = true;
            this.chbOffice.Location = new System.Drawing.Point(29, 219);
            this.chbOffice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbOffice.Name = "chbOffice";
            this.chbOffice.Size = new System.Drawing.Size(67, 21);
            this.chbOffice.TabIndex = 19;
            this.chbOffice.Text = "Office";
            this.chbOffice.UseVisualStyleBackColor = true;
            // 
            // btnCreateRTG
            // 
            this.btnCreateRTG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateRTG.Location = new System.Drawing.Point(29, 566);
            this.btnCreateRTG.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreateRTG.Name = "btnCreateRTG";
            this.btnCreateRTG.Size = new System.Drawing.Size(193, 49);
            this.btnCreateRTG.TabIndex = 20;
            this.btnCreateRTG.Text = "Opret RTG";
            this.btnCreateRTG.UseVisualStyleBackColor = true;
            this.btnCreateRTG.Click += new System.EventHandler(this.btnCreateRTG_Click);
            this.btnCreateRTG.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnCreateRTG_MouseClick);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(21, 46);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(193, 28);
            this.btnLogout.TabIndex = 21;
            this.btnLogout.Text = "Log ud";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1, 11);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 17);
            this.label8.TabIndex = 22;
            this.label8.Text = "Bruger:";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(53, 12);
            this.lblUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(20, 17);
            this.lblUser.TabIndex = 23;
            this.lblUser.Text = "...";
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(29, 320);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(193, 22);
            this.dtpDate.TabIndex = 24;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 361);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 17);
            this.label9.TabIndex = 25;
            this.label9.Text = "Tidspunkt:";
            // 
            // CreateBookingSalesman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 634);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnCreateRTG);
            this.Controls.Add(this.chbOffice);
            this.Controls.Add(this.chbInstallPrinter);
            this.Controls.Add(this.txtAppendixNr);
            this.Controls.Add(this.txtProductNr);
            this.Controls.Add(this.rbNoContract);
            this.Controls.Add(this.rbYesContract);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbEndDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbService);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CreateBookingSalesman";
            this.Text = "Lav Booking Sælger";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CreateBookingSalesman_FormClosing);
            this.Load += new System.EventHandler(this.CreateBookingSalesman_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbService;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbEndDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rbYesContract;
        private System.Windows.Forms.RadioButton rbNoContract;
        private System.Windows.Forms.TextBox txtProductNr;
        private System.Windows.Forms.TextBox txtAppendixNr;
        private System.Windows.Forms.CheckBox chbInstallPrinter;
        private System.Windows.Forms.CheckBox chbOffice;
        private System.Windows.Forms.Button btnCreateRTG;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label9;
    }
}