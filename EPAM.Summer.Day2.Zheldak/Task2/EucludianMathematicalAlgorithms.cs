using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2;
namespace Task2
{
    public delegate int EuclidianDelegate(int a, int b);
    public static class EucludianMathematicalAlgorithms
    {
       
        
        /// <summary>
        /// The method for getting the greatest common divisor of two numbers.
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <param name="methodDelegate"></param>
        /// <returns>The greatest common divisor of two numbers</returns>
        public static int GetGCD(int first, int second, EuclidianDelegate methodDelegate)
            => methodDelegate(first, second);
        
        /// <summary>
        /// The method for getting the greatest common divisor of two numbers and receiving method execution time.
        /// </summary>
        /// <param name="first"> First value</param>
        /// <param name="second">Second value</param>
        /// <param name="elapsedTime">Out param for elapsed time in millisecs</param>
        /// <returns>The greatest common divisor of two numbers</returns>
        public static int GetGCD(int first, int second, out long elapsedTime,EuclidianDelegate methodDelegate)
        {
            var stopWatch = new Stopwatch();
            stopWatch.Start();

            int result = methodDelegate(first, second);

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
        public static int GetGCD(int first, int second, int third, EuclidianDelegate methodDelegate)
        {
            int intermediate = methodDelegate(first, second);
            int result = methodDelegate(intermediate, third);

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
        public static int GetGCD(int first, int second, int third, out long elapsedTime, EuclidianDelegate methodDelegate)
        {
            var stopWatch = new Stopwatch();
            stopWatch.Start();

            int result = GetGCD(first, second, third, methodDelegate);

            stopWatch.Stop();
            elapsedTime = stopWatch.ElapsedTicks;

            return result;
        }

        /// <summary>
        /// The method for getting the greatest common divisor(GCD).
        /// </summary>
        /// <param name="methodDelegate"></param>
        /// <param name="arrayNumbers"></param>
        /// <returns></returns>
        public static int GetGCD(EuclidianDelegate methodDelegate,params int[] arrayNumbers)
        {
            Array.Sort(arrayNumbers);

            if (arrayNumbers.Length < 2)
            {
                throw new ArgumentException();
            }
            int[] resultArray = new int[arrayNumbers.Length - 1];
            for (int i = 0; i < arrayNumbers.Length - 1; i++)
            {
                resultArray[i] = GetGCD(arrayNumbers[0], arrayNumbers[i + 1], methodDelegate);
            }

            return resultArray.Min();
        }

        /// <summary>
        /// The method for getting the greatest common divisor(GCD) and receiving method execution time.
        /// <exception cref="ArgumentException">Throws when you have less two params</exception>
        /// </summary>
        /// <param name="elapsedTime"> elapsed time</param>
        /// <param name="methodDelegate"></param>
        /// <param name="arrayNumbers">count of params</param>
        /// <returns>Grear common devisir</returns>
        public static int GetGCD(out long elapsedTime, EuclidianDelegate methodDelegate, params int[] arrayNumbers)
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
                resultArray[i] = GetGCD(arrayNumbers[0], arrayNumbers[i + 1], methodDelegate);
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
        /// <param name="methodDelegate"></param>
        /// <returns>The greatest common divisor</returns>
        public static int BinaryGCDalgorithm(int first, int second, EuclidianDelegate methodDelegate)
            => methodDelegate(first, second);

        /// <summary>
        /// The method for getting the greatest common divisor of two numbers and receiving method execution time.
        /// </summary>
        /// <param name="first"> First value</param>
        /// <param name="second">Second value</param>
        /// <param name="elapsedTime">Out param for elapsed time in millisecs</param>
        /// <param name="methodDelegate"></param>
        /// <returns>The greatest common divisor of two numbers</returns>
        public static int BinaryGCDalgorithm(int first, int second, out long elapsedTime, EuclidianDelegate methodDelegate)
        {
            var stopWatch = new Stopwatch();
            stopWatch.Start();

            int result = methodDelegate(first,second);

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
        /// <param name="methodDelegate"></param>
        /// <returns>The greatest common divisor</returns>
        public static int BinaryGCDalgorithm(int first, int second,int third, EuclidianDelegate methodDelegate)
        {
            int intermediate = methodDelegate(first, second);
            int result = methodDelegate(intermediate,third);

            return result;
        }

        /// <summary>
        /// The method for getting the greatest common divisor of three numbers and receiving method execution time.
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <param name="third"></param>
        /// <param name="elapsedTime"></param>
        /// <param name="methodDelegate"></param>
        /// <returns>great common devisor</returns>
        public static int BinaryGCDalgorithm(int first, int second, int third,out long elapsedTime, EuclidianDelegate methodDelegate)
        {
            var stopWatch = new Stopwatch();
            stopWatch.Start();

            int result = BinaryGCDalgorithm(first, second, third,methodDelegate);

            stopWatch.Stop();
            elapsedTime = stopWatch.ElapsedTicks;

            return result;
        }

        /// <summary>
        /// The method for getting the greatest common divisor(GCD).
        /// </summary>
        /// <param name="methodDelegate"></param>
        /// <param name="arrayNumbers">Count numbers</param>
        /// <returns>The greatest common divisor</returns>
        public static int BinaryGCDalgorithm(EuclidianDelegate methodDelegate,params int[] arrayNumbers)
        {
            if (arrayNumbers.Length < 2)
            {
                throw new ArgumentException();
            }

            Array.Sort(arrayNumbers);
            int[] resultArray = new int[arrayNumbers.Length - 1];

            for (int i = 0; i < arrayNumbers.Length - 1; i++)
            {
                resultArray[i] = BinaryGCDalgorithm(arrayNumbers[0], arrayNumbers[i + 1],methodDelegate);
            }

            return resultArray.Min();
        }

        /// <summary>
        /// The method for getting the greatest common divisor(GCD) and receiving method execution time.
        /// <exception cref="ArgumentException">Throws when you have less two params</exception>
        /// </summary>
        /// <param name="elapsedTime"> elapsed time</param>
        /// <param name="methodDelegate"></param>
        /// <param name="arrayNumbers">count of params</param>
        /// <returns>Grear common devisir</returns>
        public static int BinaryGCDalgorithm(out long elapsedTime, EuclidianDelegate methodDelegate, params int[] arrayNumbers)
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
                resultArray[i] = BinaryGCDalgorithm(arrayNumbers[0], arrayNumbers[i + 1],methodDelegate);
            }

            stopWatch.Stop();
            elapsedTime = stopWatch.ElapsedTicks;

            return resultArray.Min();
        }

    }
}

