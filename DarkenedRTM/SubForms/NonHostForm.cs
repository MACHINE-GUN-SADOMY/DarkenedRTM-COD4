using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DarkenedRTM.FunctionsForm;

namespace DarkenedRTM.SubForms
{
    public partial class NonHostForm : Form
    {
        public NonHostForm()
        {
            InitializeComponent();
        }

        private void lblNameSubForm_Click(object sender, EventArgs e)
        {

        }

        private void lblRedBoxes_Click(object sender, EventArgs e)
        {

        }

        private void NonHostForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSetName_Click(object sender, EventArgs e)
        {
            string customName = txtSetName.Text;
            FunctionsSubFormNonHost.SetName(customName);
        }

        private void btnCloseMeWindows_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnToggleUAV_Click(object sender, EventArgs e)
        {
            FunctionsSubFormNonHost.ToggleUAV();

            if (FunctionsSubFormNonHost.uavEnabled)
            {
                btnToggleUAV.Text = "UAV ON";
                btnToggleUAV.BackColor = Color.Green;
            }
            else
            {
                btnToggleUAV.Text = "UAV OFF";
                btnToggleUAV.BackColor = Color.Red;
            }
        }

        private void btnTogleSteadyAim_Click(object sender, EventArgs e)
        {
            FunctionsSubFormNonHost.ToggleSuperSteadyAim();

            if (FunctionsSubFormNonHost.steadyAimEnabled)
            {
                btnTogleSteadyAim.Text = "ON";
                btnTogleSteadyAim.BackColor = Color.Green;
            }
            else
            {
                btnTogleSteadyAim.Text = "OFF";
                btnTogleSteadyAim.BackColor = Color.Red;
            }
        }

        private void btnResetName_Click(object sender, EventArgs e)
        {
            FunctionsSubFormNonHost.ResetName();
        }

        private void btnTogleNoRecoil_Click(object sender, EventArgs e)
        {
            FunctionsSubFormNonHost.ToggleNoRecoil();

            if (FunctionsSubFormNonHost.toggleRedBoxes)
            {
                btnResetName.Text = "ON";
                btnResetName.BackColor = Color.Green;
            }
            else
            {
                btnResetName.Text = "OFF";
                btnResetName.BackColor = Color.Red;
            }
        }

        private void btnTogleRedBoxes_Click(object sender, EventArgs e)
        {
            FunctionsSubFormNonHost.ToggleRedBoxes();

            if (FunctionsSubFormNonHost.toggleRedBoxes) 
            {
                btnTogleRedBoxes.Text = "ON";
                btnTogleRedBoxes.BackColor = Color.Green;
            }
            else
            {
                btnTogleRedBoxes.Text = "OFF";
                btnTogleRedBoxes.BackColor = Color.Red;
            }
        }
    }
}
