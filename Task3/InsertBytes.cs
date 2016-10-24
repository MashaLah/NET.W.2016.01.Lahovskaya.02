using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public static class InsertBytes
    {
        /// <summary>
        /// Inserts secondNumber into firstNumber from firstIndex byte position to secondIndex byte position.
        /// </summary>
        public static bool Insert(ref int firstNumber, int secondNumber, int firstIndex, int secondIndex)
        {
            if (firstIndex > secondIndex)
            {
                return false;
            }
            else
            {
                BitArray arrFirst = new BitArray(new int[] { firstNumber });
                BitArray arrSecond = new BitArray(new int[] { secondNumber });
                for (int j = 0, i = firstIndex; (j < 1 + secondIndex - firstIndex) && (i <= secondIndex); j++, i++)
                {
                    if (arrFirst[i] == true || arrSecond[j] == true) arrFirst[i] = true;
                }
                byte[] byteArr = new byte[32];
                arrFirst.CopyTo(byteArr, 0);
                firstNumber = BitConverter.ToInt32(byteArr, 0);
                return true;
            }
        }
    }
}
