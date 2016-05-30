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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ip_textBox = new System.Windows.Forms.TextBox();
            this.pin_textBox = new System.Windows.Forms.TextBox();
            this.SelectBundle_button = new System.Windows.Forms.Button();
            this.Deploy_button = new System.Windows.Forms.Button();
            this.package_textBox = new System.Windows.Forms.TextBox();
            this.PackagesList_button = new System.Windows.Forms.Button();
            this.UninstallPackage_button = new System.Windows.Forms.Button();
            this.Settings_button = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ip_textBox
            // 
            this.ip_textBox.Location = new System.Drawing.Point(85, 141);
            this.ip_textBox.Name = "ip_textBox";
            this.ip_textBox.Size = new System.Drawing.Size(79, 20);
            this.ip_textBox.TabIndex = 0;
            // 
            // pin_textBox
            // 
            this.pin_textBox.Location = new System.Drawing.Point(85, 167);
            this.pin_textBox.Name = "pin_textBox";
            this.pin_textBox.Size = new System.Drawing.Size(79, 20);
            this.pin_textBox.TabIndex = 1;
            // 
            // SelectBundle_button
            // 
            this.SelectBundle_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.SelectBundle_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectBundle_button.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectBundle_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.SelectBundle_button.Location = new System.Drawing.Point(170, 141);
            this.SelectBundle_button.Name = "SelectBundle_button";
            this.SelectBundle_button.Size = new System.Drawing.Size(116, 46);
            this.SelectBundle_button.TabIndex = 2;
            this.SelectBundle_button.Text = "Select Bundle";
            this.SelectBundle_button.UseVisualStyleBackColor = false;
            this.SelectBundle_button.Click += new System.EventHandler(this.SelectBundle_button_Click);
            // 
            // Deploy_button
            // 
            this.Deploy_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.Deploy_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Deploy_button.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Deploy_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.Deploy_button.Location = new System.Drawing.Point(28, 193);
            this.Deploy_button.Name = "Deploy_button";
            this.Deploy_button.Size = new System.Drawing.Size(279, 43);
            this.Deploy_button.TabIndex = 3;
            this.Deploy_button.Text = "Deploy";
            this.Deploy_button.UseVisualStyleBackColor = false;
            this.Deploy_button.Click += new System.EventHandler(this.Deploy_button_Click);
            // 
            // package_textBox
            // 
            this.package_textBox.Location = new System.Drawing.Point(28, 274);
            this.package_textBox.Name = "package_textBox";
            this.package_textBox.Size = new System.Drawing.Size(279, 20);
            this.package_textBox.TabIndex = 5;
            // 
            // PackagesList_button
            // 
            this.PackagesList_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.PackagesList_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PackagesList_button.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PackagesList_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.PackagesList_button.Location = new System.Drawing.Point(28, 300);
            this.PackagesList_button.Name = "PackagesList_button";
            this.PackagesList_button.Size = new System.Drawing.Size(116, 46);
            this.PackagesList_button.TabIndex = 6;
            this.PackagesList_button.Text = "Packages list";
            this.PackagesList_button.UseVisualStyleBackColor = false;
            this.PackagesList_button.Click += new System.EventHandler(this.PackagesList_button_Click);
            // 
            // UninstallPackage_button
            // 
            this.UninstallPackage_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.UninstallPackage_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UninstallPackage_button.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UninstallPackage_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.UninstallPackage_button.Location = new System.Drawing.Point(191, 300);
            this.UninstallPackage_button.Name = "UninstallPackage_button";
            this.UninstallPackage_button.Size = new System.Drawing.Size(116, 46);
            this.UninstallPackage_button.TabIndex = 7;
            this.UninstallPackage_button.Text = "Uninstall";
            this.UninstallPackage_button.UseVisualStyleBackColor = false;
            this.UninstallPackage_button.Click += new System.EventHandler(this.UninstallPackage_button_Click);
            // 
            // Settings_button
            // 
            this.Settings_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.Settings_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Settings_button.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Settings_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.Settings_button.Image = ((System.Drawing.Image)(resources.GetObject("Settings_button.Image")));
            this.Settings_button.Location = new System.Drawing.Point(271, 9);
            this.Settings_button.Name = "Settings_button";
            this.Settings_button.Size = new System.Drawing.Size(51, 46);
            this.Settings_button.TabIndex = 10;
            this.Settings_button.UseVisualStyleBackColor = false;
            this.Settings_button.Click += new System.EventHandler(this.Settings_button_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 369);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(334, 65);
            this.panel1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.label1.Location = new System.Drawing.Point(8, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "WINDOWS 10 MOBILE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.label2.Location = new System.Drawing.Point(5, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(327, 53);
            this.label2.TabIndex = 1;
            this.label2.Text = "DEPLOYMENT TOOL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.label3.Location = new System.Drawing.Point(54, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 23);
            this.label3.TabIndex = 13;
            this.label3.Text = "ip -";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.label4.Location = new System.Drawing.Point(44, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 23);
            this.label4.TabIndex = 14;
            this.label4.Text = "pin -";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.label5.Location = new System.Drawing.Point(103, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 23);
            this.label5.TabIndex = 15;
            this.label5.Text = "package name";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.ClientSize = new System.Drawing.Size(334, 391);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pin_textBox);
            this.Controls.Add(this.ip_textBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.Settings_button);
            this.Controls.Add(this.UninstallPackage_button);
            this.Controls.Add(this.PackagesList_button);
            this.Controls.Add(this.package_textBox);
            this.Controls.Add(this.Deploy_button);
            this.Controls.Add(this.SelectBundle_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Deployment Tool";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ip_textBox;
        private System.Windows.Forms.TextBox pin_textBox;
        private System.Windows.Forms.Button SelectBundle_button;
        private System.Windows.Forms.Button Deploy_button;
        private System.Windows.Forms.TextBox package_textBox;
        private System.Windows.Forms.Button PackagesList_button;
        private System.Windows.Forms.Button UninstallPackage_button;
        private System.Windows.Forms.Button Settings_button;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

