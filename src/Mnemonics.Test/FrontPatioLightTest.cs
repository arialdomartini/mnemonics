using NUnit.Framework;
using FluentAssertions;

namespace Mnemonics.Test
{
    public class FrontPatioLightTest
    {
        FrontPatioLight _sut;

        [SetUp]
        public void SetUp()
        {
            _sut = new FrontPatioLight();
        }

        [Test]
        public void TurningOnTheFrontPatioLight()
        {
            _sut.TurnOn();

            _sut.IsOn.Should().BeTrue();
        }

        [Test]
        public void TurningOffTheGarbageDisposalMakeTheGrinfRingReturnStill()
        {
            _sut.TurnOn();
            _sut.TurnOff();

            _sut.IsOn.Should().BeFalse();
        }
    }
}
