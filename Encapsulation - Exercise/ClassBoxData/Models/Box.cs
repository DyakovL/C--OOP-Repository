using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBoxData.Models
{
    public class Box
    {

        private const string PropertyValueExceptionMessage = "{0} cannot be zero or negative.";

        public Box(double lenght, double width, double height)
        {
            Length = lenght;
            Width = width;
            Height = height;
        }
        private double length;

        public double Length
        {
            get => length;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(string.Format(PropertyValueExceptionMessage, nameof(Length)));
                }
                
                
                length = value;
            }
        }

        private double width;

        public double Width
        {
            get => width;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(string.Format(PropertyValueExceptionMessage, nameof(Width)));
                }
                
                width = value;
            }
        }

        private double height;

        public double Height
        {
            get => height;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(string.Format(PropertyValueExceptionMessage, nameof(Height)));
                }
                
                height = value;
            }
        }


        public double SurfaceArea() => 2 * Length * Width + LateralSurfaceArea();


        public double LateralSurfaceArea() => 2 * Length * Height + 2 * Width * Height;


        public double Volume() => Length * Width * Height;

    }
}
