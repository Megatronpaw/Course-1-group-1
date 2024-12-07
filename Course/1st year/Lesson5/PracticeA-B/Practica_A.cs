/*  1)
   
int N = int.Parse(Console.ReadLine()); 
int[] num = {-3, 4, 9, -5, 8, 1, 6, 0, -7};
int[] num2 = new int[N];
int[] result = new int[N];
int a = 0;
int maxSum = -52;
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

foreach (int i in result)
{
    Console.Write(i + " ");
} 
// 2)


int[] num = { 1, 3, 6, 3, 2, 5, 4, 7, 6, 3, 1, 4};
Array.Sort(num);
int unic = 0;
int a = 0;
for (int i = 0; i < num.Length; i++)
{
    for (int j = 0; j < num.Length; j++)
    {
        if (num[i] == num[j])
        {
            a++;
        }
        if (a == 1 && j == num.Length - 1)
        {
            unic++;
        }
        if (j == num.Length - 1)
        {
            a = 0;
        }
        
    }
}
foreach (int i in num)
{
    Console.Write(i + " ");
}
Console.WriteLine($"\n{unic}");

//    3) 

int[] num = { 1, 1, 1, 5, 5, 5};

Array.Sort(num);
int Kol = 0;
int a = 0;
int b = 0;
int[] res = new int[num.Length];
for (int i = 0; i < num.Length; i++)
{
    if (i < num.Length - 1)
    {
        if (num[i] == num[i + 1])
        {
            for (int j = 0; j < num.Length; j++)
            {
                if (num[i] == num[j])
                {
                    a++;

                }
                if (j == num.Length - 1)
                {
                    if (Kol == a)
                    {
                        
                       for (int k = 0; k < a; k++)
                        {   
                            if (res[res.Length - 1] == 0)
                            {
                                res[b] = num[i];
                                b++;
                            }
                        }
                        
                        
                    }
                    if (Kol < a)
                    {
                        Kol = a;
                    }
                    a = 0;
                }

            }
        }
    }
}
Console.WriteLine("Самые частые:");
foreach (int i in res)
{
    Console.Write(i + " ");
}
Console.WriteLine($"\nВ количестве {Kol} шт.");
*/