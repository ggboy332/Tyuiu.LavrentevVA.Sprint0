using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.LavrenvVA.Sprin0.Task5 .V0.Lib;

namespace Tyuiu.LavrenvVA.Sprin0.Task5.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A + b = " + DataService.Addition(1, 5));
            Console.WriteLine("A - B = " + DataService.Substraction(15, 5));
            Console.WriteLine("A * B = " + DataService.Multiplication(10, 10));
            Console.WriteLine("A / B = " + DataService.Division(5, 1));

            Console.ReadKey();
        }
    }
}
