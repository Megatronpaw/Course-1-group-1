using System;
//using System.ComponentModel.DataAnnotations;
//using System.Runtime.CompilerServices;
//using static System.Net.Mime.MediaTypeNames;
using System.IO;
public class Person
{
    public string Name;
    public int Age;
    public string line;
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
    public string Introduce(string line)
    {
        line = $"Привет, мое имя {Name}.";
        return line ;
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
    static void WritteFile() // Сохраняет в md формате сразу B и C сделал.
    {
        /*  1)
            Person person = new Person();
            person.Name = "Gleb";
            person.Age = 18;
        */
        Person person = new Person("", 0);
        Person[] student = new Person[3];
        student[0] = new Person("Ilya", 16);
        student[1] = new Person("Issac", 6);
        student[2] = new Employee("Samson", 42, "Warrior");
        string[] Pers = new string[3];
        int i = 0;

      foreach (Person persona in student)
        {
            Pers[i] = persona.Introduce("");
            i++;
        }
        i= 0;
        
        File.WriteAllLines("Persons.md", Pers);
    }

    static void ReadFile()
    {
        string[] line = File.ReadAllLines("Persons.md"); 
        foreach (string i in line)
        {
            Console.WriteLine(i);
        }
    }
    static void Main(string[] args) 
    {
        WritteFile();
        ReadFile();
    }
}
