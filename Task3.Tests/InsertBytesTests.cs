using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task3;

namespace Task3.Tests
{
    [TestClass]
    public class InsertBytesTests
    {
        /// <summary>
        /// A test for Insert() with valid parameters.
        /// </summary>
        [TestMethod]
        public void Insert_ValidParameters_True()
        {
            //arrange
            int a = 15;
            int b = -15;
            int firstInd = 0;
            int secondInd = 4;
            bool expected = true;
            int expectedNumber = 31;
            //act
            bool actual = InsertBytes.Insert(ref a,b,firstInd,secondInd);
            //assert
            Assert.AreEqual(expected,actual);
            Assert.AreEqual(expectedNumber,a);
        }

        /// <summary>
        /// A test for Insert() where firstIndex>secondIndex.
        /// </summary>
        [TestMethod]
        public void Insert_NotValidIndex_False()
        {
            //arrange
            int a = 15;
            int b = -15;
            int firstInd = 4;
            int secondInd = 0;
            bool expected = false;
            //act
            bool actual = InsertBytes.Insert(ref a, b, firstInd, secondInd);
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
