using System;
using System.Linq;

namespace PracticeAB;

class Program
{


    // Творим тут


    //1
    static int Sum(int a, int b)
    {
        return a + b;
    }

    //2
    static bool Chet(int a)
    {
        return a % 2 == 0;
    }

    //3
    static string RevStr(string s)
    {
        char[] charArray = s.ToCharArray();
        Array.Reverse(charArray);
        s = new string(charArray);
        return s;
    }

    //4

    static int MaxArray(int[] a)
    {
        return a.Max();
    }

    // 5
    static int Godovaya(int a)
    {
        return a * 12;
    }

    // 6

    static double CelInFar(float a)
    {
        return a * 1.8 + 32;
    }
    //7
    static int CountGlas(string s)
    {
        int a = 0;
        string vowels = "аиоуеэАИОУЕЭ";
        foreach (char c in s)
        {
            if (vowels.Contains(c))
            {
                a++;
            }
        }
        return a;
    }

    //8
    static int ProvPassw(string s)
    {
        int count = 0;
        for (int i = 0; i < 10; i++)
            for (int j = 0; j < 10; j++)
                for (int k = 0; k < 10; k++)
                    for (int l = 0; l < 10; l++)
                    {
                        count += 1;
                        string generetedPass = i.ToString() + j.ToString() + k.ToString() + l.ToString();
                        if (generetedPass == s)
                        {
                            Console.WriteLine("Ура! Вы взломали пароль теперь вы хакер.");
                            return count;
                        }

                    }

        return count;
    }
    static void Main(string[] args)
    {
        int[] num = { 1, 3, 2, 6, 4, 3, 2, 5, 1 };
        Console.WriteLine(Sum(42, 52));
        Console.WriteLine(Chet(22));
        Console.WriteLine(RevStr("Перевертыш"));
        Console.WriteLine(MaxArray(num));
        Console.WriteLine(Godovaya(30000));
        Console.WriteLine(CelInFar(50));
        Console.WriteLine(CountGlas("Параллелепипед"));
        Console.WriteLine($"Колличество попыток: {ProvPassw("1230")}");
    }
}
