using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.NeldnerMK.Sprint0.Task4.V0.Lib;

namespace Tyuiu.NeldnerMK.Sprint0.Task3.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DataService.Addition(7, 7));
            Console.WriteLine(DataService.Subtraction(10, 5));
            Console.WriteLine(DataService.Multiplication(10, 5));
            Console.WriteLine(DataService.Division(9, 3));
            Console.ReadKey();
        }
    }
}