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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            Cmbox1.Items.Add("+");
            Cmbox1.Items.Add("-");
            Cmbox1.Items.Add("*");
            Cmbox1.Items.Add("/");



        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double firstNum = Convert.ToDouble(txtBox1.Text);
            double SecondNum = Convert.ToDouble(txtBox2.Text);
            

            

            if (this.Cmbox1.SelectedItem.ToString() == "+")
           {
                LblAns.Text = Convert.ToString(firstNum + SecondNum);
                
           }
            if (this.Cmbox1.SelectedItem.ToString() == "-")
            {
                LblAns.Text = Convert.ToString(firstNum - SecondNum);

            }
            if (this.Cmbox1.SelectedItem.ToString() == "*")
            {
                LblAns.Text = Convert.ToString(firstNum * SecondNum);

            }
            if (this.Cmbox1.SelectedItem.ToString() == "/")
            {
                LblAns.Text = Convert.ToString(firstNum / SecondNum);

            }





        }

        private void txtBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
//Team Members
//Leader: Zomer Gregorio
//Members:Mark Yoldi, Lourence Jacaba, Maureen Despabiladeras, Vince Hector Castillo