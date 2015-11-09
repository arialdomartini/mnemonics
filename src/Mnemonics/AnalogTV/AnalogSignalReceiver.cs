namespace Mnemonics.AnalogTV
{
    public class AnalogSignalReceiver
    {
        public ImagesAndSound ReceiveSignalFromAir()
        {
            var signal = Air.AnalogSignal;
            var elements = signal.Split('|');

            return new ImagesAndSound(images: elements[0], sound: elements[1]);
        }
    }
}