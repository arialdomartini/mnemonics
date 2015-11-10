using NUnit.Framework;
using FluentAssertions;
using NSubstitute;

namespace Mnemonics.Test
{

    public class EdiblesTest
    {
        [Test]
        public void LettuceShouldProvideMeWithVitaminB6()
        {
            var sut = new Lettuce();
            var mySelf = Substitute.For<IHumanBeing>();

            sut.Feed(mySelf);

            mySelf.Received().FeedWith("Vitamin B6");
        }

        [Test]
        public void TomatoShouldProvideMeWithVitaminC()
        {
            var sut = new Tomato();
            var mySelf = Substitute.For<IHumanBeing>();

            sut.Feed(mySelf);

            mySelf.Received().FeedWith("Vitamin C");
        }

        [Test]
        public void CrutonShouldProvideMeWithCarbohydrates()
        {
            var sut = new Cruton();
            var mySelf = Substitute.For<IHumanBeing>();

            sut.Feed(mySelf);

            mySelf.Received().FeedWith("carbohydrates");
        }
            
        [Test]
        public void ScallionShouldProvideMeWithVitaminA()
        {
            var sut = new Scallion();
            var mySelf = Substitute.For<IHumanBeing>();

            sut.Feed(mySelf);

            mySelf.Received().FeedWith("Vitamin A");
        }

        [Test]
        public void CarrotShouldProvideMeWithVitaminA()
        {
            var sut = new Carrot();
            var mySelf = Substitute.For<IHumanBeing>();

            sut.Feed(mySelf);

            mySelf.Received().FeedWith("Vitamin A");
        }

        [Test]
        public void HemlokKillsMe()
        {
            var sut = new Hemlock();
            var mySelf = Substitute.For<IHumanBeing>();

            sut.Feed(mySelf);

            mySelf.Received().Poison();
        }
    }
}