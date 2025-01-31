using System;
using System.Collections.Generic;
using System.Globalization;

class Shape
{
    public double Area;
    public double Perimetr;
    public void GetArea()
    {

    }
    public void GetPerimetr()
    {

    }
}

class Circle : Shape
{
    public double Diametr;
    public void GetArea(int radius)
    {
       Area = 3.14 * radius * radius;
        Console.WriteLine(Area);
    }
    public void GetPerimetr(int radius)
    {
       Perimetr = 2 * 3.14 * radius;
        Console.WriteLine(Perimetr);
    }
    public void GetDiametr(int radius)
    {
        Diametr = 2 * radius;
        Console.WriteLine(Diametr);
    }

}
class Rectangle : Shape
{
    public void GetArea(int hight, int width)
    {
       Area = hight * width;
        Console.WriteLine(Area);
    }
    public void GetPerimetr(int hight, int width)
    {
       Perimetr = 2 * (hight + width);
        Console.WriteLine(Perimetr);
    }

}
class Triangle : Shape
{
    public void GetArea(int hight, int the_base)
    {
        Area = 0.5 * hight * the_base;
        Console.WriteLine(Area);
    }
    public void GetPerimetr(int a, int b, int c)
    {
        Perimetr = a + b + c;
        Console.WriteLine(Perimetr);
    }

}

class Program
{
    static void Main()
    {
        Circle circle = new Circle();
        Rectangle rectangle = new Rectangle();
        Triangle triangle = new Triangle();

        Console.WriteLine("Площадь круга:");
        circle.GetArea(5);
        Console.WriteLine("Периметр круга:");
        circle.GetPerimetr(5);
        Console.WriteLine("Диаметр круга:");
        circle.GetDiametr(5);
        Console.WriteLine("");

        Console.WriteLine("Площадь прямоугольника:");
        rectangle.GetArea(5, 3);
        Console.WriteLine("Периметр прямоугольника:");
        rectangle.GetPerimetr(5, 3);
        Console.WriteLine("");

        Console.WriteLine("Площадь треугольник:");
        triangle.GetArea(5, 4);
        Console.WriteLine("Периметр треугольник:");
        triangle.GetPerimetr(5, 4, 3);

    }
}