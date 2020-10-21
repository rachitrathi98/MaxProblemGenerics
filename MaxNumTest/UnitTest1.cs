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
            int expected = 50;
            int[] arr = { 10, 20, 30, 40, 50 };
            MaxNum<int>.Max(arr);
            int actual = MaxNum<int>.maximum;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// TC 1.2: Tests for maximum number at second position.
        /// </summary>
        [TestMethod]
        public void TestForMaxNumAtTwo()
        {
            int expected = 50;
            int[] arr = { 10, 20, 30, 40, 50 };
            MaxNum<int>.Max(arr);
            int actual = MaxNum<int>.maximum;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// TC 1.3: Tests for maximum number int at third position.
        /// </summary>
        [TestMethod]
        public void TestForMaxNumIntAtThree()
        {
            int expected = 50;
            int[] arr = { 10, 20, 30, 40, 50 };
            MaxNum<int>.Max(arr);
            int actual = MaxNum<int>.maximum;
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// TC 2.1: Tests for maximum number at first position.
        /// </summary>
        [TestMethod]
        public void TestForMaxNumAtOne_1()
        {
            double expected = 50.5;
            double[] arr2 = { 10.5, 20.5, 30.5, 40.5, 50.5 };
            MaxNum<double>.Max(arr2);
            double actual = MaxNum<double>.maximum;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// TC 2.2: Tests for maximum number at second position.
        /// </summary>
        [TestMethod]
        public void TestForMaxNumAtTwo_2()
        {
            double expected = 50.5;
            double[] arr2 = { 10.5, 20.5, 30.5, 40.5, 50.5 };
            MaxNum<double>.Max(arr2);
            double actual = MaxNum<double>.maximum;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// TC 2.3: Tests for maximum number int at third position.
        /// </summary>
        [TestMethod]
        public void TestForMaxNumIntAtThree_3()
        {
            double expected = 50.5;
            double[] arr2 = { 10.5, 20.5, 30.5, 40.5, 50.5 };
            MaxNum<double>.Max(arr2);
            double actual = MaxNum<double>.maximum;
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// TC 3.1: Tests for maximum number at first position.
        /// </summary>
        [TestMethod]
        public void TestForMaxStringAtOne()
        {
            string expected = "Rathi";
            string[] arr3 = { "My", "name", "is", "Rachit", "Rathi" };
            MaxNum<string>.Max(arr3);
            string actual = MaxNum<string>.maximum;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// TC 3.2: Tests for maximum number at second position.
        /// </summary>
        [TestMethod]
        public void TestForMaxStringAtTwo()
        {
            string expected = "Rathi";
            string[] arr3 = { "My", "is", "name", "Rachit", "Rathi" };
            MaxNum<string>.Max(arr3);
            string actual = MaxNum<string>.maximum;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// TC 3.3: Tests for maximum number int at third position.
        /// </summary>
        [TestMethod]
        public void TestForMaxStringAtThree()
        {
            string expected = "Rathi";
            string[] arr3 = { "Rachit", "Rathi", "is", "My", "name" };
            MaxNum<string>.Max(arr3);
            string actual = MaxNum<string>.maximum;
            Assert.AreEqual(expected, actual);
        }


    }
}
