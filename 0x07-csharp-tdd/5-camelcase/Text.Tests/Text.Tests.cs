using NUnit.Framework;

namespace Text.Tests
{
    [TestFixture]
    ///<summary>Tests class</summary>
    public class Tests
    {
        [Test]
        public void Test1()
        {
            string camelString = "bigBadDog";
            int output = Str.CamelCase(camelString);

            Assert.AreEqual(3, output);
        }

        [Test]
        public void TestEmpty()
        {
            string camelString = "";
            int output = Str.CamelCase(camelString);

            Assert.AreEqual(0, output);
        }

        [Test]
        public void TestMultCaps()
        {
            string myString = "qWERty";
            int output = Str.CamelCase(myString);

            Assert.AreEqual(4, output);
        }
    }
}