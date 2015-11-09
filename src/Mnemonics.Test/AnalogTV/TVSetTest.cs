using NUnit.Framework;
using FluentAssertions;
using Mnemonics.AnalogTV;

namespace Mnemonics.Test.AnalogTV
{
    public class TVSetTest
    {
        [Test]
        public void AnalogicTVShouldLetMeEnjoyTheDavidLettermanShow()
        {
            Air.AnalogSignal = "The face of David Letterman|The voice of David Letterman";
            var sut = new TVSet();

            sut.Play();

            sut.Video.Should().Be("The face of David Letterman");
            sut.Audio.Should().Be("The voice of David Letterman");
        }
    }
}
