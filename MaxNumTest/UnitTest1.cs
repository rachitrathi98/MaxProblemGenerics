using MaxNumberGenerics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MaxNumTest
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// TC 1.1: Tests for maximum number at first position.
        /// </summary>
        [TestMethod]
        public void TestForMaxNumAtOne()
        {
            int expected = 30;
            int actual = MaxNum.Max(30, 20, 10);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// TC 1.2: Tests for maximum number at second position.
        /// </summary>
        [TestMethod]
        public void TestForMaxNumAtTwo()
        {
            int expected = 30;
            int actual = MaxNum.Max(20, 30, 10);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// TC 1.3: Tests for maximum number int at third position.
        /// </summary>
        [TestMethod]
        public void TestForMaxNumIntAtThree()
        {
            int expected = 30;
            int actual = MaxNum.Max(10, 20, 30);
            Assert.AreEqual(expected, actual);
        }
    }
}
