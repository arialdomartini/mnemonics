using System.Collections.Generic;

namespace Mnemonics
{
    public class Salad
    {
        public readonly List<IEdible> Ingredients;

        public Salad(List<IEdible> ingredients)
        {
            Ingredients = ingredients;
        }
    }

    public interface IEdible
    {
        string Feed(IHumanBeing myself);
    }

    public class Lettuce : IEdible
    {
        public string Feed(IHumanBeing myself)
        {
            return myself.FeedWith("Vitamin B6");
        }
    }
    public class Tomato : IEdible
    {
        public string Feed(IHumanBeing myself)
        {
            return myself.FeedWith("Vitamin C");
        }
    }

    public class Cruton : IEdible
    {
        public string Feed(IHumanBeing myself)
        {
            return myself.FeedWith("carbohydrates");
        }
    }

    public class Scallion : IEdible
    {
        public string Feed(IHumanBeing myself)
        {
            return myself.FeedWith("Vitamin A");
        }
    }

    public class Carrot : IEdible
    {
        public string Feed(IHumanBeing myself)
        {
            return myself.FeedWith("Vitamin A");
        }
    }

    public class Hemlock : IEdible
    {
        public string Feed(IHumanBeing myself)
        {
            return myself.Poison();
        }
    }
}