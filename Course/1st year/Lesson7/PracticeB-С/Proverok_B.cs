int[] num = { 34, 7, 23, 32, 5, 62 };

Console.WriteLine("Исходный массив:");
foreach (int i in num)
{
    Console.Write(i + " ");
}
int[] QuickSort(int[] arr, int beg, int fin)
{
    if (beg < fin)
    {
        int ras = arr[fin];
        int i = beg - 1;

        for (int j = beg; j < fin; j++)
        {
            if (arr[j] < ras)
            {
                i++;
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }
        int a = arr[i + 1];
        arr[i + 1] = arr[fin];
        arr[fin] = a;

        int b = i + 1;

        QuickSort(arr, beg, b - 1);
        QuickSort(arr, b + 1, fin);
    }
    return arr;
}
Console.WriteLine("\nОтсортированный массив:");
foreach (int i in QuickSort(num, 0, num.Length - 1))
{
    Console.Write(i + " ");
}

