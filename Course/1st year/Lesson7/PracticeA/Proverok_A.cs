/*/  1 
int a = int.Parse(Console.ReadLine());
int Fact(int a)
{
    if (a == 1)
        return 1;
    return a * Fact(a - 1);
}
Console.WriteLine(Fact(a));
//  4
int[] num = { 7, 2, 2, 6, 3, 18 };
int MaxSum(int i)
{
    int max = num[i];
    if (i == 0)
    {
        return num[0];
    }
    return max + MaxSum(i - 1);
}
Console.WriteLine(MaxSum(num.Length-1));
// 2

int n = int.Parse(Console.ReadLine());
int a = 0;
int Fibba(int fib)
{
    if (n == 0)
        return 0;
    if (fib <= 0)
        return 1;
    return Fibba(fib - 1) + Fibba(fib - 2);
}
Console.WriteLine(Fibba(n));
//  3

string word = Console.ReadLine();
string StrRev(string str)
{
    if (str.Length > 0) 
    { 
        return str[str.Length - 1] + StrRev(str.Substring(0, str.Length - 1));
    }
    else
        return str;
}
Console.WriteLine(StrRev(word));
// 5
    
Console.WriteLine("Первое число");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Второе число");
int b = int.Parse(Console.ReadLine());
int NOD(int num1, int num2)
{
    if (num2 == 0)
        return num1;
    else
        return NOD(num2, num1 % num2);
}
Console.WriteLine(NOD(a,b));
//6

string word = Console.ReadLine();
string Proverk(string pal)
{
    if (StrRev(pal) == word)
    {
        return pal = "палидром";
    }
    return pal = "не палидром";
}
string StrRev(string str)
{
    if (str.Length > 0)
    {
        return str[str.Length - 1] + StrRev(str.Substring(0, str.Length - 1));
    }
    return str;
}
Console.WriteLine($"Данное слово {Proverk(word)}");
//  7

static void HonoyBash(int z, char a, char b, char c)
{
    if (z >= 1)
    {
        HonoyBash(z - 1, a, c, b);
        Console.WriteLine($"Перемещаем диск с {a} стержня на {b} стержень");
        HonoyBash(z - 1, c, b, a);
    };
}
HonoyBash(3, '1', '2', '3');
//  8

int[] num = {5,6,7,8,9};
static void Mnoh(int[] array, int ch, int[] arrray1, int size)
{
    if (ch == array.Length)
    {
        Console.Write("{");
        for (int i = 0; i < size; i++)
        {
            Console.Write($" {arrray1[i]}");
        }
        Console.WriteLine("}");
        return;
    }
    Mnoh(array, ch + 1, arrray1, size);
    arrray1[size] = array[ch];
    Mnoh(array, ch + 1, arrray1, size + 1);
}

Mnoh(num, 0, new int[num.Length], 0);
//  10

 string str = "abc";
char[] ch = str.ToCharArray();
    static void ChangeWord(char[] word, int a)
    {
        if (a == word.Length - 1)
        {
            Console.WriteLine(word);
            return;
        }
        for (int i = a; i < word.Length; i++)
        {
            char obm = word[a];
            word[a] = word[i];
            word[i] = obm;

        ChangeWord(word, a + 1);

            obm = word[a];
            word[a] = word[i];
            word[i] = obm;
        }
    }
ChangeWord(ch, 0);
*/