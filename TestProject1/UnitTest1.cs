using ConsoleApp1;

namespace TestProject1
{
    public class Tests
    {
        [TestFixture]
        public class NumberTest
        {
            private Number num;

            [SetUp]
            public void SetUp()
            {
                num = new Number();
            }

            [TearDown]
            public void TearDown()
            {
                num = null;
            }

            [Test]
            public void Tests()
            {
                Assert.AreEqual(7, num.DigitalRoot(16));
                Assert.AreEqual(6, num.DigitalRoot(456));
            }
        }
    }
}