using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_7
{
    internal class Solution
    {
        public int solution(int[] A)
        {
            HashSet<int> positiveNumbers = new HashSet<int>();

            // Add all positive numbers to the HashSet
            foreach (int number in A)
            {
                if (number > 0)
                {
                    positiveNumbers.Add(number);
                }
            }

            // Find the smallest positive integer that occurs in the array
            int smallestPositiveInteger = 0;
            for (int i = 1; i <= 1000000; i++)
            {
                if (positiveNumbers.Contains(i))
                {
                    smallestPositiveInteger = i;
                    break;
                }
            }

            // Return the square of the smallest positive integer
            return smallestPositiveInteger * smallestPositiveInteger;
        }
    }
}
