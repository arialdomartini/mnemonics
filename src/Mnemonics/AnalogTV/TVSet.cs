namespace Mnemonics.AnalogTV
{
    public class TVSet
    {
        public string Video { get; private set;}
        public string Audio { get; private set;}

        public void Play()
        { 
            var analogicSignalReceiver = new AnalogSignalReceiver();
            var signal = analogicSignalReceiver.ReceiveSignalFromAir();
            Video = signal.Images;
            Audio = signal.Sound;
        }
    }
}