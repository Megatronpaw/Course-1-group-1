/*
//  1
int[] num = { 1, 2, 4, 2, 5, 6, 7, 2, 1, };
bool SortProverk(int[] array, int a)
{
    if (array.Length == 0 || array.Length == 1)
    {
        return true;
    }
    if (array[a] > array[a + 1])
    {
        return false;
    }
    if (a == 0)
    {
        return true;
    }
    return SortProverk(array, a - 1);
}
Console.WriteLine(SortProverk(num, num.Length - 2));
//  2

int[] num = { 1, 2, 3, 4, 5, 2, 4, 5, 2, 2, 10, 7 };
int a = 2;
int b = -100;
int[] Zamen(int[] array, int zamen, int chet, int naChto)
{
if (chet == 0)
{
return array;
}
if (array[chet] == zamen)
{
array[chet] = naChto;
}
return Zamen(array, zamen, chet - 1, naChto);
}
foreach (int i in Zamen(num, a, num.Length - 1, b))
{
    Console.Write(i + " ");
    //}
    //   3
    int[] num = { 1, 3, 2, 69, 4, 5, 6, 10, 4, 3, 23, 81, 22, 31 };
string chet = "";
string nechet = "";

string Delenie(int[] array, int a)
{
    if (array[a] % 2 == 0)
    {
        chet = array[a].ToString() + " " + chet;
    }
    else
    {
        nechet = array[a].ToString() + " " + nechet;
    }
    if (a == 0)
    {
        return nechet;
    }
    Delenie(array, a - 1);
    return "Нечетные: " + nechet + "\nЧетные: " + chet;
}
Console.WriteLine(Delenie(num, num.Length - 1));
//  4
int[] num = { 1, 2, 3, 4, 5, 9, 8, 7, 6 };
int[] undernum = {5, 9};
int chet = 0;
bool ProvArray(int[] array1, int[] array2, int a)
{ 

    for (int i = 0; i < array2.Length; i++)
    {
      if ( a + i >= array1.Length)
        {
            return false;
        }
      if (array1[a + i] == array2[i])
        {
            chet++;
        }
      else
        {
            chet = 0;
        }
    }
    if (chet == array2.Length)
    {
        return true;
    }


    return ProvArray(array1, array2, a + 1);

}
Console.WriteLine(ProvArray(num,undernum,0));
*/
