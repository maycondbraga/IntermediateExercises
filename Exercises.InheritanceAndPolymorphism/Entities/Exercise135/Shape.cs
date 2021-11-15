using Exercises.Inheritance.Enum;

namespace Exercises.Inheritance.Entities.Exercise135
{
    abstract class Shape
    {
        public Color Color { get; set; }

        public Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();
    }
}
