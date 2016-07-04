using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public static class EuclidAlgorithm
    {
        /// <summary>
        /// The method for getting the greatest common divisor of two numbers.
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns>The geatest common divisor of two numbers</returns>
        public static int GetGCD(int first, int second)
        {
            if (first == 0 && second == 0)
            {
                throw new ArgumentException();
            }
            while (first != 0 && second != 0)
            {
                if (first > second)
                    first %= second;
                else
                    second %= first;
            }

            if (first == 0)
                return second;
            else
                return first;
        }
        
    }
}
