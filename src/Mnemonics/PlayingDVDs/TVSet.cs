namespace Mnemonics.PlayingDVDs
{
    public class TVSet
    {
        public string Audio { get; private set; }
        public string Video { get; private set; }

        public void Play(DVD dvd)
        {
            var player = new DVDPlayer();
            var digitalStream = player.Play(dvd);
            Audio = new AudioMixer().Mix(digitalStream.Music, digitalStream.Dialogs);
            Video = digitalStream.Video;
        }
    }
}