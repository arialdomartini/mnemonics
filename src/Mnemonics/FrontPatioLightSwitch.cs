namespace Mnemonics
{
    public class FrontPatioLightSwitch
    {
        readonly FrontPatioLight _frontPatioLight;
        readonly GarbageDisposal _garbageDisposal;

        public FrontPatioLightSwitch(FrontPatioLight frontPatioLight, GarbageDisposal garbageDisposal)
        {
            _garbageDisposal = garbageDisposal;
            _frontPatioLight = frontPatioLight;
        }

        public void SwitchOn()
        {
            _frontPatioLight.TurnOn();
            _garbageDisposal.TurnOn();
        }

        public void SwitchOff()
        {
            _frontPatioLight.TurnOff();
            _garbageDisposal.TurnOff();
        }
    }
}
