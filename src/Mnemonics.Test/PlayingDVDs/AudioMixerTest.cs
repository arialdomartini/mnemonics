using NUnit.Framework;
using FluentAssertions;
using Mnemonics.PlayingDVDs;

namespace Mnemonics.Test.PlayingDVDs
{
    public class AudioMixerTest
    {
        [Test]
        public void ShouldMix2Tracks()
        {
            var sut = new AudioMixer();

            var result = sut.Mix("track1", "track2");

            result.Should().Be("track1 + track2");
        }
    }
}