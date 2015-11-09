using System;
using System.Collections.Generic;

namespace Mnemonics.Playstation
{
    public class Playstation4
    {
        public Dictionary<string, string> Play(PlaystationDVD dvd)
        {
            var game = dvd.Load();
            return game.Play();
        }
    }
}

