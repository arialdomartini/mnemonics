using NUnit.Framework;
using FluentAssertions;
using System.Collections.Generic;
using NSubstitute;

namespace Mnemonics.Test
{
    public class LiskovSostitutionPrincipleTest
    {
        [Test]
        public void EatingASaladWith2IngredientsIShouldReceiveAllTheVitamins()
        {
            var sut = new MySelf();

            var ingredientX = Substitute.For<IEdible>();
            ingredientX.Feed(sut).Returns("I like X");

            var ingredientY = Substitute.For<IEdible>();
            ingredientY.Feed(sut).Returns("I like Y");
            

            var salad = new Salad(new List<IEdible> { ingredientX, ingredientY });

            var result = sut.Eat(salad);

            result.Should().Be("I like X\nI like Y");

        }

        [Test]
        public void EatingSaladShouldNotKillMe()
        {
            var ingredients = new List<IEdible> {
                new Carrot(),
                new Carrot(),
                new Lettuce(),
                new Tomato(),
                new Scallion(),
                new Hemlock(),
                new Scallion(),
                new Cruton(),
                new Lettuce()
            };
            var salad = new Salad(ingredients);
            var sut = new MySelf();
                
            sut.Eat(salad);

            sut.IsAlive.Should().BeTrue();
        }
    }
}