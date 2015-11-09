namespace Mnemonics
{
    public class GarbageDisposal
    {
        public bool IsTheGrindRingRotating { get; private set; }

        public GarbageDisposal()
        {
            IsTheGrindRingRotating = false;
        }

        public void TurnOn()
        {
            IsTheGrindRingRotating = true;
        }

        public void TurnOff()
        {
            IsTheGrindRingRotating = false;
        }
    }
}
