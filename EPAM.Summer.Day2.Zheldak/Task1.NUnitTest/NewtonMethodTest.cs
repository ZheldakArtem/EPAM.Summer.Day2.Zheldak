using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Task1;


namespace Task1.NUnitTest
{
    public class NewtonMethodTest
    {

        [TestCase(7, 2, 0.01, 2.6457)]
        [TestCase(0.125, 3, 0.01, 0.5)]
        [TestCase(146.41, 2, 0.01, 12.1)]
        public void NewtonMethod_Test(double number, int power, double correctness, double res)
        {

            Assert.IsTrue(Math.Abs(res - NewtonMethod.FindingTheRoot(number, power)) < correctness);
        }

        [TestCase(9,2,1.2)]
        [TestCase(-4,-2)]
        public void NewtonMethod_ArithmeticException(double number, int correctness)
        {
            Assert.Throws<ArithmeticException>(() => NewtonMethod.FindingTheRoot(number, correctness));
        }
    }
}
