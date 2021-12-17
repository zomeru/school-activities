using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using CalculatorPrivateAssembly;

namespace BasicCalculator
{
    public partial class FrmBasicCalculator : Form
    {
        public FrmBasicCalculator()
        {
            InitializeComponent();
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            string Operator = cb_Operator.Text;
            string input1 = txt_Num1.Text;
            string input2 = txt_Num2.Text;

            if (input1 == "")
            {
                errorProvider_txtNum2.Dispose();
                errorProvider_txtNum1.SetError(txt_Num1, "Don't leave this empty!");
                MessageBox.Show("Textbox1 is empty.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
            }
            else if (input2 == "")
            {
                errorProvider_txtNum1.Dispose();
                errorProvider_txtNum2.SetError(txt_Num2, "Don't leave this empty!");
                MessageBox.Show("Textbox2 is empty.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (Operator == "+")
            {
                errorProvider_txtNum1.Dispose();
                errorProvider_txtNum2.Dispose();
                getTotal delegateAnswer = new getTotal(BasicComputation.Addition);

                float Num1 = float.Parse(txt_Num1.Text);
                float Num2 = float.Parse(txt_Num2.Text);
                rtxt_Total.Text = ("Total:\n" + delegateAnswer(Num1, Num2).ToString());
            }
            else if (Operator == "-")
            {
                errorProvider_txtNum1.Dispose();
                errorProvider_txtNum2.Dispose();
                getTotal delegateAnswer = new getTotal(BasicComputation.Substraction);

                float Num1 = float.Parse(txt_Num1.Text);
                float Num2 = float.Parse(txt_Num2.Text);
                rtxt_Total.Text = ("Total:\n" + delegateAnswer(Num1, Num2).ToString());
            }
            else if (Operator == "*")
            {
                errorProvider_txtNum1.Dispose();
                errorProvider_txtNum2.Dispose();
                getTotal delegateAnswer = new getTotal(BasicComputation.Multiplication);

                float Num1 = float.Parse(txt_Num1.Text);
                float Num2 = float.Parse(txt_Num2.Text);
                rtxt_Total.Text = ("Total:\n" + delegateAnswer(Num1, Num2).ToString());
            }
            else if (Operator == "/")
            {
                errorProvider_txtNum1.Dispose();
                errorProvider_txtNum2.Dispose();
                getTotal delegateAnswer = new getTotal(BasicComputation.Division);

                float Num1 = float.Parse(txt_Num1.Text);
                float Num2 = float.Parse(txt_Num2.Text);
                rtxt_Total.Text = ("Total:\n" + delegateAnswer(Num1, Num2).ToString());
            }
            else
            {
                float Num1 = float.Parse(txt_Num1.Text);
                float Num2 = float.Parse(txt_Num2.Text);
                MessageBox.Show("Please select an Operator on the Checkbox.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txt_Num1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txt_Num2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void FrmBasicCalculator_Load(object sender, EventArgs e)
        {
            
        }
    }
}
