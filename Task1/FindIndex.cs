﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public static class FindIndex
    {
        /// <summary>
        /// Finds the smallest array index, for which sum of left elements equals sum of right elements.
        /// </summary>
        /// <param name="array"></param>
        /// <returns>Index if found, -1 if not found.</returns>
        public static int Find(int[] array)
        {
            if (array != null && array.Length > 2)
            {
                for (int i = 1; i < array.Length - 1; i++)
                {
                    int sumLeft = 0;
                    int sumRight = 0;
                    for (int j = 0; j < i; j++)
                    {
                        sumLeft += array[j];
                    }
                    for (int j = i + 1; j < array.Length; j++)
                    {
                        sumRight += array[j];
                    }
                    if (sumLeft == sumRight)
                    {
                        return i;
                    }
                }
            }
            return -1;
        }
    }
}
