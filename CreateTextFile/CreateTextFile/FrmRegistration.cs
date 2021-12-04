using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace CreateTextFile
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            string Docupath = @"C:\Users\Zomer\Desktop\";
            string StudNum = studentNumberTextbox.Text;
            string fileExe = ".txt";
            string createDocu = Docupath + StudNum + fileExe;

            if (studentNumberTextbox.Text == "")
            {
                errorProviderStudentNumber.SetError(studentNumberTextbox, "Please enter a Student Number!");
                MessageBox.Show("Don't leave anything blank.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (programCombobox.Text == "")
            {
                errorProviderStudentNumber.Dispose();
                errorProviderProgram.SetError(programCombobox, "Please select a Program!");
                MessageBox.Show("Don't leave anything blank.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (lastNameTextbox.Text == "")
            {
                errorProviderProgram.Dispose();
                errorProviderLastName.SetError(lastNameTextbox, "Please enter your Lastname!");
                MessageBox.Show("Don't leave anything blank.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (firstNameTextbox.Text == "")
            {
                errorProviderLastName.Dispose();
                errorProviderFirstName.SetError(firstNameTextbox, "Please enter your Firstname!");
                MessageBox.Show("Don't leave anything blank.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (ageTextbox.Text == "")
            {
                errorProviderFirstName.Dispose();
                errorProviderAge.SetError(ageTextbox, "Please enter your Age!");
                MessageBox.Show("Don't leave anything blank.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (genderCombobox.Text == "")
            {
                errorProviderAge.Dispose();
                errorProviderGender.SetError(genderCombobox, "Please select a Gender!");
                MessageBox.Show("Don't leave anything blank.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (contactNumberTextbox.Text == "")
            {
                errorProviderGender.Dispose();
                errorProviderContactNumber.SetError(contactNumberTextbox, "Please enter a Program!");
                MessageBox.Show("Don't leave anything blank.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    errorProviderContactNumber.Dispose();

                    FileStream fileStream = new FileStream(createDocu, FileMode.OpenOrCreate);
                    StreamWriter outputFile = new StreamWriter(fileStream);

                    outputFile.WriteLine("Student No.: " + studentNumberTextbox.Text);
                    outputFile.WriteLine("Full Name: " + lastNameTextbox.Text + ", " + firstNameTextbox.Text + " " + middleInitialTextbox.Text + ".");
                    outputFile.WriteLine("Program: " + programCombobox.Text);
                    outputFile.WriteLine("Gender: " + genderCombobox.Text);
                    outputFile.WriteLine("Age: " + ageTextbox.Text);
                    outputFile.WriteLine("Birthday: " + bdayPicker.Text);
                    outputFile.WriteLine("Contact: " + contactNumberTextbox.Text);
                    outputFile.Close();
                    fileStream.Close();
                    MessageBox.Show("Registration Complete.", "Message");
                }
                catch (Exception ed)
                {
                    MessageBox.Show(ed.Message);
                }
            }
        }

        private void studentNumberTextbox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void ageTextbox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void contactNumberTextbox_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
