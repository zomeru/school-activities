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
            ClearNumber = new DelegateNumber(StudentInfoClass.InitializeNumber);
            InitializeData();
        }
        
        private void FrmRegistration_Load(object sender, EventArgs e)
        {
            
        }
        
        /* TEAM MEMBERS
         *  Zomer Gregorio
         *  Mark Joseph Yoldi
         *  Vince Hector Garcitos
         *  Lourence Jacaba
         *  Maureen Despabiladeras
         */
        
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

        static void GetFirstName()
        {
            
        }
        
        private void nextButton_Click(object sender, EventArgs e)
        {

            

            if (studentNumberTextbox.Text.Length < 1 ||
                programTextbox.Text.Length < 1 ||
                lastNameTextbox.Text.Length < 1 ||
                firstNameTextbox.Text.Length < 1 ||
                middleNameTextbox.Text.Length < 1 ||
                ageTextbox.Text.Length < 1 ||
                contactNumberTextbox.Text.Length < 1 ||
                addressRichTextbox.Text.Length < 1)
            {
                errorMessage.Text = "Please make sure all fields are not empty!";
            }
            else
            {
                FrmConfirm formConfirm = new FrmConfirm();
                formConfirm.studentNumberInfo.Text = studentNumberTextbox.Text;
                formConfirm.programInfo.Text = programTextbox.Text;
                formConfirm.lastNameInfo.Text = lastNameTextbox.Text;
                formConfirm.firstNameInfo.Text = firstNameTextbox.Text;
                formConfirm.middleNameInfo.Text = middleNameTextbox.Text;
                formConfirm.ageInfo.Text = ageTextbox.Text;
                formConfirm.contactNumberInfo.Text = contactNumberTextbox.Text;
                formConfirm.addressInfo.Text = addressRichTextbox.Text;
                formConfirm.ShowDialog();
            }
            
            
        }

        private void InitializeData()
        {
            // Delegate Long
            studentNumberTextbox.Text = Convert.ToString(ClearNumber());
            contactNumberTextbox.Text = Convert.ToString(ClearNumber());
            ageTextbox.Text = Convert.ToString(ClearNumber());
            
            // Delegate Text
            programTextbox.Text = ClearText();
            lastNameTextbox.Text = ClearText();
            firstNameTextbox.Text = ClearText();
            middleNameTextbox.Text = ClearText();
            addressRichTextbox.Text = ClearText();
        }
    }
    
    public class StudentInfoClass
    {
        public static string InitializeText()
        {
            return string.Empty;
        }

        public static long InitializeNumber()
        {
            return 0;
        }
        
    }
}