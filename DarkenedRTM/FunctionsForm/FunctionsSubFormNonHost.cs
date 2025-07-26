using PS3Lib;
using System;
using System.Text;
using System.Windows.Forms;

namespace DarkenedRTM.FunctionsForm
{
    public static class FunctionsSubFormNonHost
    {
        public static byte[] originalNameBytes;
        public static bool uavEnabled = false;
        public static bool steadyAimEnabled = false;
        public static bool noRecoilEnabled = false;
        public static bool toggleRedBoxes = false;
        private static PS3API PS3 => ConnectionManager.PS3;
        public static void SetName(string newName)
        {
            try
                {
                   if (!ConnectionManager.IsAttached)
                    {
                        MessageBox.Show("You must be attached to change the name.", "Darkened RTM TOOL", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    uint nameOffset = 0x122A4C64;
                    byte nameLength = 16;

                    byte[] nameBytes = new byte[nameLength];
                    byte[] inputBytes = Encoding.UTF8.GetBytes(newName);

                    // GUARDA EL NOMBRE ANTES DE SOBRESCRIBIRLO
                    originalNameBytes = new byte[nameLength];
                    PS3.GetMemory(nameOffset, originalNameBytes);

                    Array.Copy(inputBytes, nameBytes, Math.Min(inputBytes.Length, nameBytes.Length));
                    PS3.SetMemory(nameOffset, nameBytes);

                    PS3.CCAPI.Notify(CCAPI.NotifyIcon.TROPHY1, "Name changed successfully!");
                }
            catch (Exception ex)
            {
                MessageBox.Show("Error changing name: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void ToggleRedBoxes()
        {
            uint redBoxesOffset = 0x001206C8;
            byte[] redBoxesOn = { 0x60, 0x00, 0x00, 0x00 };
            byte[] redBoxesOff = { 0x41, 0x82, 0x00, 0x0C };


            toggleRedBoxes = !toggleRedBoxes;
            ConnectionManager.PS3.SetMemory(redBoxesOffset, toggleRedBoxes ? redBoxesOn : redBoxesOff);
        }

        public static void ToggleSuperSteadyAim()
        {
            uint offset = 0x00AB8EC;
            byte[] steadyAimOn = { 0x2C, 0x03, 0x00, 0x00 };
            byte[] steadyAimOff = { 0x40, 0x82, 0x00, 0x28 };

            steadyAimEnabled = !steadyAimEnabled;

            ConnectionManager.PS3.SetMemory(offset, steadyAimEnabled ? steadyAimOn : steadyAimOff);
        }

        public static void ToggleNoRecoil()
        {
            uint offset = 0x19B244;
            byte[] noRecoilOn = { 0x60, 0x00, 0x00, 0x00 };
            byte[] noRecoilOff = { 0x41, 0xA1, 0x00, 0x1C };

            noRecoilEnabled = !noRecoilEnabled;
            ConnectionManager.PS3.SetMemory(offset, noRecoilEnabled ? noRecoilOn : noRecoilOff);
        }

        public static void ToggleUAV()
        {
            uint offset = 0x0011FD98;
            byte[] onPatch = { 0x60, 0x00, 0x00, 0x00 };
            byte[] offPatch = { 0x41, 0x82, 0x00, 0x08 };

            uavEnabled = !uavEnabled;
            ConnectionManager.PS3.SetMemory(offset, uavEnabled ? onPatch : offPatch);
        }


        public static void ResetName()
        {
            uint nameOffset = 0x122A4C64;

            try
            {
                if (!ConnectionManager.IsAttached)
                {
                    MessageBox.Show("You must be attached to change the name.", "Darkened RTM TOOL", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (originalNameBytes != null)
                {
                    PS3.SetMemory(nameOffset, originalNameBytes);
                    MessageBox.Show("The Name has been reset successfully.", "Darkened RTM TOOL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Original name not stored. Please change the name first.", "Darkened RTM TOOL", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error to Reset Name: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    // INCLUIR VALIDADORES DE ATTACH Y CONNECT 
}
