using NUnit.Framework;
using FluentAssertions;
using Mnemonics.Playstation;

namespace Mnemonics.Test.Playstation
{
    public class PacmanTest
    {
        [Test]
        public void ShouldPlayPacman()
        {
            var sut = new Pacman();

            var gamesession = sut.Play();

            gamesession["sounds"].Should().Be("tweeda tweeda tweeda tweeda tweeda");
            gamesession["images"].Should().Be("scheme 1 + scheme 2 + scheme 3 + game over");
        }
    }
}