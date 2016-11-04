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

        [TestCase("abc", null)]
        [TestCase(null,"abc")]
        [TestCase("abc", "123")]
        [TestCase("123", "abc")]
        public void MakeString_InvalidData_Throw(string firstString, string secondString)
        {
            Assert.Throws<ArgumentException>(()=>ConcatedString.MakeString(firstString,secondString));
        }
    }
}
