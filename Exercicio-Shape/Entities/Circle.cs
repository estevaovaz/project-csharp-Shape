using Exercicio_Shape.Entities.Enums;
using System;

namespace Exercicio_Shape.Entities
{
    public class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle() { }

        public Circle(Color color, double radius)
            : base(color)
        {
            Radius = radius;
        }
        public override double Area()
        {
            return Math.PI * (Radius * Radius);
        }
    }
}
