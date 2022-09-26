namespace AssultCube_Trainer.Cheats
{
    public abstract class Cheat
    {
        private bool isCheatToggled;
        private bool stopCheat;
        private int previousValue;

        public abstract void Start(bool procIsRunning);

        public abstract void ToggleCheat();
        
        public abstract void StopCheat();

    }
}