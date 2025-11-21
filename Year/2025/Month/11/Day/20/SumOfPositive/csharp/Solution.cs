using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Codewars:    Sum of Positive - 8 Kyu
// Problem: https://www.codewars.com/kata/56747fd5cb988479af000028/csharp

namespace Codewars.Year._2025.Month._11.Day._20.SumOfPositive.csharp
{
    internal class Solution
    {
        public static int PositiveSum(int[] arr)
        {
            int sum = 0;

            if (arr.Length == 0)
            {
                return 0;
            }

            foreach (int x in arr)
            {
                if (x < 0)
                {
                    continue;
                }
                sum += x;
            }
            return sum;
        }
    }
}