// 1)
int[] num1 = { 12, 43, 6, 82 , 13};
int[] num2 = { 23, 55, 77, 99 };
int[] num3 = new int[num1.Length+num2.Length];
int a = 0;
for (int i = 0; i < num1.Length; i++)
{
    num3[i] = num1[i];
    a++;
}
for (int j = 0; j < num2.Length; j++)
{
    num3[a + j] = num2[j];
}
foreach (int i in num3)
{
    Console.Write(i + " ");
}
// 2)
int[] num = { 1, 2, 3, 4, 5 };
Console.WriteLine("Введите число для изменения позиции вправо:");
int rot = int.Parse(Console.ReadLine());
for (int i = 0; i < rot; i++)
{
    int end = num[num.Length - 1];
    for (int j = num.Length - 1; j > 0; j--)
    {
        num[j] = num[j - 1];
    }
    num[0] = end;
}
foreach (int m in num)
{
    Console.WriteLine(m);
}