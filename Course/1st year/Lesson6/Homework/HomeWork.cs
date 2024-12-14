// 1
using System;

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
int[,] matrix =
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 },
            };
int[,] transposed = Transposed(matrix);
PrintMatrix(transposed);

int[,] Transposed(int[,] matrix)
{
    int rows = matrix1.GetLength(0);
    int cols = matrix1.GetLength(1);
    int[,] result = new int[cols, rows];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            result[j, i] = matrix1[i, j];
        }
    }
    return result;
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix2.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            Console.Write(matrix2[i, j] + " ");
        }
        Console.WriteLine();
    }
}