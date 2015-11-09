namespace Mnemonics
{
    public class FrontPatioLight
    {
        public bool IsOn { get; private set; }

        public void TurnOn()
        {
            IsOn = true;
        }

        public void TurnOff()
        {
            IsOn = false;
        }
    }
}

