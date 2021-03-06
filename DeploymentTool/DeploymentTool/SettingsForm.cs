﻿using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace DeploymentTool
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
            Set_button.Select();
        }

        private void Set_button_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.ip_setting = ip_setting_textBox.Text;
            Properties.Settings.Default.Save();
            toolStripStatusLabel2.Text = "Settings saved";
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            Location = new Point(Owner.Location.X, Owner.Location.Y + 30);
            ip_setting_textBox.Text = Properties.Settings.Default.ip_setting;
        }

        private void Install_button_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(@"C:\DeploymentTool"))
                Directory.CreateDirectory(@"C:\DeploymentTool");
            try
            {
                if (!File.Exists(@"C:\DeploymentTool\Microsoft.Tools.Connectivity.dll") || !File.Exists(@"C:\DeploymentTool\SirepClient.dll") ||
                !File.Exists(@"C:\DeploymentTool\SirepInterop.dll") || !File.Exists(@"C:\DeploymentTool\WinAppDeploy.dll") ||
                !File.Exists(@"C:\DeploymentTool\WinAppDeployCmd.exe") || !File.Exists(@"C:\DeploymentTool\WinAppDeployCommon.dll"))
                {
                    File.WriteAllBytes(@"C:\DeploymentTool\Microsoft.Tools.Connectivity.dll", Properties.Resources.Microsoft_Tools_Connectivity);
                    File.WriteAllBytes(@"C:\DeploymentTool\SirepClient.dll", Properties.Resources.SirepClient);
                    File.WriteAllBytes(@"C:\DeploymentTool\SirepInterop.dll", Properties.Resources.SirepInterop);
                    File.WriteAllBytes(@"C:\DeploymentTool\WinAppDeploy.dll", Properties.Resources.WinAppDeploy);
                    File.WriteAllBytes(@"C:\DeploymentTool\WinAppDeployCmd.exe", Properties.Resources.WinAppDeployCmd);
                    File.WriteAllBytes(@"C:\DeploymentTool\WinAppDeployCommon.dll", Properties.Resources.WinAppDeployCommon);
                    toolStripStatusLabel2.Text = "Files installed successfully";
                }
                else toolStripStatusLabel2.Text = "All files are ready";
            }
            catch
            {
                toolStripStatusLabel2.Text = "Run app as administrator and try again";
            }
        }
    }
}
