using System;
using PS3Lib;
using System.Windows.Forms;

namespace DarkenedRTM
{
    public static class ConnectionManager
    {
        public static PS3API PS3 = new PS3API(SelectAPI.ControlConsole);
        public static bool IsConnected { get; private set; } = false;
        public static bool IsAttached { get; private set; } = false;

        public enum NotifyIcon
        {
            INFO = 0,
            CAUTION = 1,
            FRIEND = 2,
            SLIDER = 3,
            WRONGWAY = 4,
            DIALOG = 5,
            TROPHY1 = 6,
            TROPHY2 = 7,
            TROPHY3 = 8
        }

        public static bool Connect()
        {
            try
            {
                if (!IsConnected)
                {
                    if (PS3.ConnectTarget())
                    {
                        IsConnected = true;
                        MessageBox.Show("Successfully connected to the PS3.", "Darkened RTM TOOL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        PS3.CCAPI.Notify(CCAPI.NotifyIcon.TROPHY1, "Darkened RTM Tool\nConnected successfully!");
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Failed to connect to the PS3.", "Darkened RTM TOOL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("You are already connected.", "Darkened RTM TOOL", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while trying to connect:\n" + ex.Message, "Darkened RTM TOOL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static bool Attach()
        {
            try
            {
                if (!IsConnected)
                {
                    MessageBox.Show("You must connect first.", "Darkened RTM TOOL", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (!IsAttached)
                {
                    if (PS3.AttachProcess())
                    {
                        IsAttached = true;
                        MessageBox.Show("Successfully attached to the process.", "Darkened RTM TOOL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        PS3.CCAPI.Notify(CCAPI.NotifyIcon.TROPHY1, "Darkened RTM Tool\nAttached successfully!");
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Failed to attach to the process.", "Darkened RTM TOOL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("You are already attached.", "Darkened RTM TOOL", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while trying to attach:\n" + ex.Message, "Darkened RTM TOOL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
