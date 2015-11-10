The Law of Demeter
==================

[Italian translation](README-italian.md)

Exercise based on the amazing [Visualization Mnemonics for Software Principles](http://www.daedtech.com/visualization-mnemonics-for-software-principles) post by [Erik Dietrich](https://twitter.com/daedtech)

Last week I was on a driving trip and I stopped by a gas station to get myself a Mountain Dew for the sake or road alertness. I grabbed the soda from the cooler and plopped it down on the counter, prompting the clerk to say, “that’ll be $1.95.” At this point, naturally, I removed my pants and the guy started screaming at me about police and indecent exposure. Confused, I said, “look, I’m just trying to pay you — I’ll hand you my pants and you go rummaging around in my pockets until you find my wallet, which you’ll take out and go looking through for cash. If I’m due change put it back into the wallet, unless it’s a coin, and then just put it in my pocket, and give me back the pants.” He pulled a shotgun out from behind the counter and told me that in his store, people obey the Law of Demeter or else.

So what does the Law of Demeter say? Well, anecdotally, it says “give collaborators exactly what they’re asking for and don’t give them something they’ll have to go picking through to get what they want.” There’s a reason we don’t hand the clerk our pants (or even our wallet) at the store and just hand them money instead; it’s inappropriate to send them hunting for the money. The Law of Demeter encourages you to think this way about your code. Don’t return Pants and force clients of your method to get what they want by invoking Pants.Pockets[1].Wallet.Money — just give them a Money. And, if you’re the clerk, don’t accept someone handing you a Pants and you going to look for the money — demand the money or show them your shotgun.


# Challenge

Can you refactor the sample code and make it follow the Law of Demeter?
