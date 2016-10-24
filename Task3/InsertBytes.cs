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
        public static int Insert(int firstNumber, int secondNumber, int firstIndex, int secondIndex)
        {
            BitArray arrFirst = new BitArray(new int[] { firstNumber });
            BitArray arrSecond = new BitArray(new int[] { secondNumber });
            for (int j = 0, i = firstIndex; (j < 1 + secondIndex - firstIndex) && (i <= secondIndex); j++, i++)
            {
                if (arrFirst[i] == true || arrSecond[j] == true) arrFirst[i] = true;
            }
            byte[] byteArr = new byte[32];
            arrFirst.CopyTo(byteArr,0);
            int result = BitConverter.ToInt32(byteArr, 0);
            return result;
        }
    }
}
