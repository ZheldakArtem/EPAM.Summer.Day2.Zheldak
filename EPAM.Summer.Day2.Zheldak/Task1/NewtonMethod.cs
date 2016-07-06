using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public static class NewtonMethod
    {
        /// <summary>
        /// The method for finding the roots.
        /// </summary>
        /// <param name="number">The number of wich will be taken the root</param>
        /// <param name="exponent">Power of the root</param>
        /// <param name="correctness"></param>
        /// <returns></returns>
        public static double FindingTheRoot(double number, int exponent, double correctness=0.001)
        {
            if (number < 0 && exponent % 2 == 0)
            {
                return double.NaN;
            }
            if (number < 0 || exponent < 0)
                throw new ArgumentException();
            if (exponent == 0)
            {
                return 1;
            }
            double x = number;
            double xk = 0;
            while (correctness < Math.Abs(x - xk))
            {
                xk = x;
                x = 1.0 / exponent * ((exponent - 1) * xk + number / Math.Pow(xk, exponent - 1));
            }
            return x;
        }
    }
}
