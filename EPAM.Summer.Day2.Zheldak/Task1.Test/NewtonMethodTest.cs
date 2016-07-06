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
        public TestContext TestContext { get; set; }

        [DeploymentItem("Task1.Test\\NewtonMethodTestCase.xml")]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
                      "|DataDirectory|\\NewtonMethodTestCase.xml",
                      "Case",
                       DataAccessMethod.Sequential)]

        [TestMethod]
        public void FindingTheRootTest_Nice()
        {
            double number = double.Parse((string)TestContext.DataRow["Number"]);
            int exponent = int.Parse((string)TestContext.DataRow["Exponent"]);
            double result = int.Parse((string)TestContext.DataRow["Result"]);
            Assert.AreEqual(Math.Round(FindingTheRoot(number, exponent), 5), result);
        }


        [DeploymentItem("Task1.Test\\NewtonMethodWithCorrectness.xml")]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
            "|DataDirectory|\\NewtonMethodWithCorrectness.xml",
            "Case",
            DataAccessMethod.Sequential)]
        [TestMethod]
        public void FindingTheRootTestWithCorectness()
        {
            double number = double.Parse((string)TestContext.DataRow["Number"]);
            int exponent = int.Parse((string)TestContext.DataRow["Exponent"]);
            double correctness = double.Parse((string)TestContext.DataRow["Correctness"]);
            double result = double.Parse((string)TestContext.DataRow["Result"]);

            Assert.IsTrue(Math.Abs(FindingTheRoot(number, exponent, correctness) - result) < correctness);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public double FindingTheRootTest_With_ArgumentException_Without_Correctness()
        {
            double number = -8;
            int exponent = -3;

            return FindingTheRoot(number, exponent);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public double FindingTheRootTest_Two_Negative_Params()
        {
            double number = -8;
            int exponent = -4;

            return FindingTheRoot(number, exponent);
        }
    }
}
