namespace AssultCube_Trainer.Core
{
    partial class Form1
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
            this.healthHackButton = new System.Windows.Forms.Button();
            this.lookingForProcess = new System.ComponentModel.BackgroundWorker();
            this.processLabel = new System.Windows.Forms.Label();
            this.processNameLabel = new System.Windows.Forms.Label();
            this.ammoHackButton = new System.Windows.Forms.Button();
            this.pistolAmmoCheatButton = new System.Windows.Forms.Button();
            this.infiniteGranadeButton = new System.Windows.Forms.Button();
            this.infiniteArmourButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // healthHackButton
            // 
            this.healthHackButton.Location = new System.Drawing.Point(2, 1);
            this.healthHackButton.Name = "healthHackButton";
            this.healthHackButton.Size = new System.Drawing.Size(227, 81);
            this.healthHackButton.TabIndex = 0;
            this.healthHackButton.Text = "Health Hack";
            this.healthHackButton.UseVisualStyleBackColor = true;
            this.healthHackButton.Click += new System.EventHandler(this.healthHackButton_Click);
            // 
            // lookingForProcess
            // 
            this.lookingForProcess.WorkerReportsProgress = true;
            this.lookingForProcess.DoWork += new System.ComponentModel.DoWorkEventHandler(this.lookingForProcess_DoWork);
            this.lookingForProcess.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.lookingForProcess_ProgressChanged);
            this.lookingForProcess.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.lookingForProcess_RunWorkerCompleted);
            // 
            // processLabel
            // 
            this.processLabel.Location = new System.Drawing.Point(715, 1);
            this.processLabel.Name = "processLabel";
            this.processLabel.Size = new System.Drawing.Size(97, 15);
            this.processLabel.TabIndex = 1;
            this.processLabel.Text = "Process:";
            // 
            // processNameLabel
            // 
            this.processNameLabel.ForeColor = System.Drawing.Color.Red;
            this.processNameLabel.Location = new System.Drawing.Point(759, 1);
            this.processNameLabel.Name = "processNameLabel";
            this.processNameLabel.Size = new System.Drawing.Size(67, 24);
            this.processNameLabel.TabIndex = 2;
            this.processNameLabel.Text = "N/A";
            // 
            // ammoHackButton
            // 
            this.ammoHackButton.Location = new System.Drawing.Point(2, 159);
            this.ammoHackButton.Name = "ammoHackButton";
            this.ammoHackButton.Size = new System.Drawing.Size(227, 86);
            this.ammoHackButton.TabIndex = 3;
            this.ammoHackButton.Text = "Infinite Riffile Ammo";
            this.ammoHackButton.UseVisualStyleBackColor = true;
            this.ammoHackButton.Click += new System.EventHandler(this.riffleAmmoHackButton_Click);
            // 
            // pistolAmmoCheatButton
            // 
            this.pistolAmmoCheatButton.Location = new System.Drawing.Point(2, 251);
            this.pistolAmmoCheatButton.Name = "pistolAmmoCheatButton";
            this.pistolAmmoCheatButton.Size = new System.Drawing.Size(227, 77);
            this.pistolAmmoCheatButton.TabIndex = 4;
            this.pistolAmmoCheatButton.Text = "Infinite Pistol Ammo";
            this.pistolAmmoCheatButton.UseVisualStyleBackColor = true;
            this.pistolAmmoCheatButton.Click += new System.EventHandler(this.pistolAmmoCheatButton_Click);
            // 
            // infiniteGranadeButton
            // 
            this.infiniteGranadeButton.Location = new System.Drawing.Point(2, 334);
            this.infiniteGranadeButton.Name = "infiniteGranadeButton";
            this.infiniteGranadeButton.Size = new System.Drawing.Size(227, 75);
            this.infiniteGranadeButton.TabIndex = 5;
            this.infiniteGranadeButton.Text = "Infinite Granade";
            this.infiniteGranadeButton.UseVisualStyleBackColor = true;
            this.infiniteGranadeButton.Click += new System.EventHandler(this.infiniteGranadeButton_Click);
            // 
            // infiniteArmourButton
            // 
            this.infiniteArmourButton.Location = new System.Drawing.Point(2, 88);
            this.infiniteArmourButton.Name = "infiniteArmourButton";
            this.infiniteArmourButton.Size = new System.Drawing.Size(226, 65);
            this.infiniteArmourButton.TabIndex = 6;
            this.infiniteArmourButton.Text = "Armour Hack";
            this.infiniteArmourButton.UseVisualStyleBackColor = true;
            this.infiniteArmourButton.Click += new System.EventHandler(this.infiniteArmourButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 475);
            this.Controls.Add(this.infiniteArmourButton);
            this.Controls.Add(this.infiniteGranadeButton);
            this.Controls.Add(this.pistolAmmoCheatButton);
            this.Controls.Add(this.ammoHackButton);
            this.Controls.Add(this.processNameLabel);
            this.Controls.Add(this.processLabel);
            this.Controls.Add(this.healthHackButton);
            this.Name = "Form1";
            this.Text = "Assult Cube Trainer - v0.1.6";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button infiniteArmourButton;

        private System.Windows.Forms.Button infiniteGranadeButton;

        private System.Windows.Forms.Button pistolAmmoCheatButton;

        private System.Windows.Forms.Button ammoHackButton;

        private System.Windows.Forms.Label processNameLabel;

        private System.Windows.Forms.Label processLabel;

        private System.ComponentModel.BackgroundWorker lookingForProcess;

        private System.Windows.Forms.Button healthHackButton;

        #endregion
    }
}