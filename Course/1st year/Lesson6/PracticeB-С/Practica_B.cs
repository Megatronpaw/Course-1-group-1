int[] num = { -3, 4, 9, -5, 8, 1, 5, 3, -7 };
int N = 0;
Console.WriteLine("Введите величину подмассива");
int Enter = int.Parse(Console.ReadLine());
if (Enter < num.Length)
{
    N = Enter;
}
else
{
    N = num.Length;
}
int maxSum = -52;
int[] MaxSumArray(int[] array)
{
    int[] num2 = new int[N];
    int[] result = new int[N];
    int a = 0;
    for (int i = 0; i <= num.Length - N; i++)
    {
        for (int j = 0; j < N; j++)
        {
            a += num[i + j];
            num2[j] = num[i + j];

        }
        if (maxSum < a)
        {
            maxSum = a;
            for (int k = 0; k < N; k++)
            {
                result[k] = num2[k];
            }
        }
        a = 0;
    }
    return result;
}
Console.Write("Подмассив: ");
foreach (int i in MaxSumArray(num))
{
    Console.Write(i + " ");
}
Console.WriteLine($"\nСумма равна: {maxSum}");