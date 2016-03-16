namespace DeploymentTool
{
    partial class MainForm
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
            this.ip_textBox = new System.Windows.Forms.TextBox();
            this.pin_textBox = new System.Windows.Forms.TextBox();
            this.SelectBundle_button = new System.Windows.Forms.Button();
            this.Deploy_button = new System.Windows.Forms.Button();
            this.SolitaireUninstall_button = new System.Windows.Forms.Button();
            this.package_textBox = new System.Windows.Forms.TextBox();
            this.PackagesList_button = new System.Windows.Forms.Button();
            this.UninstallPackage_button = new System.Windows.Forms.Button();
            this.NetOn_button = new System.Windows.Forms.Button();
            this.NetOff_button = new System.Windows.Forms.Button();
            this.Settings_button = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ip_textBox
            // 
            this.ip_textBox.Location = new System.Drawing.Point(27, 119);
            this.ip_textBox.Name = "ip_textBox";
            this.ip_textBox.Size = new System.Drawing.Size(112, 20);
            this.ip_textBox.TabIndex = 0;
            // 
            // pin_textBox
            // 
            this.pin_textBox.Location = new System.Drawing.Point(27, 145);
            this.pin_textBox.Name = "pin_textBox";
            this.pin_textBox.Size = new System.Drawing.Size(112, 20);
            this.pin_textBox.TabIndex = 1;
            // 
            // SelectBundle_button
            // 
            this.SelectBundle_button.Location = new System.Drawing.Point(190, 119);
            this.SelectBundle_button.Name = "SelectBundle_button";
            this.SelectBundle_button.Size = new System.Drawing.Size(116, 46);
            this.SelectBundle_button.TabIndex = 2;
            this.SelectBundle_button.Text = "Select Bundle";
            this.SelectBundle_button.UseVisualStyleBackColor = true;
            this.SelectBundle_button.Click += new System.EventHandler(this.SelectBundle_button_Click);
            // 
            // Deploy_button
            // 
            this.Deploy_button.Location = new System.Drawing.Point(27, 171);
            this.Deploy_button.Name = "Deploy_button";
            this.Deploy_button.Size = new System.Drawing.Size(279, 43);
            this.Deploy_button.TabIndex = 3;
            this.Deploy_button.Text = "Deploy";
            this.Deploy_button.UseVisualStyleBackColor = true;
            this.Deploy_button.Click += new System.EventHandler(this.Deploy_button_Click);
            // 
            // SolitaireUninstall_button
            // 
            this.SolitaireUninstall_button.Location = new System.Drawing.Point(27, 220);
            this.SolitaireUninstall_button.Name = "SolitaireUninstall_button";
            this.SolitaireUninstall_button.Size = new System.Drawing.Size(279, 43);
            this.SolitaireUninstall_button.TabIndex = 4;
            this.SolitaireUninstall_button.Text = "Solitaire uninstall";
            this.SolitaireUninstall_button.UseVisualStyleBackColor = true;
            this.SolitaireUninstall_button.Click += new System.EventHandler(this.SolitaireUninstall_button_Click);
            // 
            // package_textBox
            // 
            this.package_textBox.Location = new System.Drawing.Point(27, 332);
            this.package_textBox.Name = "package_textBox";
            this.package_textBox.Size = new System.Drawing.Size(279, 20);
            this.package_textBox.TabIndex = 5;
            // 
            // PackagesList_button
            // 
            this.PackagesList_button.Location = new System.Drawing.Point(27, 358);
            this.PackagesList_button.Name = "PackagesList_button";
            this.PackagesList_button.Size = new System.Drawing.Size(116, 46);
            this.PackagesList_button.TabIndex = 6;
            this.PackagesList_button.Text = "Packages list";
            this.PackagesList_button.UseVisualStyleBackColor = true;
            this.PackagesList_button.Click += new System.EventHandler(this.PackagesList_button_Click);
            // 
            // UninstallPackage_button
            // 
            this.UninstallPackage_button.Location = new System.Drawing.Point(190, 358);
            this.UninstallPackage_button.Name = "UninstallPackage_button";
            this.UninstallPackage_button.Size = new System.Drawing.Size(116, 46);
            this.UninstallPackage_button.TabIndex = 7;
            this.UninstallPackage_button.Text = "Uninstall package";
            this.UninstallPackage_button.UseVisualStyleBackColor = true;
            this.UninstallPackage_button.Click += new System.EventHandler(this.UninstallPackage_button_Click);
            // 
            // NetOn_button
            // 
            this.NetOn_button.Location = new System.Drawing.Point(88, 442);
            this.NetOn_button.Name = "NetOn_button";
            this.NetOn_button.Size = new System.Drawing.Size(55, 38);
            this.NetOn_button.TabIndex = 8;
            this.NetOn_button.Text = "On";
            this.NetOn_button.UseVisualStyleBackColor = true;
            this.NetOn_button.Click += new System.EventHandler(this.NetOn_button_Click);
            // 
            // NetOff_button
            // 
            this.NetOff_button.Location = new System.Drawing.Point(190, 442);
            this.NetOff_button.Name = "NetOff_button";
            this.NetOff_button.Size = new System.Drawing.Size(55, 38);
            this.NetOff_button.TabIndex = 9;
            this.NetOff_button.Text = "Off";
            this.NetOff_button.UseVisualStyleBackColor = true;
            this.NetOff_button.Click += new System.EventHandler(this.NetOff_button_Click);
            // 
            // Settings_button
            // 
            this.Settings_button.Location = new System.Drawing.Point(251, 12);
            this.Settings_button.Name = "Settings_button";
            this.Settings_button.Size = new System.Drawing.Size(55, 38);
            this.Settings_button.TabIndex = 10;
            this.Settings_button.Text = "Settings";
            this.Settings_button.UseVisualStyleBackColor = true;
            this.Settings_button.Click += new System.EventHandler(this.Settings_button_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 539);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(334, 22);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Bundle|*.appxbundle|Appx|*.appx|All Files|*.*";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 561);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.Settings_button);
            this.Controls.Add(this.NetOff_button);
            this.Controls.Add(this.NetOn_button);
            this.Controls.Add(this.UninstallPackage_button);
            this.Controls.Add(this.PackagesList_button);
            this.Controls.Add(this.package_textBox);
            this.Controls.Add(this.SolitaireUninstall_button);
            this.Controls.Add(this.Deploy_button);
            this.Controls.Add(this.SelectBundle_button);
            this.Controls.Add(this.pin_textBox);
            this.Controls.Add(this.ip_textBox);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(350, 600);
            this.MinimumSize = new System.Drawing.Size(350, 600);
            this.Name = "MainForm";
            this.Text = "Deployment Tool";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ip_textBox;
        private System.Windows.Forms.TextBox pin_textBox;
        private System.Windows.Forms.Button SelectBundle_button;
        private System.Windows.Forms.Button Deploy_button;
        private System.Windows.Forms.Button SolitaireUninstall_button;
        private System.Windows.Forms.TextBox package_textBox;
        private System.Windows.Forms.Button PackagesList_button;
        private System.Windows.Forms.Button UninstallPackage_button;
        private System.Windows.Forms.Button NetOn_button;
        private System.Windows.Forms.Button NetOff_button;
        private System.Windows.Forms.Button Settings_button;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

