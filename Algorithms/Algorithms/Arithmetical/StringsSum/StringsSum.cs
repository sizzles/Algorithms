﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Arithmetical.StringsSum
{
    class StringsSum
    {
        /// <summary>
        /// give a sequence of positive integer numbers in argument given as string of numbers separated by a space.
        /// <para>The program calculates their sum.</para>
        /// </summary>
        public int Calculate(string numbers)
        {
            string[] arr = numbers.Split(' ');
            int num;
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                bool isConverted = int.TryParse(arr[i], out num);
                if (isConverted)
                {
                    sum += num;
                }
            }

            return sum;
        }
    }
}
