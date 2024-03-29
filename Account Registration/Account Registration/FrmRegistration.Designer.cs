﻿namespace Account_Registration
{
    partial class FrmRegistration
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
             this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Account Registration";
            
            this.studentNumberLabel = new System.Windows.Forms.Label();
            this.studentNumberTextbox = new System.Windows.Forms.TextBox();
            
            this.programTextbox = new System.Windows.Forms.TextBox();
            this.programLabel = new System.Windows.Forms.Label();
            
            this.lastNameTextbox = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            
            this.firstNameTextbox = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            
            this.middleNameTextbox = new System.Windows.Forms.TextBox();
            this.middleNameLabel = new System.Windows.Forms.Label();
            
            this.contactNumberTextbox = new System.Windows.Forms.TextBox();
            this.contactNumberLabel = new System.Windows.Forms.Label();
            
            this.ageTextbox = new System.Windows.Forms.TextBox();
            this.ageLabel = new System.Windows.Forms.Label();
            
            this.addressLabel = new System.Windows.Forms.Label();
            this.addressRichTextbox = new System.Windows.Forms.RichTextBox();
            
            this.nextButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            
            this.errorMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // studentNumberLabel
            // 
            this.studentNumberLabel.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.studentNumberLabel.Location = new System.Drawing.Point(17, 25);
            this.studentNumberLabel.Name = "studentNumberLabel";
            this.studentNumberLabel.Size = new System.Drawing.Size(156, 22);
            this.studentNumberLabel.TabIndex = 0;
            this.studentNumberLabel.Text = "Student No.:\r\n";
            // 
            // studentNumberTextbox
            // 
            this.studentNumberTextbox.Font = new System.Drawing.Font("Open Sans SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.studentNumberTextbox.Location = new System.Drawing.Point(17, 51);
            this.studentNumberTextbox.Name = "studentNumberTextbox";
            this.studentNumberTextbox.Size = new System.Drawing.Size(163, 20);
            this.studentNumberTextbox.TabIndex = 1;
            this.studentNumberTextbox.Text = "";
            // 
            // programTextbox
            // 
            this.programTextbox.Font = new System.Drawing.Font("Open Sans SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.programTextbox.Location = new System.Drawing.Point(184, 51);
            this.programTextbox.Name = "programTextbox";
            this.programTextbox.Size = new System.Drawing.Size(210, 20);
            this.programTextbox.TabIndex = 3;
            this.programTextbox.Text = "";
            // 
            // programLabel
            // 
            this.programLabel.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.programLabel.Location = new System.Drawing.Point(179, 25);
            this.programLabel.Name = "programLabel";
            this.programLabel.Size = new System.Drawing.Size(161, 22);
            this.programLabel.TabIndex = 2;
            this.programLabel.Text = "Program:";
            // 
            // lastNameTextbox
            // 
            this.lastNameTextbox.Font = new System.Drawing.Font("Open Sans SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lastNameTextbox.Location = new System.Drawing.Point(17, 111);
            this.lastNameTextbox.Name = "lastNameTextbox";
            this.lastNameTextbox.Size = new System.Drawing.Size(163, 20);
            this.lastNameTextbox.TabIndex = 5;
            this.lastNameTextbox.Text = "";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lastNameLabel.Location = new System.Drawing.Point(17, 85);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(156, 22);
            this.lastNameLabel.TabIndex = 4;
            this.lastNameLabel.Text = "Last Name:";
            // 
            // firstNameTextbox
            // 
            this.firstNameTextbox.Font = new System.Drawing.Font("Open Sans SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.firstNameTextbox.Location = new System.Drawing.Point(186, 111);
            this.firstNameTextbox.Name = "firstNameTextbox";
            this.firstNameTextbox.Size = new System.Drawing.Size(163, 20);
            this.firstNameTextbox.TabIndex = 7;
            this.firstNameTextbox.Text = "";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.firstNameLabel.Location = new System.Drawing.Point(186, 85);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(156, 22);
            this.firstNameLabel.TabIndex = 6;
            this.firstNameLabel.Text = "First Name:";
            // 
            // middleNameTextbox
            // 
            this.middleNameTextbox.Font = new System.Drawing.Font("Open Sans SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.middleNameTextbox.Location = new System.Drawing.Point(355, 111);
            this.middleNameTextbox.Name = "middleNameTextbox";
            this.middleNameTextbox.Size = new System.Drawing.Size(163, 20);
            this.middleNameTextbox.TabIndex = 9;
            this.middleNameTextbox.Text = "";
            // 
            // middleNameLabel
            // 
            this.middleNameLabel.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.middleNameLabel.Location = new System.Drawing.Point(355, 85);
            this.middleNameLabel.Name = "middleNameLabel";
            this.middleNameLabel.Size = new System.Drawing.Size(156, 22);
            this.middleNameLabel.TabIndex = 8;
            this.middleNameLabel.Text = "Middle Name:";
            // 
            // contactNumberTextbox
            // 
            this.contactNumberTextbox.Font = new System.Drawing.Font("Open Sans SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.contactNumberTextbox.Location = new System.Drawing.Point(186, 174);
            this.contactNumberTextbox.Name = "contactNumberTextbox";
            this.contactNumberTextbox.Size = new System.Drawing.Size(163, 20);
            this.contactNumberTextbox.TabIndex = 13;
            this.contactNumberTextbox.Text = "";
            // 
            // contactNumberLabel
            // 
            this.contactNumberLabel.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.contactNumberLabel.Location = new System.Drawing.Point(186, 148);
            this.contactNumberLabel.Name = "contactNumberLabel";
            this.contactNumberLabel.Size = new System.Drawing.Size(156, 22);
            this.contactNumberLabel.TabIndex = 12;
            this.contactNumberLabel.Text = "Contact No.:";
            // 
            // ageTextbox
            // 
            this.ageTextbox.Font = new System.Drawing.Font("Open Sans SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.ageTextbox.Location = new System.Drawing.Point(17, 174);
            this.ageTextbox.Name = "ageTextbox";
            this.ageTextbox.Size = new System.Drawing.Size(163, 20);
            this.ageTextbox.TabIndex = 11;
            this.ageTextbox.Text = "";
            // 
            // ageLabel
            // 
            this.ageLabel.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.ageLabel.Location = new System.Drawing.Point(17, 148);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(156, 22);
            this.ageLabel.TabIndex = 10;
            this.ageLabel.Text = "Age:";
            // 
            // addressLabel
            // 
            this.addressLabel.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.addressLabel.Location = new System.Drawing.Point(17, 217);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(156, 22);
            this.addressLabel.TabIndex = 14;
            this.addressLabel.Text = "Address:";
            // 
            // addressRichTextbox
            // 
            this.addressRichTextbox.Font = new System.Drawing.Font("Open Sans SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.addressRichTextbox.Location = new System.Drawing.Point(21, 247);
            this.addressRichTextbox.Name = "addressRichTextbox";
            this.addressRichTextbox.Size = new System.Drawing.Size(496, 132);
            this.addressRichTextbox.TabIndex = 15;
            this.addressRichTextbox.Text = "";
            // 
            // nextButton
            // 
            this.nextButton.Font = new System.Drawing.Font("Open Sans SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.nextButton.Location = new System.Drawing.Point(398, 399);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(119, 33);
            this.nextButton.TabIndex = 16;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Open Sans SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.clearButton.Location = new System.Drawing.Point(273, 399);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(119, 33);
            this.clearButton.TabIndex = 17;
            this.clearButton.Text = "Clear All";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // errorMessage
            // 
            this.errorMessage.ForeColor = System.Drawing.Color.Red;
            this.errorMessage.Location = new System.Drawing.Point(21, 392);
            this.errorMessage.Name = "errorMessage";
            this.errorMessage.Size = new System.Drawing.Size(234, 39);
            this.errorMessage.TabIndex = 18;
            this.errorMessage.Text = "";
            // 
            // FrmRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(556, 444);
            this.Controls.Add(this.errorMessage);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.addressRichTextbox);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.contactNumberTextbox);
            this.Controls.Add(this.contactNumberLabel);
            this.Controls.Add(this.ageTextbox);
            this.Controls.Add(this.ageLabel);
            this.Controls.Add(this.middleNameTextbox);
            this.Controls.Add(this.middleNameLabel);
            this.Controls.Add(this.firstNameTextbox);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.lastNameTextbox);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.programTextbox);
            this.Controls.Add(this.programLabel);
            this.Controls.Add(this.studentNumberTextbox);
            this.Controls.Add(this.studentNumberLabel);
            this.Location = new System.Drawing.Point(15, 15);
            this.MaximumSize = new System.Drawing.Size(572, 483);
            this.MinimumSize = new System.Drawing.Size(572, 483);
            this.Name = "FrmRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmRegistration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        private System.Windows.Forms.Label errorMessage;
        
        private System.Windows.Forms.Button clearButton;
        
        private System.Windows.Forms.Button nextButton;
        
        private System.Windows.Forms.Label addressLabel;
        public System.Windows.Forms.RichTextBox addressRichTextbox;

        public System.Windows.Forms.TextBox ageTextbox;
        private System.Windows.Forms.Label ageLabel;
        
        public System.Windows.Forms.TextBox contactNumberTextbox;
        private System.Windows.Forms.Label contactNumberLabel;

        private System.Windows.Forms.Label studentNumberLabel;
        public System.Windows.Forms.TextBox studentNumberTextbox;
        
        public System.Windows.Forms.TextBox programTextbox;
        private System.Windows.Forms.Label programLabel;
        
        public System.Windows.Forms.TextBox firstNameTextbox;
        private System.Windows.Forms.Label firstNameLabel;
        
        public System.Windows.Forms.TextBox lastNameTextbox;
        private System.Windows.Forms.Label lastNameLabel;

        public System.Windows.Forms.TextBox middleNameTextbox;
        private System.Windows.Forms.Label middleNameLabel;

        #endregion
    }
}