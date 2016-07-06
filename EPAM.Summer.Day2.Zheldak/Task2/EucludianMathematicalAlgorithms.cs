﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public static class EucludianMathematicalAlgorithms
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
                throw new ArgumentException();
            if (first == 0 || first == second)
                return Math.Abs(second);
            if (second == 0)
                return Math.Abs(first);

            if (second > first)
            {
                int complete = first;
                first = second;
                second = complete;
            }
            int residual = 1;

            while (residual != 0)
            {
                var temp = Math.Abs(first / second);
                if (temp == 0)
                    temp = 1;
                residual = Math.Abs(first - (second * temp));
                first = second;
                second = residual;
            }

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
        /// <returns>Great common devisor</returns>
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
            Array.Sort(arrayNumbers);

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
        /// <param name="elapsedTime"> elapsed time</param>
        /// <param name="arrayNumbers">count of params</param>
        /// <returns>Grear common devisir</returns>
        public static int GetGCD(out long elapsedTime, params int[] arrayNumbers)
        {
            var stopWatch = new Stopwatch();

            stopWatch.Start();
            if (arrayNumbers.Length < 2)
            {
                throw new ArgumentException();
            }

            Array.Sort(arrayNumbers);
            int[] resultArray = new int[arrayNumbers.Length - 1];
            for (int i = 0; i < arrayNumbers.Length - 1; i++)
            {
                resultArray[i] = GetGCD(arrayNumbers[0], arrayNumbers[i + 1]);
            }

            stopWatch.Stop();
            elapsedTime = stopWatch.ElapsedTicks;

            return resultArray.Min();
        }
        /// <summary>
        /// The method for getting the greatest common divisor of two numbers.
        /// </summary>
        /// <param name="first">first value</param>
        /// <param name="second">second value</param>
        /// <returns>The greatest common divisor</returns>
        public static int BinaryGCDalgorithm(int first, int second)
        {
            if (first == 0 && second == 0) throw new ArgumentException();
            if (first == second)
                return first;
            if (first == 0)
                return second;
            if (second == 0)
                return first;

            if (first % 2 == 0)
            {
                if (second % 2 == 0)
                {
                    return 2 * BinaryGCDalgorithm(first / 2, second / 2);
                }
                return BinaryGCDalgorithm(first / 2, second);
            }

            if (second % 2 == 0)
            {
                return BinaryGCDalgorithm(first, second / 2);
            }
            if (first > second)
                return BinaryGCDalgorithm((first - second) / 2, second);

            return BinaryGCDalgorithm((second - first) / 2, first);
        }
        /// <summary>
        /// The method for getting the greatest common divisor of two numbers and receiving method execution time.
        /// </summary>
        /// <param name="first"> First value</param>
        /// <param name="second">Second value</param>
        /// <param name="elapsedTime">Out param for elapsed time in millisecs</param>
        /// <returns>The greatest common divisor of two numbers</returns>
        public static int BinaryGCDalgorithm(int first, int second, out long elapsedTime)
        {
            var stopWatch = new Stopwatch();
            stopWatch.Start();

            int result = BinaryGCDalgorithm(first, second);

            stopWatch.Stop();
            elapsedTime = stopWatch.ElapsedTicks;

            return result;
        }
        /// <summary>
        /// The method for getting the greatest common divisor of three numbers.
        /// </summary>
        /// <param name="first">first value</param>
        /// <param name="second">second value</param>
        /// <param name="third">third value</param>
        /// <returns>The greatest common divisor</returns>
        public static int BinaryGCDalgorithm(int first, int second,int third)
        {
            int intermediate = BinaryGCDalgorithm(first, second);
            int result = BinaryGCDalgorithm(intermediate,third);

            return result;
        }
        /// <summary>
        /// The method for getting the greatest common divisor of three numbers and receiving method execution time.
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <param name="third"></param>
        /// <param name="elapsedTime"></param>
        /// <returns>great common devisor</returns>
        public static int BinaryGCDalgorithm(int first, int second, int third,out long elapsedTime)
        {
            var stopWatch = new Stopwatch();
            stopWatch.Start();

            int result = BinaryGCDalgorithm(first, second, third);

            stopWatch.Stop();
            elapsedTime = stopWatch.ElapsedTicks;

            return result;
        }
        /// <summary>
        /// The method for getting the greatest common divisor(GCD).
        /// </summary>
        /// <param name="arrayNumbers">Count numbers</param>
        /// <returns>The greatest common divisor</returns>
        public static int BinaryGCDalgorithm(params int[] arrayNumbers)
        {
            if (arrayNumbers.Length < 2)
            {
                throw new ArgumentException();
            }

            Array.Sort(arrayNumbers);
            int[] resultArray = new int[arrayNumbers.Length - 1];

            for (int i = 0; i < arrayNumbers.Length - 1; i++)
            {
                resultArray[i] = BinaryGCDalgorithm(arrayNumbers[0], arrayNumbers[i + 1]);
            }

            return resultArray.Min();
        }
        /// <summary>
        /// The method for getting the greatest common divisor(GCD) and receiving method execution time.
        /// <exception cref="ArgumentException">Throws when you have less two params</exception>
        /// </summary>
        /// <param name="elapsedTime"> elapsed time</param>
        /// <param name="arrayNumbers">count of params</param>
        /// <returns>Grear common devisir</returns>
        public static int BinaryGCDalgorithm(out long elapsedTime, params int[] arrayNumbers)
        {
            var stopWatch = new Stopwatch();

            stopWatch.Start();
            if (arrayNumbers.Length < 2)
            {
                throw new ArgumentException();
            }

            Array.Sort(arrayNumbers);
            int[] resultArray = new int[arrayNumbers.Length - 1];
            for (int i = 0; i < arrayNumbers.Length - 1; i++)
            {
                resultArray[i] = BinaryGCDalgorithm(arrayNumbers[0], arrayNumbers[i + 1]);
            }

            stopWatch.Stop();
            elapsedTime = stopWatch.ElapsedTicks;

            return resultArray.Min();
        }

    }
}
