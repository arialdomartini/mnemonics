using NUnit.Framework;
using FluentAssertions;
using Mnemonics.PlayingDVDs;

namespace Mnemonics.Test.PlayingDVDs
{
    public class TVSetTest
    {
        [Test]
        public void ShouldPlayADVD()
        {
            var dvd = new DVD("Images of Forrest Gump", "Forrest Gump's Soundtrack", "Dialogs");
            var sut = new TVSet();

            sut.Play(dvd);

            sut.Video.Should().Be("Images of Forrest Gump");
            sut.Audio.Should().Be("Forrest Gump's Soundtrack + Dialogs");
        }
    }
}