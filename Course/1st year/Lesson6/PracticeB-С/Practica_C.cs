int[] num = { 1, 3, 5};
static void ChangeNum(int[] array, int a)
{
    if (a == array.Length - 1)
    {
        
        foreach (int i in array)
        {
            Console.Write(i+ " ");
        }
        Console.WriteLine("\n");
        return;
    }
    for (int i = a; i < array.Length; i++)
    {
        int obm = array[a];
        array[a] = array[i];
        array[i] = obm;
        ChangeNum(array, a + 1);
        obm = array[a];
        array[a] = array[i];
        array[i] = obm;
    }
}
ChangeNum(num, 0);