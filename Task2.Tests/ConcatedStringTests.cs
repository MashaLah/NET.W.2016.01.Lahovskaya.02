using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task2;

namespace Task2.Tests
{
    [TestClass]
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

        /// <summary>
        /// A test for MakeString() with one string is null.
        /// </summary>
        [TestMethod]
        public void MakeString_StringIsNull_Message()
        {
            //arrange
            string firstStr = "xyaabbbccccdefww";
            string secondStr = null;
            string expected = "Input string is null or contains not only letters.";
            //act
            string actual = ConcatedString.MakeString(firstStr, secondStr);
            //assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// A test for MakeString() with one string contains not only letters.
        /// </summary>
        [TestMethod]
        public void MakeString_StringContainsNotOnlyLetters_Message()
        {
            //arrange
            string firstStr = "xyaabbbccccdefww";
            string secondStr = "123";
            string expected = "Input string is null or contains not only letters.";
            //act
            string actual = ConcatedString.MakeString(firstStr, secondStr);
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
