using NUnit.Framework;
using FluentAssertions;
using System.Collections.Generic;

namespace Mnemonics.Test
{
    public class LawOfDemeterTest
    {
        [Test]
        public void IShouldBeAbleToBuyAMountainDewAndGetAChange()
        {
            // Given
            var product = new MountainDew(1.95m);
            var clerk = new Clerk();

            var pants = new Pants();
            pants.Pocket = new Pocket();

            pants.Pocket.Wallet = new Wallet();;
            pants.Pocket.Wallet.Banknotes = new List<Banknote> { new Banknote(1), new Banknote(2), new Banknote(5) };
            pants.Pocket.Coins = new List<Coin>(); 

            // When
            pants = clerk.Pay(product, pants);

            // Then
            pants.Pocket.Wallet.Banknotes.Should().NotContain(new Banknote(2));
            pants.Pocket.Coins.Should().Contain(new Coin(0.05m));
        }
    }
}

