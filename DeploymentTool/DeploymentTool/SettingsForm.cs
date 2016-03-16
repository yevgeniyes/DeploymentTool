using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeploymentTool
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void Set_button_Click(object sender, EventArgs e)
        {
            ProgramSettings.Default.ipSet = ipSet_textBox.Text;
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            ipSet_textBox.Text = ProgramSettings.Default.ipSet;
        }
    }
}
