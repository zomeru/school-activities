﻿namespace _05HandsOnActivity2
{
    partial class frmRegstration
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
            this.components = new System.ComponentModel.Container();
            this.btnRegister = new System.Windows.Forms.Button();
            this.dateTimePickerBday = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.txtContactno = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMiddleinitial = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbProgram = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStudentNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRecords = new System.Windows.Forms.Button();
            this.errorProviderStudentNumber = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderLastname = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderAge = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderBday = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderFirsname = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderMiddleinitial = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderProgram = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderGender = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderContactno = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderStudentNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLastname)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderBday)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFirsname)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMiddleinitial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderProgram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderGender)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderContactno)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(403, 333);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(170, 47);
            this.btnRegister.TabIndex = 39;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // dateTimePickerBday
            // 
            this.dateTimePickerBday.CalendarFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerBday.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerBday.Location = new System.Drawing.Point(150, 264);
            this.dateTimePickerBday.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePickerBday.Name = "dateTimePickerBday";
            this.dateTimePickerBday.Size = new System.Drawing.Size(328, 27);
            this.dateTimePickerBday.TabIndex = 38;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(41, 266);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 22);
            this.label10.TabIndex = 37;
            this.label10.Text = "Birthday";
            // 
            // txtContactno
            // 
            this.txtContactno.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactno.Location = new System.Drawing.Point(682, 263);
            this.txtContactno.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtContactno.Name = "txtContactno";
            this.txtContactno.Size = new System.Drawing.Size(200, 31);
            this.txtContactno.TabIndex = 36;
            this.txtContactno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContactno_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(530, 266);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 22);
            this.label9.TabIndex = 35;
            this.label9.Text = "Contact No.";
            // 
            // cbGender
            // 
            this.cbGender.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbGender.Location = new System.Drawing.Point(523, 196);
            this.cbGender.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(172, 30);
            this.cbGender.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(420, 205);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 22);
            this.label8.TabIndex = 33;
            this.label8.Text = "Gender";
            // 
            // txtMiddleinitial
            // 
            this.txtMiddleinitial.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMiddleinitial.Location = new System.Drawing.Point(820, 138);
            this.txtMiddleinitial.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMiddleinitial.Name = "txtMiddleinitial";
            this.txtMiddleinitial.Size = new System.Drawing.Size(74, 31);
            this.txtMiddleinitial.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(767, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 22);
            this.label7.TabIndex = 31;
            this.label7.Text = "M.I.";
            // 
            // cbProgram
            // 
            this.cbProgram.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProgram.FormattingEnabled = true;
            this.cbProgram.Items.AddRange(new object[] {
            "BS in Information Technology",
            "BS in Computer Science",
            "BS in Information Systems",
            "BS in Business Administration",
            "BS in Accountancy",
            "BS in Accounting Information System",
            "BS in Retail Technology and Consumer Science",
            "BS in Management Accounting",
            "BS in Hospitality Management",
            "BS in Culinary Management",
            "BS in Tourism Management",
            "BS in Computer Engineering",
            "Bachelor of Multimedia Arts",
            "Bachelor of Arts in Communication"});
            this.cbProgram.Location = new System.Drawing.Point(523, 79);
            this.cbProgram.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbProgram.Name = "cbProgram";
            this.cbProgram.Size = new System.Drawing.Size(371, 30);
            this.cbProgram.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(420, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 22);
            this.label6.TabIndex = 29;
            this.label6.Text = "Program";
            // 
            // txtFirstname
            // 
            this.txtFirstname.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstname.Location = new System.Drawing.Point(523, 138);
            this.txtFirstname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(219, 31);
            this.txtFirstname.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(403, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 22);
            this.label5.TabIndex = 27;
            this.label5.Text = "First Name";
            // 
            // txtAge
            // 
            this.txtAge.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAge.Location = new System.Drawing.Point(150, 200);
            this.txtAge.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(160, 31);
            this.txtAge.TabIndex = 26;
            this.txtAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAge_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(82, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 22);
            this.label4.TabIndex = 25;
            this.label4.Text = "Age";
            // 
            // txtLastname
            // 
            this.txtLastname.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastname.Location = new System.Drawing.Point(150, 138);
            this.txtLastname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(229, 31);
            this.txtLastname.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 22);
            this.label3.TabIndex = 23;
            this.label3.Text = "Last Name";
            // 
            // txtStudentNumber
            // 
            this.txtStudentNumber.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentNumber.Location = new System.Drawing.Point(150, 79);
            this.txtStudentNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtStudentNumber.Name = "txtStudentNumber";
            this.txtStudentNumber.Size = new System.Drawing.Size(229, 31);
            this.txtStudentNumber.TabIndex = 22;
            this.txtStudentNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStudentNumber_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 22);
            this.label2.TabIndex = 21;
            this.label2.Text = "Student No.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 36);
            this.label1.TabIndex = 20;
            this.label1.Text = "Registration";
            // 
            // btnRecords
            // 
            this.btnRecords.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecords.Location = new System.Drawing.Point(754, 333);
            this.btnRecords.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRecords.Name = "btnRecords";
            this.btnRecords.Size = new System.Drawing.Size(170, 47);
            this.btnRecords.TabIndex = 40;
            this.btnRecords.Text = "Records";
            this.btnRecords.UseVisualStyleBackColor = true;
            this.btnRecords.Click += new System.EventHandler(this.btnRecords_Click);
            // 
            // errorProviderStudentNumber
            // 
            this.errorProviderStudentNumber.ContainerControl = this;
            // 
            // errorProviderLastname
            // 
            this.errorProviderLastname.ContainerControl = this;
            // 
            // errorProviderAge
            // 
            this.errorProviderAge.ContainerControl = this;
            // 
            // errorProviderBday
            // 
            this.errorProviderBday.ContainerControl = this;
            // 
            // errorProviderFirsname
            // 
            this.errorProviderFirsname.ContainerControl = this;
            // 
            // errorProviderMiddleinitial
            // 
            this.errorProviderMiddleinitial.ContainerControl = this;
            // 
            // errorProviderProgram
            // 
            this.errorProviderProgram.ContainerControl = this;
            // 
            // errorProviderGender
            // 
            this.errorProviderGender.ContainerControl = this;
            // 
            // errorProviderContactno
            // 
            this.errorProviderContactno.ContainerControl = this;
            // 
            // frmRegstration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 412);
            this.Controls.Add(this.btnRecords);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.dateTimePickerBday);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtContactno);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbGender);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtMiddleinitial);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbProgram);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtFirstname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLastname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtStudentNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmRegstration";
            this.Text = "FrmRegistration";
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderStudentNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLastname)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderBday)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFirsname)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMiddleinitial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderProgram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderGender)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderContactno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.DateTimePicker dateTimePickerBday;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtContactno;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMiddleinitial;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbProgram;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStudentNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRecords;
        private System.Windows.Forms.ErrorProvider errorProviderStudentNumber;
        private System.Windows.Forms.ErrorProvider errorProviderLastname;
        private System.Windows.Forms.ErrorProvider errorProviderAge;
        private System.Windows.Forms.ErrorProvider errorProviderBday;
        private System.Windows.Forms.ErrorProvider errorProviderFirsname;
        private System.Windows.Forms.ErrorProvider errorProviderMiddleinitial;
        private System.Windows.Forms.ErrorProvider errorProviderProgram;
        private System.Windows.Forms.ErrorProvider errorProviderGender;
        private System.Windows.Forms.ErrorProvider errorProviderContactno;
    }
}