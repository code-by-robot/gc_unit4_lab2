using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleObjects
{
    internal class Circle
    {
        private double Radius;

        //Constructor
        public Circle(double _radius)
        {
            Radius = _radius;
        }

        //Methods
        public double CalculateCircumfrence()
        {
            return 2 * Radius * Math.PI;
        }

        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }

        private string FormatNumber(double x)
        {
            return Math.Round((double)x, 2).ToString();
        }

        public string CalculateFormattedCircumfrence()
        {
            double circ = CalculateCircumfrence();
            return FormatNumber(circ);
        }

        public string CalculateFormattedArea()
        {
            double area = CalculateArea();
            return FormatNumber(area);
        }
    }
}
