namespace DeploymentTool
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ip_setting_textBox = new System.Windows.Forms.TextBox();
            this.Set_button = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.Install_button = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ip_setting_textBox
            // 
            this.ip_setting_textBox.Location = new System.Drawing.Point(27, 49);
            this.ip_setting_textBox.Name = "ip_setting_textBox";
            this.ip_setting_textBox.Size = new System.Drawing.Size(156, 20);
            this.ip_setting_textBox.TabIndex = 0;
            // 
            // Set_button
            // 
            this.Set_button.Location = new System.Drawing.Point(233, 46);
            this.Set_button.Name = "Set_button";
            this.Set_button.Size = new System.Drawing.Size(75, 23);
            this.Set_button.TabIndex = 1;
            this.Set_button.Text = "Save";
            this.Set_button.UseVisualStyleBackColor = true;
            this.Set_button.Click += new System.EventHandler(this.Set_button_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 339);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(334, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 17);
            // 
            // Install_button
            // 
            this.Install_button.Location = new System.Drawing.Point(27, 148);
            this.Install_button.Name = "Install_button";
            this.Install_button.Size = new System.Drawing.Size(281, 41);
            this.Install_button.TabIndex = 3;
            this.Install_button.Text = "Install needed files";
            this.Install_button.UseVisualStyleBackColor = true;
            this.Install_button.Click += new System.EventHandler(this.Install_button_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(334, 361);
            this.Controls.Add(this.Install_button);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.Set_button);
            this.Controls.Add(this.ip_setting_textBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ip_setting_textBox;
        private System.Windows.Forms.Button Set_button;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.Button Install_button;
    }
}