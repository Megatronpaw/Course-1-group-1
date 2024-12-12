using System;

int[] num = { 1, 2, 0, 5, 1, 0, 0, 0, 1, 1, 2, 0, 0 };
bool win = false;
int curNum = 0;
int a = 0;
int shag = 0;

for (int i = 0; i < num.Length;)
{

    curNum = num[i];

    if (curNum == 0)
    {
        i = num.Length;
        break;
    }

    a = i + curNum;

    if (a >= num.Length - 1)
    {
        shag++;
        win = true;
        break;
    }
    if (num[i] >= num.Length - 1)
    {
        shag++;
        win = true;
        break;
    }
    i = a;

    if (i <= num.Length - 1)
    {
        shag++;
    }

}

if (win)
{
    Console.WriteLine($"Данный массив можно пройти! Минимальное количество шагов: {shag}");
}
else
{
    Console.WriteLine("Данный массив невозможно пройти");
}
