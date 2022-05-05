using FindMaximumNumber;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TC1()
        {
            FindMaximum max = new FindMaximum();
            int actual = max.FindMaxInteger(1, 2, 3);
            Assert.AreEqual(actual, 3);
        }

        [TestMethod]
        public void TC2()
        {
            FindMaximum max = new FindMaximum();
            int actual = max.FindMaxInteger(3, 1, 2);
            Assert.AreEqual(actual, 3);
        }

        [TestMethod]
        public void TC3()
        {
            FindMaximum max = new FindMaximum();
            int actual = max.FindMaxInteger(1, 3, 2);
            Assert.AreEqual(actual, 3);
        }


    }
}