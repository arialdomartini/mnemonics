using NUnit.Framework;
using FluentAssertions;
using NSubstitute;

namespace Mnemonics.Test
{

    public class MySelfTest
    {
        MySelf _sut;

        [SetUp]
        public void SetUp()
        {
            _sut = new MySelf();
        }

        [Test]
        public void FeedingMyselfShouldMakesMeFeelGood()
        {
            var result = _sut.FeedWith("Vitamin A");

            result.Should().Be("I feel good with Vitamin A");
        }

        [Test]
        public void NormallyImAlive()
        {
            _sut.IsAlive.Should().BeTrue();
        }


        [Test]
        public void FeedingMySelfDoesNotKillMe()
        {
            _sut.FeedWith("Vitamin B6");

            _sut.IsAlive.Should().BeTrue();
        }

        [Test]
        public void PoisonsMakeMeVomit()
        {
            var comment = _sut.Poison();

            comment.Should().Be("Bleah");
        }


        [Test]
        public void PoisonsKillMe()
        {
            _sut.Poison();

            _sut.IsAlive.Should().BeFalse();
        }
    }
}