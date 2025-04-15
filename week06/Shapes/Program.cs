using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> _shapes = new List<Shape>();

        Square s1 = new Square("red", 3);
        _shapes.Add(s1);

        Rectangle r1 = new Rectangle("blue", 4, 5);
        _shapes.Add(r1);

        Circle c1 = new Circle("Purple", 6);
        _shapes.Add(c1);

        foreach (Shape s in _shapes)
        {
            string color = s.GetColor();

            double area = s.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}.");
            
        }

    }
}