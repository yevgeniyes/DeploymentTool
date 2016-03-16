using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeploymentTool
{
    public partial class MainForm : Form
    {
        string userPathAndName = "";

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
            

            if (ip == "" || userPathAndName == "")
            {
                toolStripStatusLabel1.Text = "Please enter IP and select BUNDLE";
                //MessageBox.Show("Please enter IP and select BUNDLE");
                return;
            }

            string command = @"C:\""Program Files (x86)""\""Windows Kits""\10\bin\x86\WinAppDeployCmd.exe install -file " + userPathAndName + " -ip 192.168.4." + ip + " -pin " + pin;

            //command without pin
            if (pin == "") command = command.Substring(0, command.Length - 6);

            ProcessStartInfo install = new ProcessStartInfo();
            install.FileName = "cmd.exe";
            install.Arguments = @"/c " + command + " && pause";
            Process.Start(install);
        }

        private void SelectBundle_button_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            userPathAndName = openFileDialog1.FileName;

            if (userPathAndName == "") return;
            //MessageBox.Show("Please select BUNDLE");
            else toolStripStatusLabel1.Text = "Bundle selected";
        }

        private void PackagesList_button_Click(object sender, EventArgs e)
        {
            string ip = ip_textBox.Text;
            string pin = pin_textBox.Text;

            if (ip == "")
            {
                toolStripStatusLabel1.Text = "Please enter IP";
                return;
            }

            string command2 = @"C:\""Program Files (x86)""\""Windows Kits""\10\bin\x86\WinAppDeployCmd.exe list -ip 192.168.4." + ip + " -pin " + pin;
            if (pin == "") command2 = command2.Substring(0, command2.Length - 6);
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

            if (ip == "" || package == "")
            {
                toolStripStatusLabel1.Text = "Please enter IP and PACKAGE name";
                return;
            }

            string command3 = @"C:\""Program Files (x86)""\""Windows Kits""\10\bin\x86\WinAppDeployCmd.exe uninstall -package " + package + " -ip 192.168.4." + ip + " -pin " + pin;
            if (pin == "") command3 = command3.Substring(0, command3.Length - 6);
            ProcessStartInfo uninstall = new ProcessStartInfo();
            uninstall.FileName = "cmd.exe";
            uninstall.Arguments = @"/c" + command3 + " && pause";
            Process.Start(uninstall);
        }

        private void SolitaireUninstall_button_Click(object sender, EventArgs e)
        {
            string ip = ip_textBox.Text;
            string pin = pin_textBox.Text;
            string appxname;

            if (ip == "")
            {
                toolStripStatusLabel1.Text = "Please enter IP";
                return;
            }

            string command2 = @"C:\""Program Files (x86)""\""Windows Kits""\10\bin\x86\WinAppDeployCmd.exe list -ip 192.168.4." + ip + " -pin " + pin;
            if (pin == "") command2 = command2.Substring(0, command2.Length - 6);
            ProcessStartInfo listappx = new ProcessStartInfo();
            System.IO.Directory.CreateDirectory(@"C:\deployTemp");
            listappx.FileName = "cmd.exe";
            listappx.Arguments = @"/c" + command2 + @" >C:\deployTemp\OutputLog.txt";
            Process.Start(listappx);
            //>%USERPROFILE%\AppData\Local\temp\OutputLog.txt
            System.Threading.Thread.Sleep(5000);
            System.IO.StreamReader file = new System.IO.StreamReader(@"C:\deployTemp\OutputLog.txt");
            while ((appxname = file.ReadLine()) != null)
            {
                if (appxname.Contains("MicrosoftSolitaireCollection"))
                {
                    string command3 = @"C:\""Program Files (x86)""\""Windows Kits""\10\bin\x86\WinAppDeployCmd.exe uninstall -package " + appxname + " -ip 192.168.4." + ip + " -pin " + pin;
                    if (pin == "") command3 = command3.Substring(0, command3.Length - 6);
                    ProcessStartInfo Appxremove = new ProcessStartInfo();
                    Appxremove.FileName = "cmd.exe";
                    Appxremove.Arguments = @"/c" + command3 + " && pause";
                    Process.Start(Appxremove);
                }
            }
            file.Close();
            try
            {
                System.IO.File.Delete(@"C:\deployTemp\OutputLog.txt");
                System.IO.Directory.Delete(@"C:\deployTemp");
            }
            catch { throw new Exception("Directory/File does not exist"); }
        }

        private void NetOn_button_Click(object sender, EventArgs e)
        {
            Process.Start("cmd.exe", @"/c net use X: \\kr-vsobuild01\AutoBuildsDrop");
        }

        private void NetOff_button_Click(object sender, EventArgs e)
        {
            Process.Start("cmd.exe", @"/c net use X: /delete");
        }
    }
}
