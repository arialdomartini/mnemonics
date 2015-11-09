using NUnit.Framework;
using FluentAssertions;

namespace Mnemonics.Test
{
    public class HomeIncidentTest
    {
        [Test]
        public void WhenMyGirlfriendTurnsTheFrontLightOnForVisitorsWeWereExpectingIShouldNotHaveAScrape()
        {
            var frontPatioLight = new FrontPatioLight();
            var garbageDisposal = new GarbageDisposal();
            var frontPatioLightSwitch = new FrontPatioLightSwitch(frontPatioLight, garbageDisposal);
            var myGirlFriend = new GirlFriend();

            myGirlFriend.TurnOnTheLightUsing(frontPatioLightSwitch);

            garbageDisposal.IsTheGrindRingRotating.Should().BeFalse();
        }
    }
}
