using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Task1.NUnitTests
{
    [TestFixture]
    public class FindIndexNUnitTests
    {
        /// <summary>
        /// A test for Find().
        /// </summary>
        [TestCase(new int[] { 1, 2, 3, 4, 3, 2, 1 },3)]
        [TestCase(new int[] { 1, 2, 3, 4 }, -1)]
        [TestCase(null, -1)]
        [TestCase(new int[] { 1, 2 }, -1)]
        public void Find_ArrayOfInt_Index(int[] array, int expected)
        {
            //act
            int actual = FindIndex.Find(array);
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
