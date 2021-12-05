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

namespace _05HandsOnActivity2
{
    public partial class frmStudentRecord : Form
    {
        public frmStudentRecord()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            frmRegstration fr = new frmRegstration();
            this.Hide();
            fr.ShowDialog();
            this.Close();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            try
            {

                openFileDialog1.InitialDirectory = @"C:\";
                openFileDialog1.Title = "Browse Text File";
                openFileDialog1.DefaultExt = "txt";
                openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog1.ShowDialog();

                string path = openFileDialog1.FileName;
                StreamReader sr = new StreamReader(path);
                rtxtViewRecord.Text = sr.ReadToEnd();
                sr.Close();
            }
            catch (System.IO.FileNotFoundException ed)
            {
                MessageBox.Show(ed.Message, "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            rtxtViewRecord.Text = "";
            MessageBox.Show("Successfully Uploaded!", "Message");
        }
    }
}
