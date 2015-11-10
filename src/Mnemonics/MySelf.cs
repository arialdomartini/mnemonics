using System.Collections.Generic;

namespace Mnemonics
{
    public class MySelf : IHumanBeing
    {
        public bool IsAlive { get; private set; }

        public MySelf()
        {
            IsAlive = true;
        }

        public string Poison()
        {
            IsAlive = false;
            return "Bleah";
        }

        public string FeedWith(string vitamin)
        {
            return string.Format("I feel good with {0}", vitamin);
        }

        public string Eat(Salad salad)
        {
            var myself = this;
            var comments = new List<string>();

            foreach(var ingredient in salad.Ingredients)
            {
                if(ingredient.GetType() != typeof(Hemlock))
                    comments.Add(ingredient.Feed(myself));
            }

            return string.Join("\n", comments);
        }
    }
}