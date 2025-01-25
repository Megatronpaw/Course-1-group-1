using System;
using System.Globalization;

class Emploee
{
    public string Name;
    public string Identification_number;
    public string Department;
    public string Post;
    
}

class Program
{
    static void Main()
    {
        var people1 = new Emploee();
        people1.Name = "Олег";
        people1.Identification_number = "12345";
        people1.Department = "Печатный отдел";
        people1.Post = "Журналист";

        var people2 = new Emploee();
        people2.Name = "Дима";
        people2.Identification_number = "2468";
        people2.Department = "Волонтерский отдел";
        people2.Post = "Волонтер";

        var people3 = new Emploee();
        people3.Name = "Ахмед";
        people3.Identification_number = "1357";
        people3.Department = "Военный отдел";
        people3.Post = "Военный";

        Console.WriteLine($"{people1.Name}\n{people1.Identification_number}\n{people1.Department}\n{people1.Post}");
        Console.WriteLine();
        Console.WriteLine($"{people2.Name}\n{people2.Identification_number}\n{people2.Department}\n{people2.Post}");
        Console.WriteLine();
        Console.WriteLine($"{people3.Name}\n{people3.Identification_number}\n{people3.Department}\n{people3.Post}");
    }
}