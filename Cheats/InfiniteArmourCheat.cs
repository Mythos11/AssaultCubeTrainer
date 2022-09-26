using AssultCube_Trainer.Core;
using Memory;

namespace AssultCube_Trainer.Cheats
{
    public class InfiniteArmourCheat : Cheat
    {
        public bool isCheatToggled;
        public bool stopCheat;
        private Mem memory = Form1.memory;

        private int previousValue;
        
        public override void Start(bool procIsRunning)
        {
            ToggleCheat();
        }

        public override void ToggleCheat()
        {
            // Checks the value of isCheatToggled
            switch (isCheatToggled)
            {
                case true:
                    /*
                       * Writes memory     
                       * First parameter takes the pointer and the offset (base is just the module name)
                       * Second parameter takes a type (int, string, byte[], etc)
                       * Third parameter takes the value that will overwrite the current value held in the address   
                    */
                    previousValue = memory.ReadInt("base+00187C0C");
                    memory.WriteMemory("base+00187C0C, F0", "int", "9999");
                    break;
                case false:
                    StopCheat();
                    break;
            }
        }

        public override void StopCheat()
        {
            // Check if stopCheat == true
            if (stopCheat)
            {
                // Sets the Ammo back to default
                memory.WriteMemory("base+00187C0C, F0", "int", previousValue.ToString());

                // this prevents it from constantly running
                stopCheat = false;
            }
        }
    }
}