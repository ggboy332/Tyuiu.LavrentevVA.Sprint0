using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.LavrentevVA.Sprint0.Task2.V0.Lib;
namespace Tyuiu.LavrentevVA.Sprint0.Task2.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            //Вызов класса DaraService и метода GetMessage
            //из бибилиотеке Tyuiu.LavrentevVA.Sprint0.Task2.V0.Lib
            Console.WriteLine(DataService.GetMessage("Влад"));
            Console.ReadKey();
        }
    }
}
