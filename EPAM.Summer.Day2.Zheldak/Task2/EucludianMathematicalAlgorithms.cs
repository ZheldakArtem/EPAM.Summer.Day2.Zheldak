using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2;
namespace Task2
{

    public static class EucludianMathematicalAlgorithms
    {
        /// <summary>
        /// The method for getting the greatest common divisor of two numbers.
        /// </summary>
        /// <param name="first">first value</param>
        /// <param name="second">second value</param>
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
        public static int GetGCD(out long elapsedTime, int first, int second)
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
        public static int GetGCD(int first, int second, int third) => MethodWithDelegate(GetGCD, first, second, third);

        /// <summary>
        /// The method for getting the greatest common divisor of three numbers and receiving method execution time.
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <param name="third"></param>
        /// <param name="elapsedTime"></param>
        /// <returns>The greatest common divisor</returns>
        public static int GetGCD(out long elapsedTime, int first, int second, int third)
            => MethodWithDelegateAndTime(GetGCD, out elapsedTime, first, second, third);

        /// <summary>
        /// The method for getting the greatest common divisor(GCD).
        /// </summary>
        /// <param name="arrayNumbers">Array of values</param>
        /// <returns>The greatest common divisor</returns>
        public static int GetGCD(params int[] arrayNumbers) => MethodWithDelegate(GetGCD, arrayNumbers);

        /// <summary>
        /// The method for getting the greatest common divisor(GCD) and receiving method execution time.
        /// <exception cref="ArgumentException">Throws when you have less two params</exception>
        /// </summary>
        /// <param name="elapsedTime"> elapsed time</param>
        /// <param name="arrayNumbers">count of params</param>
        /// <returns>The greatest common divisor</returns>
        public static int GetGCD(out long elapsedTime, params int[] arrayNumbers) => MethodWithDelegateAndTime(GetGCD, out elapsedTime, arrayNumbers);

        /// <summary>
        /// The method for getting the greatest common divisor of two numbers.
        /// </summary>
        /// <param name="first">first value</param>
        /// <param name="second">second value</param>
        /// <returns>The greatest common divisor</returns>
        public static int GetBinary(int first, int second)
        {
            if (first == second)
            {
                return first;
            }
            if (first == 1 || second == 1)
            {
                return 1;
            }

            if (first == 0 && second == 0) throw new Exception("Invalid function arguments!");

            if (first == 0)
            {
                return second;
            }

            if (second == 0)
            {
                return first;
            }
            if ((first % 2 == 0) && (second % 2 == 0))
            {
                return 2 * GetBinary(first / 2, second / 2);
            }
            if ((first % 2 == 0) && (second % 2 != 0))
            {
                return GetBinary(first / 2, second);
            }
            if ((first % 2 != 0) && (second % 2 == 0))
            {
                return GetBinary(first, second / 2);
            }
            return GetBinary(second, Math.Abs(first - second));
        }

        /// <summary>
        /// The method for getting the greatest common divisor of three numbers.
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <param name="third"></param>
        /// <returns>The greatest common divisor</returns>
        public static int GetBinary(int first, int second, int third) => MethodWithDelegate(GetBinary, first, second, third);

        /// <summary>
        /// The method for getting the greatest common divisor of two numbers and receiving method execution time.
        /// </summary>
        /// <param name="first"> First value</param>
        /// <param name="second">Second value</param>
        /// <param name="elapsedTime">Out param for elapsed time in millisecs</param>
        /// <returns>The greatest common divisor</returns>
        public static int GetBinary(out long elapsedTime, int first, int second)
            => MethodWithDelegateAndTime(GetBinary, out elapsedTime, first, second);

        /// <summary>
        /// The method for getting the greatest common divisor of three numbers and receiving method execution time.
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <param name="third"></param>
        /// <param name="elapsedTime"></param>
        /// <returns>Great common devisor</returns>
        public static int GetBinary(out long elapsedTime, int first, int second, int third)
            => MethodWithDelegateAndTime(GetBinary, out elapsedTime, first, third);

        /// <summary>
        /// The method for getting the greatest common divisor(GCD).
        /// </summary>
        /// <param name="arrayNumbers">Array of values</param>
        /// <returns>The greatest common divisor</returns>
        public static int GetBinary(params int[] arrayNumbers) => MethodWithDelegate(GetBinary, arrayNumbers);

        /// <summary>
        /// The method which use delegate as a param.
        /// </summary>
        /// <param name="method"></param>
        /// <param name="args"></param>
        /// <returns>The greatest common divisor</returns>
        private static int MethodWithDelegate(Func<int, int, int> method, params int[] args)
        {
            Array.Sort(args);

            if (args.Length < 2)
            {
                throw new ArgumentException();
            }
            int[] resultArray = new int[args.Length - 1];
            for (int i = 0; i < args.Length - 1; i++)
            {
                resultArray[i] = method(args[0], args[i + 1]);
            }

            return resultArray.Min();
        }

        /// <summary>
        /// The method which use delegate as a param whis elapsed time.
        /// </summary>
        /// <param name="method">delegate</param>
        /// <param name="elapsedTime">time</param>
        /// <param name="args">Aray of values</param>
        /// <returns></returns>
        private static int MethodWithDelegateAndTime(Func<int, int, int> method, out long elapsedTime, params int[] args)
        {
            if (args.Length < 2)
            {
                throw new ArgumentException();
            }

            var stopWatch = new Stopwatch();
            stopWatch.Start();
            Array.Sort(args);

            int[] resultArray = new int[args.Length - 1];
            for (int i = 0; i < args.Length - 1; i++)
            {
                resultArray[i] = method(args[0], args[i + 1]);
            }
            stopWatch.Stop();
            elapsedTime = stopWatch.ElapsedTicks;

            return resultArray.Min();
        }
    }
}

