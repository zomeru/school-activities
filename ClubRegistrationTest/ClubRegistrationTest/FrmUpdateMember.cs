using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;

namespace ClubRegistrationTest
{
    public partial class FrmUpdateMember : Form
    { 

        private DataTable dataTable = new DataTable();
        private SqlConnection con;
        private SqlCommand cmd;
        private string conStr = @"Data Source=ZOMER;Initial Catalog=ClubDB;Integrated Security=True";

 
        private FrmClubRegistration frmReg = new FrmClubRegistration();
        public FrmUpdateMember()
        {
            InitializeComponent();
        }

        private void FrmUpdateMember_Load(object sender, EventArgs e)
        {
            

            cbGenderUpdate.Items.AddRange(frmReg.Genders);
            cbProgramUpdate.Items.AddRange(frmReg.Programs);
            PullData();
        }

        public void PullData()
        {
            
            string query = "SELECT * FROM ClubMembers";
            con = new SqlConnection(conStr);
            cmd = new SqlCommand(query, con);
            SqlDataReader dataReader;
            con.Open();

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dataTable);
            dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                cbStudentIdUpdate.Items.Add(dataReader["StudentID"]);
            }
            con.Close();
            adapter.Dispose();
        }

        private void ChangeUpdateFormData()
        {
            
                DataRow[] rows = dataTable.Select($"StudentID = {cbStudentIdUpdate.Text}");

                foreach (DataRow row in rows)
                {
                    Debug.WriteLine(row.Field<string>("FirstName"));
                    tbLastNameUpdate.Text = row.Field<string>("LastName");
                    tbFirstNameUpdate.Text = row.Field<string>("FirstName");
                    tbMiddleNameUpdate.Text = row.Field<string>("MiddleName");
                    tbAgeUpdate.Text = $"{row.Field<int>("Age")}";
                    cbGenderUpdate.Text = row.Field<string>("Gender");
                    cbProgramUpdate.Text = row.Field<string>("Program");
                }
        }

        private void cbStudentIdUpdate_SelectedValueChanged(object sender, EventArgs e)
        {
            ChangeUpdateFormData();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string query = "UPDATE ClubMembers SET LastName=@lastName, FirstName=@firstName, " +
                "MiddleName=@middleName, Age=@age, Gender=@gender, Program=@program WHERE StudentID=" + cbStudentIdUpdate.Text;
            con = new SqlConnection(conStr);
            cmd = new SqlCommand(query, con);
            con.Open();
            cmd.Parameters.AddWithValue("lastName", tbLastNameUpdate.Text);
            cmd.Parameters.AddWithValue("firstName", tbFirstNameUpdate.Text);
            cmd.Parameters.AddWithValue("middleName", tbMiddleNameUpdate.Text);
            cmd.Parameters.AddWithValue("age", Convert.ToInt32(tbAgeUpdate.Text));
            cmd.Parameters.AddWithValue("gender", cbGenderUpdate.Text);
            cmd.Parameters.AddWithValue("program", cbProgramUpdate.Text);

            cmd.ExecuteNonQuery();
            con.Close();

            FrmClubRegistration form = Application.OpenForms.OfType<FrmClubRegistration>().FirstOrDefault();
            if (form != null)
            {
                form.btnRefresh.PerformClick();
            }
        }
    }
}
