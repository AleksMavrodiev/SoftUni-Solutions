namespace P01.ClassBoxData
{
    using System;
    using System.Text;
    public class Box
    {
        private double length;
        private double width;
        private double height;
        private const string ErrorMessage = "{0} cannot be zero or negative.";

        public Box(double length, double width, double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }

        public double Length 
        {
            get
            {
                return this.length;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(String.Format(ErrorMessage, nameof(this.Length)));
                }
                this.length = value;
            } 
        }

        public double Width 
        {
            get
            {
                return this.width;
            }
            set 
            {
                if (value <= 0)
                {
                    throw new ArgumentException(String.Format(ErrorMessage, nameof(this.Width)));
                }
                this.width = value;
            } 
        }

        public double Height 
        { 
            get
            {
                return this.height;
            } 
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(String.Format(ErrorMessage, nameof(this.Height)));
                }
                this.height = value;
            } 
        }

        public double SurfaceArea()
        {
            return (2 * length * width) + (2 * length * height) + (2 * width * height);
        }

        public double LateralSurfaceArea()
        {
            return (2 * this.Length * this.Height) + (2 * this.Width * this.Height);
        }

        public double Volume()
        {
            return this.Width * this.Height * this.Length;
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine($"Surface Area - {SurfaceArea():F2}");
            output.AppendLine($"Lateral Surface Area - {LateralSurfaceArea():F2}");
            output.AppendLine($"Volume - {Volume():F2}");

            return output.ToString().TrimEnd();
        }
    }
}
