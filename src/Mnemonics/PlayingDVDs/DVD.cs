namespace Mnemonics.PlayingDVDs
{
    public class DVD
    {
        readonly string _video;
        readonly string _music;
        readonly string _dialogs;

        public DVD(string video, string music, string dialogs)
        {
            _dialogs = dialogs;
            _music = music;
            _video = video;
        }

        public string GetVideo()
        {
            return _video;
        }

        public string GetMusic()
        {
            return _music;
        }

        public string GetDialogs()
        {
            return _dialogs;
        }
    }
}