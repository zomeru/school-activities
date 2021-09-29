using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApplication
{
    public partial class FrmCalculator : Form
    {
        public FrmCalculator()
        {
            InitializeComponent();
        }
        
        private void calculateButton_Click(object sender, EventArgs e)
        {
            double firstNum = Convert.ToDouble(firstNumTextbox.Text);
            double secondNum = Convert.ToDouble(secondNumTextbox.Text);

            if (radioButton1.Checked)
            {
                answerLabel.Text = Convert.ToString(firstNum + secondNum);
            }
            if (radioButton2.Checked)
            {
                answerLabel.Text = Convert.ToString(firstNum - secondNum);
            }
            if (radioButton3.Checked)
            {
                answerLabel.Text = Convert.ToString(firstNum * secondNum);
            }
            if (radioButton4.Checked)
            {
                answerLabel.Text = Convert.ToString(firstNum / secondNum);
            }
        }
    }
    


    public class CalculatorClass
    {
        
    }
}