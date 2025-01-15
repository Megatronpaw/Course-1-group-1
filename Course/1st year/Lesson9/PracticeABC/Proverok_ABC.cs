using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using static System.Net.Mime.MediaTypeNames;

    public class Person
{
    public string Name;
    public int Age;

    public Person(string name, int age)
    {
        this.Name = name;
        ProverokAge(age);
    }

    public void ProverokAge(int age)
    {
        if (age >= 0)
        {
            Age = age;
        }
        else
        {
            Console.WriteLine("Возраст указан неверно!");
        }
    }
    public void Introduce()
    {
        Console.WriteLine($"Привет, мое имя {Name}.");
    }
}
public class Employee : Person
{
    public string position;
    public Employee(string Name, int Age, string position) : base(Name, Age)
    {
        this.position = position;
    }
}
class Program
{
    static void Main(string[] args)
    {
        /*  1)
            Person person = new Person();
            person.Name = "Gleb";
            person.Age = 18;
        */
        Person[] student = new Person[2];
        student[0] = new Person("Ilya", 16);
        student[1] = new Person("Issac", 6);
        foreach (Person person in student)
        {
            person.Introduce();
        }
    }
}