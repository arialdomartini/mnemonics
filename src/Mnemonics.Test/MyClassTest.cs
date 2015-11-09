using NUnit.Framework;
using FluentAssertions;

namespace Mnemonics.Test
{
    public class MyClassTest
    {
        [Test]
        public void ShouldPass()
        {
            new MyClass().Foo().Should().BeTrue();
        }
    }
}

