using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Rectangle : Shape
    {
        private double height;
        private double width;

        public double Height { get => height; private set => height = value; }
        public double Width { get => width; private set => width = value; }

        public Rectangle(double height, double width)
        {
            this.Height = height;
            this.Width = width;
        }

        public override double CalculateArea()
        {
            return this.height * this.Width;
        }

        public override double CalculatePerimeter()
        {
            return 2 * (this.width + this.height);
        }

        public override string Draw() => base.Draw() + this.GetType().Name;
    }
}
