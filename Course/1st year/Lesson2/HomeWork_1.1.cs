using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число.");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число.");
            int b = int.Parse(Console.ReadLine());
            int ans = a + b;
            Console.WriteLine(ans);
        }
    }
}
