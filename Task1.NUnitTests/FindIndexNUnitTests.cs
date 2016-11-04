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
        [TestCase(new int[] { 1, 2, 3, 4 }, null)]
        public void Find_ArrayOfInt_Index(int[] array, int? expected)
        {
            //act
            int? actual = FindIndex.Find(array);
            //assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// A test for Find() when array is null.
        /// </summary>
        [Test]
        public void Find_ArrayIsNull_ThrowArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(()=> FindIndex.Find(null));
        }

        /// <summary>
        /// A test for Find() when array length is less than 3.
        /// </summary>
        [Test]
        public void Find_LengthLessThan3_ThrowArgumentNullException()
        {
            Assert.Throws<ArgumentException>(() => { FindIndex.Find(new int[] { 1, 2 }); });
        }
    }
}
