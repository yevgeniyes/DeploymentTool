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
            this.ipSet_textBox = new System.Windows.Forms.TextBox();
            this.Set_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ipSet_textBox
            // 
            this.ipSet_textBox.Location = new System.Drawing.Point(27, 49);
            this.ipSet_textBox.Name = "ipSet_textBox";
            this.ipSet_textBox.Size = new System.Drawing.Size(156, 20);
            this.ipSet_textBox.TabIndex = 0;
            // 
            // Set_button
            // 
            this.Set_button.Location = new System.Drawing.Point(233, 46);
            this.Set_button.Name = "Set_button";
            this.Set_button.Size = new System.Drawing.Size(75, 23);
            this.Set_button.TabIndex = 1;
            this.Set_button.Text = "Set";
            this.Set_button.UseVisualStyleBackColor = true;
            this.Set_button.Click += new System.EventHandler(this.Set_button_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(334, 361);
            this.Controls.Add(this.Set_button);
            this.Controls.Add(this.ipSet_textBox);
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ipSet_textBox;
        private System.Windows.Forms.Button Set_button;
    }
}