using ConsoleApp.ClassesDemo.Interfaces;

namespace ConsoleApp.ClassesDemo.Classes.ShapeDemo
{
    public partial class Cuboid : Polygon, I2DShape, I3DShape
    {
        public Cuboid(double length, double width, double height)
        {
            Length = length;
            Width = width;
            Height = height;
        }
        public double Length { get; set; }
        public double Height { get; set; }
        public override double Area()
        {
            return 2 * (Length * Width) + Height * Length + Width * Height;
        }

        public double Perimeter()
        {
            return 4 * (Length + Width + Height);
        }

        public double Volume()
        {
            return Length * Width * Height;
        }
    }
}

