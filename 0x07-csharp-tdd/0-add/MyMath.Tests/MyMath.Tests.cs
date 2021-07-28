using NUnit.Framework;

namespace MyMath.Tests
{
    [TestFixture]
    ///<summary>Test Class</summary>
    public class Tests
    {
        [Test]
        public void Test1()
        {
            int output = Operations.Add(6, 9);

            Assert.AreEqual(output, 15);
        }
    }
}