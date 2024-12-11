//  1
int Sum(int a, int b)
{
    return a + b;
}
Console.WriteLine(Sum(1, 3));
//  2
string Name(string name)
{
    return name;
}
Console.WriteLine($"Привет! {Name(Console.ReadLine())}");
//  3
int Big(int a, int b)
{
    if (a > b)
    {
        return a;
    }
    else
    {
        return b;
    }
}
Console.WriteLine(Big(52, 42));
//  4
string Chet(int num)
{
    if (num % 2 == 0)
    {
        return "true";
    }
    return "false";
}
Console.WriteLine(Chet(12));


// 5
double Forenget(double a)
{
    a = (1.8 * a) + 32;
    return a;
}
Console.WriteLine(Forenget(20));
//  6
string Obrt(string str)
{
    string ans = "";
    for (int i = str.Length - 1; i >= 0; i--)
    {
        ans = ans + str[i];

    }
    return ans;
}
Console.WriteLine(Obrt("шытревереП"));
//  7
int Str(string str)
{
    int col = str.Length;
    return col;
}
Console.WriteLine(Str("Ответ:7"));
//  8
int Factarial(int a)
{
    int b = 1;
    for (int i = a; i > 0; i--)
    {
        b = b * i;
    }
    return b;
}
Console.WriteLine(Factarial(6));
//   9
string SimpleNum(int a)
{
    int b = 0;
    for (int i = 2; i < a; i++)
    {
        if (a % i == 0)
        {
            b++;
        }
    }
    if (b == 0)
    {
        return "Число простое";
    }
    else
    {
        return "Число не простое";
    }

}
Console.WriteLine(SimpleNum(13));
//  10

int Rand(int a, int b)
{   
    Random rand = new Random();
   return rand.Next(a, b);
}

Console.WriteLine(Rand(5,10));