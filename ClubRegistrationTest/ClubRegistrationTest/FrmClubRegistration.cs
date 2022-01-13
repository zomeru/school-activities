using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubRegistrationTest
{
    public partial class FrmClubRegistration : Form
    {

        private ClassRegistrationQuery clubRegistrationQuery;
        private int ID, Age, count;
        private string FirstName, MiddleName, LastName, Gender, Program;
        private long StudentId;

        public string[] Programs = { "BS in Information Technology", "BS in Computer Science", "BS in Business Administration", "BS in Hospitality Manage Management" };

        public string[] Genders = { "Male", "Female" };

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FrmUpdateMember updateForm = new FrmUpdateMember();
            updateForm.Show();
        }

        public void btnRefresh_Click_1(object sender, EventArgs e)
        {
            RefreshListOfClubMembers();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            long studentId = Convert.ToInt64(tbStudentId.Text);
            string firstName = tbFirstName.Text;
            string middleName = tbMiddleName.Text;
            string lastName = tbLastName.Text;
            int age = Convert.ToInt32(tbAge.Text);
            string gender = cbGender.Text;
            string program = cbProgram.Text;
            clubRegistrationQuery.RegisterStudent(RegistrationID(), studentId, firstName, middleName, lastName, age, gender, program);
        }

       

        public FrmClubRegistration()
        {
            InitializeComponent();
        }

        private void FrmClubRegistration_Load(object sender, EventArgs e)
        {
            cbGender.Items.AddRange(Genders);
            cbProgram.Items.AddRange(Programs);
            clubRegistrationQuery = new ClassRegistrationQuery();
            RefreshListOfClubMembers();
        }

        public void RefreshListOfClubMembers()
        {
            clubRegistrationQuery.DisplayList();
            dataGridView1.DataSource = clubRegistrationQuery.bindingSource;
        }

        public int RegistrationID()
        {
            return count += 1;
        }
    }
}
