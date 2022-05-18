using System;
using System.Collections.Generic;
using System.Text;

namespace _2._1_ClassBoxData
{
    public class Box
    {
        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            Length = length;
            Width = width;
            Height = height;
        }

        public double Length
        {
            get
            {
                return length;
            }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Length cannot be zero or negative.");
                }

                length = value;
            }
        }

        public double Width
        {
            get
            {
                return width;
            }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Width cannot be zero or negative.");
                }

                width = value;
            }
        }

        public double Height
        {
            get 
            { 
                return height; 
            }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Height cannot be zero or negative.");
                }

                height = value;
            }
        }

        public double SurfaceArea()
        {
            return (2 * Length * Width) + (2 * Length * Height) + (2 * Width * Height);
        }

        public double LateralSurfaceArea()
        {
            return (2 * Length * Height) + (2 * Width * Height);
        }

        public double Volume()
        {
            return Length * Height * Width;
        }
    }
}
