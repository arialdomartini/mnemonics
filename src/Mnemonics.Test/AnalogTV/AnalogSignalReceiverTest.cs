using NUnit.Framework;
using FluentAssertions;
using Mnemonics.AnalogTV;

namespace Mnemonics.Test.AnalogTV
{
    public class AnalogSignalReceiverTest
    {
        [Test]
        public void AnalogicSignalReceiverShouldConvertAirSignals()
        {
            Air.AnalogSignal = "Some images|Some sound";
            var sut = new AnalogSignalReceiver();

            var result = sut.ReceiveSignalFromAir();

            result.Images.Should().Be("Some images");
            result.Sound.Should().Be("Some sound");
        }
    }
}

