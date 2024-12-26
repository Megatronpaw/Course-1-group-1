using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

class Person
{
    public string Name;
    public int Age;

    public Person(string name, int age)
    {
       Name = name;
       Age = age;  
    }

    public int ProverokAge(int age) // Отрицательный возраст менятся на противоположный. Если не так надо напишите, что надо пожалйста. 
    {
        if (age < 0)
        {
            return -age; 
        }
        return age;
    }
    public void Introduce(string name, int age)
    {
        Console.WriteLine($"Привет, мое имя {name}, мне {ProverokAge(age)}.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите имя 1 человека.");
        string namePerson1 = Console.ReadLine();
        Console.WriteLine("Введите его возраст.");
        int agePerson1 = int.Parse(Console.ReadLine());
        Person person1 = new Person(namePerson1, agePerson1);

        Console.WriteLine("Введите имя 2 человека.");
        string namePerson2 = Console.ReadLine();
        Console.WriteLine("Введите его возраст.");
        int agePerson2 = int.Parse(Console.ReadLine());
        Person person2 = new Person(namePerson2, agePerson2);

        Console.WriteLine("Введите его имя 3 человека.");
        string namePerson3 = Console.ReadLine();
        Console.WriteLine("Введите возраст.");
        int agePerson3 = int.Parse(Console.ReadLine());
        Person person3 = new Person(namePerson3, agePerson3);

        Person[] people = { person1, person2, person3 };

        for (int i = 0; i < people.Length; i++)
        {
            if (i == 0)
            {
                person1.Introduce(namePerson1, agePerson1);
            }
            else if (i == 1)
            {
                person2.Introduce(namePerson2, agePerson2);
            }
            else if (i == 2)
            {
                person3.Introduce(namePerson3, agePerson3);
            }
        }

    }
}