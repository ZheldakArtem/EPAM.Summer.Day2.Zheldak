using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1;

namespace ForTask
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = 255;
            int exponent = 4;
            double correctness = 0.01;
            var result = NewtonMetjod.FindingTheRoot(number, exponent, correctness);
            Console.WriteLine("NewtonMethod:{0}", result);
            double resultPow = Math.Pow(number, (double)1/exponent);
            Console.WriteLine("Math.Pow:{0}", resultPow);
            Console.ReadLine();
        }
    }
}
