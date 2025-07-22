using System;
using System.Windows.Forms;

namespace DarkenedRTM
{
    public partial class RecoveryForm : Form
    {
        public RecoveryForm()
        {
            InitializeComponent();
        }

        private void btnCloseMeWindows_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSetPrestige_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtSetPrestige.Text, out int prestige) && prestige >= 0 && prestige <= 10)
            {
                ConnectionManager.PS3.SetMemory(0x12c00f34, ToBigEndian(prestige));
                MessageBox.Show("Prestige set successfully!");
            }
            else
            {
                MessageBox.Show("Please enter a valid prestige (0–10).");
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            byte[] maxLevel = new byte[] { 0x00, 0x01, 0xD5, 0xDC };
            ConnectionManager.PS3.SetMemory(0x12c00ed0, maxLevel);
            MessageBox.Show("Max level (55) set successfully!");
        }

        private void btnUnlockAll_Click(object sender, EventArgs e)
        {
            byte[] unlockAll = new byte[] { 0xFF, 0xFF, 0xFF, 0xFF };
            ConnectionManager.PS3.SetMemory(0x12C010D0, unlockAll);
            MessageBox.Show("Unlock All applied!");
        }

        private void btnSetKd_Click(object sender, EventArgs e)
        {
            if (float.TryParse(txtSetKdRatio.Text, out float kd))
            {
                ConnectionManager.PS3.SetMemory(0x12c00f08, ToBigEndian(kd));
                MessageBox.Show("K/D Ratio set successfully!");
            }
            else
            {
                MessageBox.Show("Enter a valid decimal number for K/D Ratio.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtScore.Text, out int score))
            {
                ConnectionManager.PS3.SetMemory(0x12c00ed4, ToBigEndian(score));
                MessageBox.Show("Score set successfully!");
            }
            else
            {
                MessageBox.Show("Enter a valid number for score.");
            }
        }

        private void btnSetDeaths_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtSetDeaths.Text, out int deaths))
            {
                ConnectionManager.PS3.SetMemory(0x12c00ee0, ToBigEndian(deaths));
                MessageBox.Show("Deaths set successfully!");
            }
            else
            {
                MessageBox.Show("Enter a valid number for deaths.");
            }
        }

        private void btnSetKills_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtSetKills.Text, out int kills))
            {
                ConnectionManager.PS3.SetMemory(0x12c00ed8, ToBigEndian(kills));
                MessageBox.Show("Kills set successfully!");
            }
            else
            {
                MessageBox.Show("Enter a valid number for kills.");
            }
        }

        private byte[] ToBigEndian(int value)
        {
            byte[] bytes = BitConverter.GetBytes(value);
            Array.Reverse(bytes); 
            return bytes;
        }

        private byte[] ToBigEndian(float value)
        {
            byte[] bytes = BitConverter.GetBytes(value);
            Array.Reverse(bytes);
            return bytes;
        }
    }
}
