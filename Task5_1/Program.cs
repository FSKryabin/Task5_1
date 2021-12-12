using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_1
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Введите 7 элементоа массива:");
            Console.WriteLine(Enumerable.Range(0, 7).Select(x => double.Parse(Console.ReadLine())).Average());
            Console.ReadKey();

        }

    }
}
