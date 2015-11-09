using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Mnemonics.Playstation
{

    public class Pacman : IGame
    {
        public void Start()
        {
        }

        public Dictionary<string, string> Play()
        {
            var gamesession = new Dictionary<string, string>();
            gamesession.Add("sounds", "tweeda tweeda tweeda tweeda tweeda");
            gamesession.Add("images", "scheme 1 + scheme 2 + scheme 3 + game over");
            return gamesession;
        }
    }
}
