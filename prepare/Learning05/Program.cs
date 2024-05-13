using System;
using System.Drawing;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square square = new Square("Red", 4);
        shapes.Add(square);

        Rectangle rectangle = new Rectangle("Green", 5, 6);
        shapes.Add(rectangle);

        Circle circle = new Circle("Blue", 7);
        shapes.Add(circle);

        foreach (Shape shape in shapes) {
            string color = shape.GetColor();
            double area = shape.GetArea();

            Console.WriteLine($"Color:{color} | Area:{area}");
        }
    }
}