namespace Mnemonics.PlayingDVDs
{
    public class DVDPlayer
    {
        public DigitalStream Play(DVD dvd)
        {
            return new DigitalStream(dvd.GetVideo(), dvd.GetMusic(), dvd.GetDialogs());
        }
        
    }
}