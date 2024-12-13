// 1
int[] num = { 2, 1, 4, 7, 8, 1, 4, 7, 6 };
int a = 0;
int b = 0;
int max = -99;
int NUM(int[] num)
{
    Array.Sort(num);

    int[] copyNum = new int[num.Length + 1];
    for (int i = 0; i < num.Length; i++)
    {
        a = 0;
        if (i == 0 || num[i] != num[i - 1])
        {
            for (int j = 0; j < num.Length; j++)
            {
                if (num[i] == num[j])
                {
                    a++;
                }
                copyNum[i + 1] = a;
                if (max < a)
                {
                    max = a;
                }


            }
        }
    }
    for (int i = 0; i < copyNum.Length; i++)
    {
        if (copyNum[i] == max)
        {
            b = i;
        }
    }
    return b;
}

Console.WriteLine($"Чаще всего встречается {NUM(num)}");
//2
int[] num1 = { 1, 2, 3, 4, 5 };
bool exit = false;
int ctrl = 1;
while (exit == false)
{
    if (ctrl == 1)
    {
        Console.WriteLine();
        foreach (int i in num1)
        {
            Console.Write(i + " ");
        }
    }
    Console.WriteLine("\nВведите 1, если хотите записать массив в столбик. Или 2, чтобы выйти.");
     ctrl = int.Parse(Console.ReadLine());
    if (ctrl >= 2)
    {
        break;
    }
    if (ctrl == 1)
    {
        Console.WriteLine();
        foreach (int i in num1)
        {
            Console.WriteLine(i);
        }
        ctrl = 0;
    }
    Console.WriteLine("Введите 1, если хотите записать массив в строчку. Или 2, чтобы выйти.");
    ctrl = int.Parse(Console.ReadLine());
    if (ctrl >= 2)
    {
        break;
    }
}