using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square(4.5);
        square.SetColor("green");
        Console.Write(square.GetArea());
        Console.WriteLine(" " + square.GetColor());

        Rectangle rectangle = new Rectangle(3.5, 4.5);
        rectangle.SetColor("red");
        Console.Write(rectangle.GetArea());
        Console.WriteLine(" " + rectangle.GetColor());

        Circle circle = new Circle(3.5);
        circle.SetColor("yellow");
        Console.Write(circle.GetArea());
        Console.WriteLine(" " + circle.GetColor());


        List<Shape> shapes = new List<Shape>();

        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach (Shape shape in shapes)
        {
            Console.Write(shape.GetArea());
            Console.WriteLine(" " + shape.GetColor());
        }

    }
}