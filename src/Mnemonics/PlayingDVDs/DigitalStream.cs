namespace Mnemonics.PlayingDVDs
{
    public class DigitalStream
    {
        public string Video { get; private set; }
        public string Music { get; private set; }
        public string Dialogs { get; private set; }

        public DigitalStream(string video, string music, string dialog)
        {
            Dialogs = dialog;
            Music = music;
            Video = video;
        }
	}
}