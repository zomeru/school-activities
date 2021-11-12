using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace StudentRegistrationApplication
{
    public partial class frmStudentRegistration : Form
    {
        public frmStudentRegistration()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmStudentRegistration_Load(object sender, EventArgs e)
        {




                for (int i = 1; i < 32; i++)
                {
                    dayComboBox.Items.Add(i.ToString());
                }
        

            // for Months
            for (int i = 1; i < 13; i++)
            {
                string zero = i.ToString().Length == 1 ? "0" : "";
                monthComboBox.Items.Add(zero + i.ToString());
            }

            // for Years
            for (int i = 2021; i >= 1900; i--)
            {
                yearComboBox.Items.Add(i.ToString());
            }

            dayComboBox.SelectedItem = null;
            dayComboBox.SelectedText = "-Day-";

            monthComboBox.SelectedItem = null;
            monthComboBox.SelectedText = "-Month-";

            yearComboBox.SelectedItem = null;
            yearComboBox.SelectedText = "-Year-";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogBox db = new DialogBox();
            db.dateLabel.Text = $"{dayComboBox.Text}/{monthComboBox.Text}/{yearComboBox.Text}";
            db.nameLabel.Text = $"{firstNameTextbox.Text} {middleNameTextbox.Text} {lastNameTextbox.Text}";
            db.genderLabel.Text = maleRadioButton.Checked ? "Male" : "Female";
            db.Show();
        }
    }
}
