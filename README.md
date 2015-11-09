Open/Closed Principle
=====================

Exercise based on the amazing [Visualization Mnemonics for Software Principles](http://www.daedtech.com/visualization-mnemonics-for-software-principles) post by [Erik Dietrich](https://twitter.com/daedtech)

I don’t have a ton of time for TV these days, and that’s mainly because TV is so time consuming. It was a lot simpler when I just had a TV that got an analog signal over the air. But then, things went digital, so I had to take apart my TV and rewire it to handle digital signals. Next, we got cable and, of course, there I am, disassembling the TV again so that we can wire it up to get a cable signal. The worst part of that was that when I became furious with the cable provider and we switched to Dish, I was right back to work on the TV. Now, we have a Nintendo Wii, a DVD player, and a Roku, but who has the time to take the television apart and rewire it to handle each of these additional items? And if that weren’t bad enough, I tried hooking up an old school Sega Genesis last year, and my Dish stopped working.

… said no one, ever. And the reason no one has ever said this is that televisions that you purchase follow the Open/Closed Principle, which basically says that you should create components that are closed to modification, but open for extension. Televisions you purchased aren’t made to be disassembled by you, and certainly no one expects you to hack into the guts of the TV just to plug some device into it. That’s what the Coax/RCA/Component/HDMI/etc feeds are for. With the inputs and the sealed-under-warranty case, your television is open for extension, but closed for modification. You can extend its functionality by plugging anything you like into it, including things not even out yet, like an X-Box 12 or something. Follow this same concept for flexible code. When you write code, you strive to maximize flexibility by facilitating maintenance via extension and new code. If you program to interfaces or allow overriding of behavior via inheritance, life is a lot easier when it comes time to change functionality. So favor that over writing some juggernaut class that you have to go in and modify literally every sprint. That’s icky, and you’ll learn to hate that class and the design around it the same way you’d hate the television I just described.


# Challenge

There are 2 different implementations of `TVSet`: one that is capable of displaying analog signals transmitted through the air and one that can be used with DVD Player. Both of them violate the Open/Closed Principle.

* Would you be able to merge the 2 implementations into one single, more flexible and adhering to the Open/Closed Principle?

* Demonstrate that the new implementation is Open for Extension and Closed for Modifications: show that you can use it with a PlayStation, without modifying its implementation.
