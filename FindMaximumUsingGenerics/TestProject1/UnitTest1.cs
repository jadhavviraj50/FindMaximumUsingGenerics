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

        [TestMethod]
        public void TC4()
        {
            FindMaximum max = new FindMaximum();
            float actual = max.FindMaxFloat(1.2f, 3.6f, 6.7f);
            Assert.AreEqual(actual, 6.7f);
        }
        [TestMethod]
        public void TC5()
        {
            FindMaximum max = new FindMaximum();
            float actual = max.FindMaxFloat(6.7f, 1.2f, 3.6f);
            Assert.AreEqual(actual, 6.7f);
        }
        [TestMethod]
        public void TC6()
        {
            FindMaximum max = new FindMaximum();
            float actual = max.FindMaxFloat(1.2f, 6.7f, 3.6f);
            Assert.AreEqual(actual, 6.7f);
        }
        [TestMethod]
        public void TC7()
        {
            FindMaximum max = new FindMaximum();
            string actual = max.FindMaxString("Apple", "Peach", "Banana");
            Assert.AreEqual(actual, "Banana");
        }
        [TestMethod]
        public void TC8()
        {
            FindMaximum max = new FindMaximum();
            string actual = max.FindMaxString("Banana", "Apple", "Peach");
            Assert.AreEqual(actual, "Banana");
        }
        [TestMethod]
        public void TC9()
        {
            FindMaximum max = new FindMaximum();
            string actual = max.FindMaxString("Apple", "Banana", "Peach");
            Assert.AreEqual(actual, "Banana");
        }

    }
}