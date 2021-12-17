namespace BasicCalculator
{
    partial class FrmBasicCalculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Num1 = new System.Windows.Forms.TextBox();
            this.cb_Operator = new System.Windows.Forms.ComboBox();
            this.txt_Num2 = new System.Windows.Forms.TextBox();
            this.btn_Compute = new System.Windows.Forms.Button();
            this.rtxt_Total = new System.Windows.Forms.RichTextBox();
            this.errorProvider_txtNum1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider_txtNum2 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_txtNum1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_txtNum2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Basic Calculator";
            // 
            // txt_Num1
            // 
            this.txt_Num1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Num1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Num1.Location = new System.Drawing.Point(21, 45);
            this.txt_Num1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Num1.Name = "txt_Num1";
            this.txt_Num1.Size = new System.Drawing.Size(396, 34);
            this.txt_Num1.TabIndex = 1;
            this.txt_Num1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_Num1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Num1_KeyPress);
            // 
            // cb_Operator
            // 
            this.cb_Operator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Operator.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Operator.FormattingEnabled = true;
            this.cb_Operator.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.cb_Operator.Location = new System.Drawing.Point(128, 94);
            this.cb_Operator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cb_Operator.Name = "cb_Operator";
            this.cb_Operator.Size = new System.Drawing.Size(188, 41);
            this.cb_Operator.TabIndex = 2;
            // 
            // txt_Num2
            // 
            this.txt_Num2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Num2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Num2.Location = new System.Drawing.Point(21, 143);
            this.txt_Num2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Num2.Name = "txt_Num2";
            this.txt_Num2.Size = new System.Drawing.Size(396, 34);
            this.txt_Num2.TabIndex = 3;
            this.txt_Num2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_Num2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Num2_KeyPress);
            // 
            // btn_Compute
            // 
            this.btn_Compute.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Compute.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Compute.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Compute.Location = new System.Drawing.Point(128, 374);
            this.btn_Compute.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Compute.Name = "btn_Compute";
            this.btn_Compute.Size = new System.Drawing.Size(188, 44);
            this.btn_Compute.TabIndex = 4;
            this.btn_Compute.Text = "Compute";
            this.btn_Compute.UseVisualStyleBackColor = true;
            this.btn_Compute.Click += new System.EventHandler(this.btnCompute_Click);
            // 
            // rtxt_Total
            // 
            this.rtxt_Total.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.rtxt_Total.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxt_Total.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxt_Total.ForeColor = System.Drawing.Color.Lime;
            this.rtxt_Total.Location = new System.Drawing.Point(21, 205);
            this.rtxt_Total.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rtxt_Total.Name = "rtxt_Total";
            this.rtxt_Total.Size = new System.Drawing.Size(396, 136);
            this.rtxt_Total.TabIndex = 6;
            this.rtxt_Total.Text = "";
            // 
            // errorProvider_txtNum1
            // 
            this.errorProvider_txtNum1.ContainerControl = this;
            // 
            // errorProvider_txtNum2
            // 
            this.errorProvider_txtNum2.ContainerControl = this;
            // 
            // FrmBasicCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(443, 431);
            this.Controls.Add(this.rtxt_Total);
            this.Controls.Add(this.btn_Compute);
            this.Controls.Add(this.txt_Num2);
            this.Controls.Add(this.cb_Operator);
            this.Controls.Add(this.txt_Num1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmBasicCalculator";
            this.Text = "FrmBasicCalculator";
            this.Load += new System.EventHandler(this.FrmBasicCalculator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_txtNum1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_txtNum2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Num1;
        private System.Windows.Forms.ComboBox cb_Operator;
        private System.Windows.Forms.TextBox txt_Num2;
        private System.Windows.Forms.Button btn_Compute;
        private System.Windows.Forms.RichTextBox rtxt_Total;
        private System.Windows.Forms.ErrorProvider errorProvider_txtNum1;
        private System.Windows.Forms.ErrorProvider errorProvider_txtNum2;
    }
}

