using NUnit.Framework;
using FluentAssertions;

namespace Mnemonics.Test
{
    public class GarbageDisposalTest
    {
        GarbageDisposal _sut;

        [SetUp]
        public void SetUp()
        {
            _sut = new GarbageDisposal();
        }

        [Test]
        public void TheGarbageDisposalStartsWithTheGridRingStill()
        {
            _sut.IsTheGrindRingRotating.Should().BeFalse();
        }

        [Test]
        public void TurningOnTheGarbageDisposalMakeTheGrinfRingRotate()
        {
            _sut.TurnOn();

            _sut.IsTheGrindRingRotating.Should().BeTrue();
        }

        [Test]
        public void TurningOffTheGarbageDisposalMakeTheGrinfRingReturnStill()
        {
            _sut.TurnOn();
            _sut.TurnOff();

            _sut.IsTheGrindRingRotating.Should().BeFalse();
        }
    }
}

