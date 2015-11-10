Liskov Substitution Principle
============================

[Italian translation](README-italian.md)

Exercise based on the amazing [Visualization Mnemonics for Software Principles](http://www.daedtech.com/visualization-mnemonics-for-software-principles) post by [Erik Dietrich](https://twitter.com/daedtech)

I’m someone that usually eats a pretty unremarkable salad with dinner. You know, standard stuff: lettuce, tomatoes, crutons, scallions, carrots, and hemlock. One thing that I seem to do differently than most, however, is that I examine each individual item in the salad to see whether or not it will kill me before I put it into my mouth (a lot of other salad consumers seem to play pretty fast and loose with their lives, sheesh). I have a pretty simple algorithm for this. If the item is not hemlock, I eat it. If it is hemlock, I put it onto my plate to throw out later. I highly recommend eating your hemlock salad this way.

Or, you could bear in mind the Liskov Substitution Principle, which basically says that if you’re going to have an inheritance relationship, then derived types should be seamlessly swappable for their base type. So, if I have a salad full of Edibles, I shouldn’t have some derived type, Hemlock, that doesn’t behave the way other Edibles do. Another way to think of this is that if you have a heterogeneous collection of things in an inheritance hierarchy, you shouldn’t go through them one by one and say, “let’s see which type this is and treat it specially.” So, obey the LSP and don’t make hemlock salads for people. You’ll have cleaner code and avoid jail.


# Challenge

The fact that `Hemlock` is not smealessly swappable with other `IEdible` ingredients is apparent in the `Eat(Salad salad)` method:

```csharp
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

```

See that `if` statement? Can you get rid of it and make it useless, adhering to the Liskov Substitution Principle?

A good reference for fixing this issue is the [dasblinkenlight](http://programmers.stackexchange.com/users/44705/dasblinkenlight)'s reply to the Programmers Stackexchange question [Is this a violation of the Liskov Substitution Principle?](https://programmers.stackexchange.com/questions/170138/is-this-a-violation-of-the-liskov-substitution-principle/170142#170142)
