using System;

namespace Prototype
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Rectangle rectangle = new Rectangle(1, 2, "Blue", 120, 130);
            Rectangle rectangleClone = (Rectangle)rectangle.Clone();
            Console.WriteLine("Cloned: {0} {1} {2} {3} {4}", rectangleClone.X, rectangleClone.Y, rectangleClone.Color, rectangleClone.Width, rectangleClone.Height);

            Circle circle = new Circle(2, 3, "Red", 10);
            Circle circleClone = (Circle)circle.Clone();
            Console.WriteLine("Cloned: {0} {1} {2} {3} ", circleClone.X, circleClone.Y, circleClone.Color, circleClone.Radius);


        }
    }


    public abstract class Shape
    {
        int x, y;
        string color;

        public Shape(int x, int y, string color)
        {
            this.x = x;
            this.y = y;
            this.color = color;
        }

        public string Color { get { return color; } }

        public int X { get { return x; } }

        public int Y { get { return y; } }

        public abstract Shape Clone();
    }

    public class Rectangle : Shape
    {
        int width, height;

        public Rectangle(int x, int y, string color, int width, int height) : base(x, y, color)
        {
            this.width = width;
            this.height = height;
        }

        public int Width { get { return width; } } 

        public int Height { get { return height; } }

        public override Shape Clone()
        {
            return (Shape)this.MemberwiseClone();
        }
    }

    public class Circle : Shape
    {
        double radius;

        public Circle(int x, int y, string color, double radius): base(x, y, color)
        {
            this.radius = radius;
        }

        public double Radius { get { return radius; } }

        public override Shape Clone()
        {
            return (Shape)this.MemberwiseClone();
        }
    }

}
