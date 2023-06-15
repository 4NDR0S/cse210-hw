using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning05 World!");

        List<Shape> shapes = new List<Shape>();

        Square cuadrado1 = new Square("red",4);
        shapes.Add(cuadrado1);
        // Console.WriteLine(cuadrado1.GetColor());  // this print me red
        // Console.WriteLine(cuadrado1.GetArea());   // 4*4 = 16

        Rectangle rectangulo1 = new Rectangle("blue", 4, 3);
        shapes.Add(rectangulo1);
        // Console.WriteLine(rectangulo1.GetColor());  // blue
        // Console.WriteLine(rectangulo1.GetArea());   // 4*3 = 12

        Circle circulo1 = new Circle("yellow", 4);
        shapes.Add(circulo1);
        // Console.WriteLine(circulo1.GetColor());  // yellow
        // Console.WriteLine(circulo1.GetArea());   // 4 * 4 * PI 

        foreach (Shape s in shapes)
        {

            string color = s.GetColor();

            double area = s.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}.");
        }
    }
}