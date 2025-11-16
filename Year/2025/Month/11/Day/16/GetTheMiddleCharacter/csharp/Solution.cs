using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Codewars: Get the Middle Character - 7 Kyu
// Problem: https://www.codewars.com/kata/56747fd5cb988479af000028/csharp

namespace Codewars.Year._2025.Month._11.Day._16.GetTheMiddleCharacter.csharp
{
    internal class Solution
    {
        public static string GetMiddle(string s)
        {
            int len = s.Length;

            for (int i = 0; i < s.Length; i++)
            {
                if (len % 2 == 1)
                {
                    return new string(s[len / 2].ToString());
                }

                else
                {
                    return new string(s[len / 2 - 1].ToString() + s[len / 2].ToString());
                }
            }
            return "No input argument";
        }
    }
}
