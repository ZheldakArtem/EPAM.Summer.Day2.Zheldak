using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public static class MathematicalAlgorithms
    {
        /// <summary>
        /// The method for getting the greatest common divisor of two numbers.
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns>The greatest common divisor of two numbers</returns>
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
        /// <summary>
        /// The method for getting the greatest common divisor of two numbers and receiving method execution time.
        /// </summary>
        /// <param name="first"> First value</param>
        /// <param name="second">Second value</param>
        /// <param name="elapsedTime">Out param for elapsed time in millisecs</param>
        /// <returns>The greatest common divisor of two numbers</returns>
        public static int GetGCD(int first, int second, out long elapsedTime)
        {
            var stopWatch = new Stopwatch();
            stopWatch.Start();

            int result = GetGCD(first, second);

            stopWatch.Stop();
            elapsedTime = stopWatch.ElapsedTicks;

            return result;
        }
        /// <summary>
        /// The method for getting the greatest common divisor of three numbers.
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <param name="third"></param>
        /// <returns>The greatest common divisor</returns>
        public static int GetGCD(int first, int second, int third)
        {
            int intermediate = GetGCD(first, second);
            int result = GetGCD(intermediate, third);

            return result;
        }
        /// <summary>
        /// The method for getting the greatest common divisor of three numbers and receiving method execution time.
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <param name="third"></param>
        /// <param name="elapsedTime"></param>
        /// <returns></returns>
        public static int GetGCD(int first, int second, int third, out long elapsedTime)
        {
            var stopWatch = new Stopwatch();
            stopWatch.Start();

            int result = GetGCD(first, second, third);

            stopWatch.Stop();
            elapsedTime = stopWatch.ElapsedTicks;

            return result;
        }
        /// <summary>
        /// The method for getting the greatest common divisor(GCD).
        /// </summary>
        /// <param name="arrayNumbers"></param>
        /// <returns></returns>
        public static int GetGCD(params int[] arrayNumbers)
        {
            if (arrayNumbers.Length < 2)
            {
                throw new ArgumentException();
            }
            int[] resultArray = new int[arrayNumbers.Length - 1];
            for (int i = 0; i < arrayNumbers.Length - 1; i++)
            {
                resultArray[i] = GetGCD(arrayNumbers[0], arrayNumbers[i + 1]);
            }

            return resultArray.Min();
        }

        /// <summary>
        /// The method for getting the greatest common divisor(GCD) and receiving method execution time.
        /// <exception cref="ArgumentException">Throws when you have less two params</exception>
        /// </summary>
        /// <param name="elapsedTime"></param>
        /// <param name="arrayNumbers">count of params</param>
        /// <returns>GCD</returns>
        public static int GetGCD(out long elapsedTime, params int[] arrayNumbers)
        {
            var stopWatch = new Stopwatch();

            stopWatch.Start();
            if (arrayNumbers.Length < 2)
            {
                throw new ArgumentException();
            }
            int[] resultArray = new int[arrayNumbers.Length - 1];
            for (int i = 0; i < arrayNumbers.Length - 1; i++)
            {
                resultArray[i] = GetGCD(arrayNumbers[0], arrayNumbers[i + 1]);
            }

            stopWatch.Stop();
            elapsedTime = stopWatch.ElapsedTicks;

            return resultArray.Min();
        }

       
    }
}
