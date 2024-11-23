using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool ver = true;
            bool ver2 = true;
            int a = 52;
            Console.WriteLine("Я загадал число. Попробуй отгадать за 3 попытки. Подсказка: число двухзначное:");
            int b = int.Parse(Console.ReadLine());
            if (b < a)
            {
                Console.WriteLine("Неверно! Больше");
            }
            else if (b > a)
            {
                Console.WriteLine("Неверно! Меньше");

            }
            else
            {
                Console.WriteLine("Верно! Молодец!");
                ver = false;
            }

            if (ver)
            {
                Console.WriteLine("Попробуйте ещё раз! Осталось 2 попытки");
                b = int.Parse(Console.ReadLine());
                if (b < a)
                {
                    Console.WriteLine("Неверно! Больше");
                    ver2 = false;
                }
                else if (b > a)
                {
                    Console.WriteLine("Неверно! Меньше");
                    ver2 = false;
                }
                else
                {
                    Console.WriteLine("Верно! Молодец!");
                    
                }
            }
            if (!ver2)
            {
                Console.WriteLine("Попробуйте ещё раз! Осталось 1 попытка");
                b = int.Parse(Console.ReadLine());
                if (b < a)
                {
                    Console.WriteLine("Неверно! Вы проиграли. Ответ 52.");
                }
                else if (b > a)
                {
                    Console.WriteLine("Неверно! Вы проиграли. Ответ 52.");

                }
                else
                {
                    Console.WriteLine("Верно! Молодец!");
                }
            }
        }

    }
}
