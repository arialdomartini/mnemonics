using NUnit.Framework;
using FluentAssertions;

namespace Mnemonics.Test
{
    public class FrontPatioLightSwitchTest
    {
        FrontPatioLight _frontPatioLight;
        GarbageDisposal _garbageDisposal;
        FrontPatioLightSwitch _sut;

        [SetUp]
        public void SetUp()
        {
            _frontPatioLight = new FrontPatioLight();
            _garbageDisposal = new GarbageDisposal();

            _sut = new FrontPatioLightSwitch(_frontPatioLight, _garbageDisposal);
        }

        [Test]
        public void SwitchingOnTheSwitchShouldTurnOnTheFrontPatioLight()
        {
            _sut.SwitchOn();

            _frontPatioLight.IsOn.Should().BeTrue();
        }

        [Test]
        public void SwitchingOffTheSwitchShouldTurnOffTheFrontPatioLight()
        {
            _sut.SwitchOff();

            _frontPatioLight.IsOn.Should().BeFalse();
        }

        [Test]
        public void SwitchingOnTheSwitchShouldTurnOnTheGarbageDisposal()
        {
            _sut.SwitchOn();

            _garbageDisposal.IsTheGrindRingRotating.Should().BeTrue();
        }

        [Test]
        public void SwitchingOffTheSwitchShouldTurnOffTheGarbageDisposal()
        {
            _sut.SwitchOff();

            _garbageDisposal.IsTheGrindRingRotating.Should().BeFalse();
        }
    }
}