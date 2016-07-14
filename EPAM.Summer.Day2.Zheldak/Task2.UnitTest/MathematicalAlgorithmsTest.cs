using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Task2;

namespace Task2.NUnitTest
{
    public class EucludianMathematicalAlgorithmsTests
    {
        EuclidianDelegate methodGDC = GDCMethodForDelegate;
        EuclidianDelegate methodBinary = BinaryMethodForDelegate;

        [TestCase(10, 15,  ExpectedResult = 5)]
        [TestCase(20, 10, ExpectedResult = 10)]
        [TestCase(20, 0, ExpectedResult = 20)]
        [TestCase(-20, 15, ExpectedResult = 5)]
        public int GetGCD_Test_With_Two_Arguments(int first, int second, EuclidianDelegate methodGDC)
        {
            return EucludianMathematicalAlgorithms.GetGCD(first, second,methodGDC);
        }
        [TestCase(10, 15, 4, 1, ExpectedResult = 1)]
        [TestCase(20, 35, 10, 55, ExpectedResult = 5)]
        [TestCase(20, 35, -10, 55, ExpectedResult = 5)]
        [TestCase(21, 84, 42, 1071, ExpectedResult = 21)]
        public int GetGCD_Test_With_ManyArguments(int first, int second,int third,int forth)
        {
            return EucludianMathematicalAlgorithms.GetGCD(methodGDC,first, second,third,forth);
        }

        [Test]
        public void EucludianMathematicalAlgorithms_ArgumentExeption()
        {
            Assert.Throws<ArgumentException>(() => EucludianMathematicalAlgorithms.GetGCD(methodGDC));
        }

        [TestCase(10, 15, ExpectedResult = 5)]
        [TestCase(20, 10, ExpectedResult = 10)]
        [TestCase(20, 0, ExpectedResult = 20)]
        [TestCase(20, -15, ExpectedResult = 5)]
        public int BinaryEuclidianAlgorithmWithTwoNumbers(int first, int second)
        {
            return EucludianMathematicalAlgorithms.BinaryGCDalgorithm(first, second, methodBinary);
        }
#region Method for delegate
        public static int GDCMethodForDelegate(int first, int second)
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

        public static int BinaryMethodForDelegate(int first, int second)
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
                return 2 * BinaryMethodForDelegate(first / 2, second / 2);
            }
            if ((first % 2 == 0) && (second % 2 != 0))
            {
                return BinaryMethodForDelegate(first / 2, second);
            }
            if ((first % 2 != 0) && (second % 2 == 0))
            {
                return BinaryMethodForDelegate(first, second / 2);
            }
            return BinaryMethodForDelegate(second, Math.Abs(first - second));
        }
#endregion
    }
}



