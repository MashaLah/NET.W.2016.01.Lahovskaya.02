using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Task2;

namespace Task2.NUnitTests
{
    [TestFixture]
    public class ConcatedStringNUnitTests
    {
        /// <summary>
        /// A test for MakeString() with valid strings.
        /// </summary>
        [Test]
        public void MakeString_ValidStrings_ExpectedString()
        {
            //arrange
            string firstStr = "xyaabbbccccdefww";
            string secondStr = "xxxxyyyyabklmopq";
            string expected = "abcdefklmopqwxy";
            //act
            string actual = ConcatedString.MakeString(firstStr, secondStr);
            //assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// A test for MakeString() with one string is null.
        /// </summary>
        [Test]
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
        [Test]
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
