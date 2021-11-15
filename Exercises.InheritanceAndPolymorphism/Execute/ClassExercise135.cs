using Exercises.Inheritance.Entities.Exercise135;
using Exercises.Inheritance.Enum;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Exercises.Inheritance.Execute
{
    public class ClassExercise135
    {
        /// <summary>
        /// Returns the area of ​​each figure
        /// </summary>
        public void ShapeAreas()
        {
            List<Shape> shapes = new List<Shape>();

            Console.Write("Enter the number of shapes: ");
            int total = int.Parse(Console.ReadLine());

            for (int i = 0; i < total; i++)
            {
                Console.WriteLine($"Shape #{i + 1} data:");
                Console.Write("Rectangle or Circle (r/c)? ");
                string type = Console.ReadLine();

                Console.Write("Color (Black/Blue/Red): ");
                Color color = (Color)System.Enum.Parse(typeof(Color), Console.ReadLine().ToUpper());

                if (type.ToUpper() == "R")
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    shapes.Add(new Rectangle(width, height, color));
                }
                else
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    shapes.Add(new Circle(radius, color));
                }
            }

            Console.WriteLine("\nSHAPE AREAS:");
            foreach (Shape shape in shapes)
            {
                Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
