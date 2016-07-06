using System;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task1;
using static Task1.NewtonMethod;
namespace Task1.Test
{
    [TestClass]
    public class NewtonMethodTest
    {
       
        [TestMethod]
        public void FindingTheRootTest()
        {
            double number = 16;
            int exponent = 2;
            double correctness = 0.000001;
            double result = Math.Round(FindingTheRoot(number, exponent, correctness), 5);
            double expected = 4;
            Assert.IsTrue(Math.Abs(expected-result)<correctness);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void FindingTheRootTest_With_ArgumentException_Without_Correctness()
        {
            double number = -8;
            int exponent = -3;

            double result = FindingTheRoot(number, exponent);
        }

        [TestMethod]
        public void FindingTheRootTest_Return_NaN()
        {
            double number = -8;
            int exponent = -4;
           
            double result = FindingTheRoot(number, exponent);

            Assert.AreEqual(Double.NaN, result);
        }
    }
}
