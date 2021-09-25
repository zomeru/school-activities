using System;
using System.Windows.Forms;

namespace Account_Registration
{
    public partial class FrmConfirm : Form
    {
        public FrmConfirm()
        {
            InitializeComponent();
        }
        
        private void submitButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
            

        }
        
         private void FrmConfirm_FormClosing(object sender, FormClosingEventArgs e)
         {
             this.DialogResult = DialogResult.OK;

         }
    }
}