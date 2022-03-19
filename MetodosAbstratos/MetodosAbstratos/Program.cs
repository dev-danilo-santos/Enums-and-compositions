using System;
using System.Collections.Generic;
using MetodosAbstratos.Entities;
using MetodosAbstratos.Enums;

namespace MetodosAbstratos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> ListShapes = new List<Shape>();

            Console.Write("Enter the number shapes: ");
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine($"Shape {i+1} data.");
                Console.Write("Rectangle or Circle(r/c)? ");
                string type = Console.ReadLine().Trim().ToLower();
                Console.Write("Color (black, blue or red)");
                Color c = Enum.Parse<Color>(Console.ReadLine());

                if (type.Equals("r")) {
                    Console.Write("Width: ");
                    double w = double.Parse(Console.ReadLine());
                    Console.Write("Height: ");
                    double h = double.Parse(Console.ReadLine());
                    Shape s = new Retangle(w, h, c);
                    ListShapes.Add(s);
                }
                else
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine());
                    Shape s = new Circle(radius, c);
                    ListShapes.Add(s);
                }

            }
            Console.WriteLine("Shape Areas: ");
            ListShapes.ForEach(x => Console.WriteLine(x.Area().ToString("F2")));

        }
    }
}
