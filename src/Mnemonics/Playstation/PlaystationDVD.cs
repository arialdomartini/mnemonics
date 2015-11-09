using System.Security.Policy;

namespace Mnemonics.Playstation
{
    public class PlaystationDVD
    {
        readonly IGame _game;

        public PlaystationDVD(IGame game)
        {
            _game = game;
        }

        public IGame Load()
        {
            var game = _game;
            game.Start();
            return game;
        }
    }
}
