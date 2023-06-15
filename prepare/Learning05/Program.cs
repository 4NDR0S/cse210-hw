using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!");

        Square cuadrado1 = new Square("rojo",4);
        cuadrado1.GetColor();
        cuadrado1.GetArea();

        Console.WriteLine(cuadrado1.GetColor());
        Console.WriteLine(cuadrado1.GetArea());
    }
}