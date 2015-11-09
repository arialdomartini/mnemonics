using System;
using System.Collections.Generic;

namespace Mnemonics.Playstation
{
    public interface IGame
    {
        Dictionary<string, string> Play();

        void Start();
    }
}