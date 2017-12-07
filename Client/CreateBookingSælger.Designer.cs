namespace Client
{
    partial class CreateBookingSælger
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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 47);
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
            this.cbService.Location = new System.Drawing.Point(30, 87);
            this.cbService.Name = "cbService";
            this.cbService.Size = new System.Drawing.Size(121, 24);
            this.cbService.TabIndex = 1;
            this.cbService.TextChanged += new System.EventHandler(this.cbService_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tillægsydelser";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Vælg slut tid";
            // 
            // cbEndDate
            // 
            this.cbEndDate.FormattingEnabled = true;
            this.cbEndDate.Location = new System.Drawing.Point(30, 325);
            this.cbEndDate.Name = "cbEndDate";
            this.cbEndDate.Size = new System.Drawing.Size(121, 24);
            this.cbEndDate.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 401);
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
            this.label6.Size = new System.Drawing.Size(70, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Billgas nr:";
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
            this.rbYesContract.Location = new System.Drawing.Point(111, 509);
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
            this.rbNoContract.Location = new System.Drawing.Point(173, 509);
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
            this.txtProductNr.Name = "txtProductNr";
            this.txtProductNr.Size = new System.Drawing.Size(112, 22);
            this.txtProductNr.TabIndex = 15;
            // 
            // txtAppendixNr
            // 
            this.txtAppendixNr.Location = new System.Drawing.Point(111, 471);
            this.txtAppendixNr.Name = "txtAppendixNr";
            this.txtAppendixNr.Size = new System.Drawing.Size(112, 22);
            this.txtAppendixNr.TabIndex = 16;
            // 
            // chbInstallPrinter
            // 
            this.chbInstallPrinter.AutoSize = true;
            this.chbInstallPrinter.Location = new System.Drawing.Point(30, 226);
            this.chbInstallPrinter.Name = "chbInstallPrinter";
            this.chbInstallPrinter.Size = new System.Drawing.Size(158, 21);
            this.chbInstallPrinter.TabIndex = 18;
            this.chbInstallPrinter.Text = "Installation af printer";
            this.chbInstallPrinter.UseVisualStyleBackColor = true;
            // 
            // chbOffice
            // 
            this.chbOffice.AutoSize = true;
            this.chbOffice.Location = new System.Drawing.Point(30, 199);
            this.chbOffice.Name = "chbOffice";
            this.chbOffice.Size = new System.Drawing.Size(67, 21);
            this.chbOffice.TabIndex = 19;
            this.chbOffice.Text = "Office";
            this.chbOffice.UseVisualStyleBackColor = true;
            // 
            // btnCreateRTG
            // 
            this.btnCreateRTG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateRTG.Location = new System.Drawing.Point(30, 566);
            this.btnCreateRTG.Name = "btnCreateRTG";
            this.btnCreateRTG.Size = new System.Drawing.Size(193, 49);
            this.btnCreateRTG.TabIndex = 20;
            this.btnCreateRTG.Text = "Opret RTG";
            this.btnCreateRTG.UseVisualStyleBackColor = true;
            this.btnCreateRTG.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnCreateRTG_MouseClick);
            // 
            // CreateBookingSælger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 642);
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
            this.Name = "CreateBookingSælger";
            this.Text = "CreateBookingSælger";
            this.Load += new System.EventHandler(this.CreateBookingSælger_Load);
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
    }
}