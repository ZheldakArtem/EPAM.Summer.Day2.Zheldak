using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Task2;

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
            return EucludianMathematicalAlgorithms.GetGCD(first, second);
        }
        [TestCase(10, 15, 4, 1, ExpectedResult = 1)]
        [TestCase(20, 35, 10, 55, ExpectedResult = 5)]
        [TestCase(20, 35, -10, 55, ExpectedResult = -5)]
        [TestCase(21, 84, 42, 1071, ExpectedResult = 21)]
        public int GetGCD_Test_With_ManyArguments(int first, int second,int third,int forth)
        {
            return EucludianMathematicalAlgorithms.GetGCD(first, second,third,forth);
        }

        [TestCase(1)]
        public void EucludianMathematicalAlgorithms_ArgumentExeption(int oneParam)
        {
            Assert.Throws<ArgumentException>(() => EucludianMathematicalAlgorithms.GetGCD());
        }
    }
}
