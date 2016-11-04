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
        public static int Insert(int firstNumber, int secondNumber, int firstIndex, int secondIndex)
        {
            if (firstIndex > secondIndex)
                throw new ArgumentException($"{nameof(firstIndex)} is bigger than {nameof(secondIndex)}");

                BitArray arrFirst = new BitArray(new int[] { firstNumber });
                BitArray arrSecond = new BitArray(new int[] { secondNumber });
                for (int j = 0, i = firstIndex; (j < 1 + secondIndex - firstIndex) && (i <= secondIndex); j++, i++)
                {
                    if (arrFirst[i] == true || arrSecond[j] == true) arrFirst[i] = true;
                }
                byte[] byteArr = new byte[32];
                arrFirst.CopyTo(byteArr, 0);
                return BitConverter.ToInt32(byteArr, 0);
        }
    }
}
