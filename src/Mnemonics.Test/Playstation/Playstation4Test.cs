using NUnit.Framework;
using FluentAssertions;
using Mnemonics.Playstation;
using NSubstitute;
using System.Collections.Generic;

namespace Mnemonics.Test.Playstation
{
    public class Playstation4Test
    {
        [Test]
        public void ShouldPlayAGameOnDVD()
        {
            var game = Substitute.For<IGame>();
            game.Play().Returns(new Dictionary<string, string>{ 
                {"sounds", "tadaa"}, 
                {"images", "scheme 1"}
            });
            var dvd = new PlaystationDVD(game);
            var sut = new Playstation4();

            var result = sut.Play(dvd);

            result["sounds"].Should().Be("tadaa");
            result["images"].Should().Be("scheme 1");
        }
    }
}