using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task2;

namespace Task2.Tests
{
    [TestClass()]
    public class ConcatedStringTests
    {

        /// <summary>
        /// A test for MakeString() with valid strings.
        /// </summary>
        [TestMethod]
        public void MakeString_ValidStrings_ExpectedString()
        {
            //arrange
            string firstStr = "xyaabbbccccdefww";
            string secondStr = "xxxxyyyyabklmopq";
            string expected = "abcdefklmopqwxy";
            //act
            string actual = ConcatedString.MakeString(firstStr,secondStr);
            //assert
            Assert.AreEqual(expected,actual);
        }
    }
}
