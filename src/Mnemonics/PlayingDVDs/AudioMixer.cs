namespace Mnemonics.PlayingDVDs
{
	public class AudioMixer
	{
        public string Mix(string track1, string track2)
        {
            return string.Format("{0} + {1}", track1, track2);
        }
	}

}