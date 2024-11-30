/* 1)
   int sum = 0;
   int[] num = { 1, 2, 3, 4, 5};
    for (int i = 0; i < num.Length; i++)
     {
       sum = sum + num[i];

        if (i == num.Length - 1)
         {
           Console.WriteLine(sum);
         } 

     }
    2)
     int[] num = { 1, 200, 3, 4, 5 };
     int max = num[0];
     for (int i = 1; i < num.Length; i++)
       {
          if (num[i] > max)
             {
               max = num[i];                
             }               
       }
     Console.WriteLine(max);
     3)
     int[] num = { 1, 2, 3, 4, 5};
     Array.Reverse(num);
     foreach (int a  in num)
        {
           Console.WriteLine(a);
         }
     4)
     int[] num = { 10, 21, 356, 423, 561 , 666, 811, 765};
     for (int i = 0; i < num.Length; i++)
       {
            if (num[i] % 2 == 0)
              {
                  Console.WriteLine(num[i]);
              }
       }
     5)
     int[] num = { -1, 24, -3, 45, -51 };
     int a = 0; 
     for (int i = 0; i < num.Length; i++)
       {
         if (num[i] < 0)
          {
             a++;
          }
       }
       Console.WriteLine(a);
    6)

int[] num = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
Console.WriteLine("Введите нужное вам число 1-10 ");        //Не совсем понял это задание. Наверно так
bool find = false;
int a = int.Parse(Console.ReadLine());
for (int i = 0; i < num.Length; i++)
{
    if (num[i] == a)
    {
        find = true;
    }
}
if (find == true)
{
   Console.WriteLine($"Число {a} найдено в массиве. ");
}
else if (find == false)
{
    Console.WriteLine($"Ваше число {a} не найдено в массиве.");
}

     7)
     int[] num = { 1, 2, 3, 4, 5, 6 };
     for (int i = 0; i < num.Length; i++)
       {
          if (i % 2 != 0)
        {
            Console.WriteLine(num[i]);
        }
       }
   8)
int[] num = { 1, 2, -3, 4, 5 ,-6};
int max = num[0];
int min = num[0];
for (int i = 1; i < num.Length; i++)
{
    if (num[i] > max)
    {
        max = num[i];
    }
    if (num[i] < min)
    {
        min = num[i];
    }
}
Console.WriteLine(max);
Console.WriteLine(min);
9)
int[] num = {1, 2, 3, 4, 5};
Array.Sort(num);
foreach (int a in num)
{
    Console.WriteLine(a);
}
10)
int[] num = { 1, -2, 3, -4, 5 };
for (int i = 0; i < num.Length; i++)
{
    if (num[i] > 0)
    {
        Console.WriteLine(num[i]);
    }
    else
    {
        Console.WriteLine(0);
    }
}
*/