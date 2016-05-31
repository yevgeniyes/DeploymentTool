using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace DeploymentTool
{
    public partial class MainForm : Form
    {
        private string userPathAndName;

        public MainForm()
        {
            InitializeComponent();
        }

        private void Settings_button_Click(object sender, EventArgs e)
        {
            SettingsForm form = new SettingsForm();
            form.Show();
        }

        private void Deploy_button_Click(object sender, EventArgs e)
        {
            string ip = ip_textBox.Text;
            string pin = pin_textBox.Text;
            
            if (string.IsNullOrWhiteSpace(ip) || string.IsNullOrWhiteSpace(userPathAndName))
            {
                toolStripStatusLabel1.Text = "Please enter ip and select bundle";
                return;
            }

            string command = @"C:\DeploymentTool\WinAppDeployCmd.exe install -file " + userPathAndName + " -ip "+ Properties.Settings.Default.ip_setting + ip + " -pin " + pin;
            if (string.IsNullOrWhiteSpace(pin)) command = command.Substring(0, command.Length - pin.Length - 6);

            ProcessStartInfo install = new ProcessStartInfo();
            install.FileName = "cmd.exe";
            install.Arguments = @"/c " + command + " && pause";
            Process.Start(install);

            toolStripStatusLabel1.Text = "Deploy started";
        }

        private void SelectBundle_button_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            userPathAndName = openFileDialog1.FileName;

            if (string.IsNullOrWhiteSpace(userPathAndName))
            {
                toolStripStatusLabel1.Text = "Bundle not selected";
                return;
            }
            else toolStripStatusLabel1.Text = "Bundle selected";
        }

        private void PackagesList_button_Click(object sender, EventArgs e)
        {
            string ip = ip_textBox.Text;
            string pin = pin_textBox.Text;

            if (string.IsNullOrWhiteSpace(ip))
            {
                toolStripStatusLabel1.Text = "Please enter ip";
                return;
            }

            string command2 = @"C:\DeploymentTool\WinAppDeployCmd.exe list -ip 192.168.4." + ip + " -pin " + pin;
            if (string.IsNullOrWhiteSpace(pin)) command2 = command2.Substring(0, command2.Length - 6);

            ProcessStartInfo list = new ProcessStartInfo();
            list.FileName = "cmd.exe";
            list.Arguments = @"/c" + command2 + " && pause";
            Process.Start(list);
        }

        private void UninstallPackage_button_Click(object sender, EventArgs e)
        {
            string ip = ip_textBox.Text;
            string pin = pin_textBox.Text;
            string package = package_textBox.Text;

            if (string.IsNullOrWhiteSpace(ip) || string.IsNullOrWhiteSpace(package))
            {
                toolStripStatusLabel1.Text = "Please enter ip and package name";
                return;
            }

            string command3 = @"C:\DeploymentTool\WinAppDeployCmd.exe uninstall -package " + package + " -ip 192.168.4." + ip + " -pin " + pin;
            if (string.IsNullOrWhiteSpace(pin)) command3 = command3.Substring(0, command3.Length - 6);

            ProcessStartInfo uninstall = new ProcessStartInfo();
            uninstall.FileName = "cmd.exe";
            uninstall.Arguments = @"/c" + command3 + " && pause";
            Process.Start(uninstall);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(@"C:\DeploymentTool"))
            {
                Directory.CreateDirectory(@"C:\DeploymentTool");
                try
                {
                    File.WriteAllBytes(@"C:\DeploymentTool\Microsoft.Tools.Connectivity.dll", Properties.Resources.Microsoft_Tools_Connectivity);
                    File.WriteAllBytes(@"C:\DeploymentTool\SirepClient.dll", Properties.Resources.SirepClient);
                    File.WriteAllBytes(@"C:\DeploymentTool\SirepInterop.dll", Properties.Resources.SirepInterop);
                    File.WriteAllBytes(@"C:\DeploymentTool\WinAppDeploy.dll", Properties.Resources.WinAppDeploy);
                    File.WriteAllBytes(@"C:\DeploymentTool\WinAppDeployCmd.exe", Properties.Resources.WinAppDeployCmd);
                    File.WriteAllBytes(@"C:\DeploymentTool\WinAppDeployCommon.dll", Properties.Resources.WinAppDeployCommon);
                    toolStripStatusLabel1.Text = "Files installed successfully";
                }
                catch
                {
                    toolStripStatusLabel1.Text = "Run app as administrator to complete setup";
                }
            } 
        }
    }
}
