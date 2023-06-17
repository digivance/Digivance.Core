using NUnit.Framework;

namespace Digivance.Core.Tests
{
    [TestFixture]
    public class StringExtensionTests
    {
        [Test]
        [TestCase("H3llo World", true)]
        [TestCase("Hello World", false)]
        [TestCase("123", true)]
        [TestCase("abc", false)]
        [TestCase("", false)]
        public void ContainsNumeric(string value, bool result)
        {
            Assert.That(value.ContainsNumeric(), Is.EqualTo(result));
        }

        [Test]
        [TestCase("H@I", true)]
        [TestCase("What if Long with 00 numbers, and stuff punctioations?", true)]
        [TestCase("H3llo World", false)]
        [TestCase("Hello World", false)]
        [TestCase("123", false)]
        [TestCase("abc", false)]
        [TestCase("", false)]
        public void ContainsSymbol(string value, bool result)
        {
            Assert.That(value.ContainsSymbol(), Is.EqualTo(result));
        }

        [Test]
        [TestCase("dmayor@digivance.com", true)]
        [TestCase("digivancepro@gmail.com", true)]
        [TestCase("B`~$_@ddr.nope@", false)] // It's crazy what characters are considered valid
        [TestCase("", false)]
        public void IsEmailAddress(string value, bool result)
        {
            Assert.That(value.IsEmailAddress(), Is.EqualTo(result));
        }

        [Test]
        [TestCase("Hello123", true)]
        [TestCase("HELLO", true)]
        [TestCase("123", false)]
        [TestCase("", false)]
        public void ContainsUpper(string value, bool result)
        {
            Assert.That(value.ContainsUpper(), Is.EqualTo(result));
        }

        [Test]
        [TestCase("Hello123", true)]
        [TestCase("hello", true)]
        [TestCase("123", false)]
        [TestCase("", false)]
        public void ContainsLower(string value, bool result)
        {
            Assert.That(value.ContainsLower(), Is.EqualTo(result));
        }
    }
}
