using System;
using System.Collections.Generic;
using System.Globalization;
public abstract class Shape
{
    public double Area;
    public double Perimetr;
    public abstract double GetArea();
    public abstract double GetPerimetr();

}
public class Circle : Shape
{
    public double Radius {  get; set; }
    public Circle(double radius) 
    { 
        Radius = radius;
    }
    public override double GetArea()
    {
        Console.WriteLine($"Площадь круга: {3.14 * Radius * Radius}");
        return 3.14 * Radius * Radius;
    }
    public override double GetPerimetr()
    {
        Console.WriteLine($"Периметр круга: {2 * 3.14 * Radius}");
        return 2 * 3.14 * Radius;
    }
    public double GetDiametr()
    {
        Console.WriteLine($"Диаметр круга: {2 * Radius}");
        return 2 * Radius;
    }
}
public class Rectangle : Shape
{
    public double Width {  get; set; }
    public double Height { get; set; }
    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }
    public override double GetArea()
    {
        Console.WriteLine($"Площадь прямоугольника: {Height * Width}");
        return Height * Width;
    }
    public override double GetPerimetr()
    {
        Console.WriteLine($"Периметр прямоугольника: {2 * (Height + Width)}");
        return 2 * (Height + Width);
    }
}
public class Triangle : Shape
{
    public double Height { get; set; }
    public double Base { get; set; }
    public double A { get; set; }
    public double B { get; set; }
    public double C { get; set; }
    public Triangle(double a , double b, double c, double height, double the_base)
    {
        Height = height;
        Base = the_base;
        A = a;
        B = b;
        C = c;
    }
    public override double GetArea()
    {       
        Console.WriteLine($"Площадь треугольника: {0.5 * Height * Base}");
        return 0.5 * Height * Base;

    }
    public override double GetPerimetr()
    {     
        Console.WriteLine($"Периметр треугольника: {A + B + C}");
        return A + B + C;
    }
}
class Program
{
    static void Main()
    {
        List<Shape> shapes = new List<Shape>
        { new Circle(3),
          new Rectangle(5,6),       
          new Triangle( 5, 4, 3, 5, 8), 
        };

        foreach (var shape in shapes)
        {
            shape.GetArea();
            shape.GetPerimetr();
            if (shape is Circle circle)
            {
               circle.GetDiametr();
            }
            Console.WriteLine();
        }

    }
}