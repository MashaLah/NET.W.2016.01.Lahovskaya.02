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
            int expected = 31;
            //act
            int actual = InsertBytes.Insert(a,b,firstInd,secondInd);
            //assert
            Assert.AreEqual(expected,actual);
        }
    }
}
