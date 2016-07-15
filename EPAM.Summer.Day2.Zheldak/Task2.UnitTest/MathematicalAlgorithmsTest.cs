using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Task2;
using static Task2.EucludianMathematicalAlgorithms;

namespace Task2.NUnitTest
{
    public class EucludianMathematicalAlgorithmsTests
    {
        [TestCase(10, 15, ExpectedResult = 5)]
        [TestCase(20, 10, ExpectedResult = 10)]
        [TestCase(20, 0, ExpectedResult = 20)]
        [TestCase(-20, 15, ExpectedResult = 5)]
        public int GetGCD_Test_With_Two_Arguments(int first, int second)
        {
            return GetGCD(first, second);
        }

        [TestCase(10, 15, 4, 1, 7, ExpectedResult = 1)]
        [TestCase(20, 35, 10, 55, 65, ExpectedResult = 5)]
        [TestCase(20, 35, -10, 55, -50, ExpectedResult = 5)]
        [TestCase(21, 84, 42, 1071, 63, ExpectedResult = 21)]
        public int GetGCD_Test_With_ManyArguments(int first, int second, int third, int forth, int fifth)
        {
            return GetGCD(first, second, third, forth, fifth);
        }

        [Test]
        public void EucludianMathematicalAlgorithms_ArgumentExeption()
        {

            Assert.Throws<ArgumentException>(() => GetGCD());
        }

        [TestCase(10, 15, ExpectedResult = 5)]
        [TestCase(20, 10, ExpectedResult = 10)]
        [TestCase(20, 0, ExpectedResult = 20)]
        [TestCase(20, -15, ExpectedResult = 5)]
        public int BinaryEuclidianAlgorithmWithTwoNumbers(int first, int second)
        {
           
            return GetGCD(first, second);
        }
    }
}



