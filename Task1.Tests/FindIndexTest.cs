using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task1;

namespace Task1.Tests
{
    [TestClass]
    public class FindIndexText
    {
        /// <summary>
        /// A test for Find() with valid array
        /// </summary>
        [TestMethod]
        public void Find_ArrayOfInt_Index()
        {
            //arrange
            int[] array = { 1, 2, 3, 4, 3, 2, 1 };
            int expected = 3;
            //act
            int actual = FindIndex.Find(array);
            //assert
            Assert.AreEqual(expected,actual);
        }

        /// <summary>
        /// A test for Find() with not valid array
        /// </summary>
        [TestMethod]
        public void Find_ArrayOfInt_MinusOne()
        {
            //arrange
            int[] array = { 1, 2, 3, 4 };
            int expected = -1;
            //act
            int actual = FindIndex.Find(array);
            //assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// A test for Find() with array is null
        /// </summary>
        [TestMethod]
        public void Find_EmptyArray_MinusOne()
        {
            //arrange
            int[] array = null;
            int expected = -1;
            //act
            int actual = FindIndex.Find(array);
            //assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// A test for Find() with array where length is less than tree
        /// </summary>
        [TestMethod]
        public void Find_ArrayLengthIsLessThanThree_MinusOne()
        {
            //arrange
            int[] array = { 1, 2 };
            int expected = -1;
            //act
            int actual = FindIndex.Find(array);
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
