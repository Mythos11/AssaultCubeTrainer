using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using AssultCube_Trainer.Cheats;
using Memory;

namespace AssultCube_Trainer.Core
{
    public partial class Form1 : Form
    {
        private InfiniteHealthCheat healthCheat = new InfiniteHealthCheat();
        private InfinitePrimaryAmmo riffileAmmoCheat = new InfinitePrimaryAmmo();
        private InfinitePistolAmmo pistolAmmoCheat = new InfinitePistolAmmo();
        private InfinteGranadeCheat granadeCheat = new InfinteGranadeCheat();
        private InfiniteArmourCheat armourCheat = new InfiniteArmourCheat();

        public static Mem memory = new Mem();
        string procName = "ac_client.exe";
        
        private bool procIsOpen;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void lookingForProcess_DoWork(object sender, DoWorkEventArgs e)
        {
            // Infinite Loop
            while (true)
            {
                // If the game is not open then stop the thread for 1000ms
                if (!(memory.OpenProcess(procName)))
                {
                    // Prevents using too much cpu being used
                    Thread.Sleep(1000);
                    continue;
                }

                // If the game is open 
                procIsOpen = true;
                
                // Calls the start methods of all the cheats
                healthCheat.Start(procIsOpen);
                riffileAmmoCheat.Start(procIsOpen);
                pistolAmmoCheat.Start(procIsOpen);
                granadeCheat.Start(procIsOpen);
                armourCheat.Start(procIsOpen);

                // Prevents using too much cpu being used
                Thread.Sleep(1000);

                // Reports the progress of the task
                lookingForProcess.ReportProgress(0);
            }
        }
    

        private void Form1_Shown(object sender, EventArgs e)
        {
            // When the form is open it starts the lookingForProcess.DoWork() method 
            lookingForProcess.RunWorkerAsync();
        }

        private void lookingForProcess_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            // When the game is found running
            if (procIsOpen)
            {
                // Changes the text of the processNameLabel in form app
                const string name = "AssaultCube";
                processNameLabel.Text = name;
                processNameLabel.ForeColor = Color.Green;
            }
            else if (!procIsOpen)
            {
                // Changes the text of the processNameLabel in form app when the game is closed
                const string name = "N/A";
                processNameLabel.Text = name;
                processNameLabel.ForeColor = Color.Red;
            }
          
        }

        private void lookingForProcess_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // Once the process is done run it again
            lookingForProcess.RunWorkerAsync();
        }
        
        private void healthHackButton_Click(object sender, EventArgs e)
        {
            // Sets isCheatToggled to whatever it isn't set to (E.g. True to False OR False to True)
            healthCheat.isCheatToggled = !healthCheat.isCheatToggled;
           
            // Checks if isCheatToggled is false
            if (healthCheat.isCheatToggled == false)
            {
                // Sets stopCheat to true (starts the StopCheat method)
                healthCheat.stopCheat = true;
            }
        }

        private void riffleAmmoHackButton_Click(object sender, EventArgs e)
        {
            // Sets isCheatToggled to whatever it isn't set to (E.g. True to False OR False to True)
            riffileAmmoCheat.isCheatToggled = !riffileAmmoCheat.isCheatToggled;

            // Checks if isCheatToggled is false
            if (riffileAmmoCheat.isCheatToggled == false)
            {
                // Sets stopCheat to true (starts the StopCheat method)
                riffileAmmoCheat.stopCheat = true;
            }
        }

        private void pistolAmmoCheatButton_Click(object sender, EventArgs e)
        {
            // Sets isCheatToggled to whatever it isn't set to (E.g. True to False OR False to True)
            pistolAmmoCheat.isCheatToggled = !pistolAmmoCheat.isCheatToggled;

            // Checks if isCheatToggled is false
            if (pistolAmmoCheat.isCheatToggled == false)
            {
                // Sets stopCheat to true (starts the StopCheat method)
                pistolAmmoCheat.stopCheat = true;
            }
        }

        private void infiniteGranadeButton_Click(object sender, EventArgs e)
        {
            // Sets isCheatToggled to whatever it isn't set to (E.g. True to False OR False to True)
            granadeCheat.isCheatToggled = !granadeCheat.isCheatToggled;

            // Checks if isCheatToggled is false
            if (granadeCheat.isCheatToggled == false)
            {
                // Sets stopCheat to true (starts the StopCheat method)
                granadeCheat.stopCheat = true;
            }
        }

        private void infiniteArmourButton_Click(object sender, EventArgs e)
        {
            // Sets isCheatToggled to whatever it isn't set to (E.g. True to False OR False to True)
            armourCheat.isCheatToggled = !armourCheat.isCheatToggled;

            // Checks if isCheatToggled is false
            if (armourCheat.isCheatToggled == false)
            {
                // Sets stopCheat to true (starts the StopCheat method)
                armourCheat.stopCheat = true;
            }
        }
    }
}