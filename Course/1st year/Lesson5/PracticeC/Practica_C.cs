int[] num = { 2, 0, 1, 3, 4, 0, 1 };
bool win = false;
int b = 0;
int curNum = 0;
int a = 0;

for (int i = 0; i < num.Length;)
{
    
    curNum = num[i];

    if (curNum == 0)
    {
        i = num.Length;
        b++;
    }

    a = i + curNum;

    if (a >= num.Length - 1 && b == 0)
    {
        win = true;
    }

    i = a;
}

if (win)
{
    Console.WriteLine("Данный массив можно пройти!");
}
else
{
    Console.WriteLine("Данный массив невозможно пройти");
}
