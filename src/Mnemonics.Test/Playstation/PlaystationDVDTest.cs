using NUnit.Framework;
using FluentAssertions;
using Mnemonics.Playstation;
using NSubstitute;

namespace Mnemonics.Test.Playstation
{
    public class PlaystationDVDTest
    {
        [Test]
        public void ShouldPlayAGame()
        {
            var game = Substitute.For<IGame>();
            var sut = new PlaystationDVD(game);

            var result = sut.Load();

            game.Received().Start();
            result.Should().Be(game);
        }
    }
}