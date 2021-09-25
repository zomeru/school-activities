using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Account_Registration
{
    public delegate long DelegateNumber();
    public delegate string DelegateText();
    public partial class FrmRegistration : Form
    {
        DelegateText ClearText;
        DelegateNumber ClearNumber;
        public FrmRegistration()
        {
            InitializeComponent();
            ClearText = new DelegateText(StudentInfoClass.InitializeText);
        }
        
        private void FrmRegistration_Load(object sender, EventArgs e)
        {
            
        }
        
        private void clearButton_Click(object sender, EventArgs e)
        {
            
            studentNumberTextbox.Text = ClearText();
            programTextbox.Text = ClearText();
            lastNameTextbox.Text = ClearText();
            firstNameTextbox.Text = ClearText();
            middleNameTextbox.Text = ClearText();
            ageTextbox.Text = ClearText();
            contactNumberTextbox.Text = ClearText();
            addressRichTextbox.Text = ClearText();
        }
    }
    
    public class StudentInfoClass
    {
        public static string InitializeText()
        {
            return string.Empty;
        }
    }
}