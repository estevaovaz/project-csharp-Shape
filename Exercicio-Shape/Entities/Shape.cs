using Exercicio_Shape.Entities.Enums;


namespace Exercicio_Shape.Entities
{
    public abstract class Shape
    {
        public Color Color { get; set; }

        public Shape(Color color)
        {
            Color = color;
        }

        public Shape() { }

        public abstract double Area();
        

    }
}
