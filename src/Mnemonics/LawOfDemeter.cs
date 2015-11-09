using System.Collections.Generic;
using System.Linq;

namespace Mnemonics
{
    public class MountainDew
    {
        public decimal Price { get; }

        public MountainDew(decimal price)
        {
            Price = price;
        }
    }

    public class Clerk
    {
        public Pants Pay(MountainDew mountainDew, Pants pants)
        {
            var twoDollars = pants.Pocket.Wallet.Banknotes.First(b => b.Amount == 2);
            pants.Pocket.Wallet.Banknotes.Remove(twoDollars);

            pants.Pocket.Coins.Add(new Coin(0.05m));

            return pants;
        }
    }
        
    public class Pants
    {
        public Pocket Pocket { get; set; }
    }

    public class Pocket
    {
        public Wallet Wallet { get; set; }
        public List<Coin> Coins { get; set; }
    }


    public class Wallet
    {
        public List<Banknote> Banknotes { get; set; }
    }

    public interface IMoney
    {
        decimal Amount { get; }
    }

    public class Banknote : IMoney
    {
        public decimal Amount { get;}

        public Banknote(decimal amount)
        {
            Amount = amount;
        }

        public override bool Equals(object obj)
        {
            return (obj as Banknote).Amount == Amount;
        }
    }

    public class Cash
    {
        public List<Coin> Coins {get; set;}
    }

    public class Coin : IMoney
    {
        public decimal Amount { get; }

        public Coin(decimal amount)
        {
            Amount = amount;
        }

        public override bool Equals(object obj)
        {
            return (obj as Coin).Amount == Amount;
        }
    }
}

