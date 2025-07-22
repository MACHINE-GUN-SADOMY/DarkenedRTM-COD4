using System;
using System.Windows.Forms;

namespace DarkenedRTM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCloseMeWindows_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ptcMainPictureMenu_Click(object sender, EventArgs e)
        {

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            ConnectionManager.Connect();
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            ConnectionManager.Attach();
        }

        private void btnRecovery_Click(object sender, EventArgs e)
        {
            {
                RecoveryForm recoveryForm = new RecoveryForm();
                recoveryForm.Show();
            }
        }
    }
}
