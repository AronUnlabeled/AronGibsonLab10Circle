using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AronGibsonLab10Circle
{

    class Circle
    {
        private double radius { get; set; }

        public Circle(double radius) {
            this.radius = radius;
        }
        public double CalculateCircumference() {
            return 2 * Math.PI * radius;
        }
        public string CalculateFormattedCircumference() {

            return FormatNumber(CalculateCircumference());
        }
        public double CalculateArea()
        {
            return Math.PI * radius * radius;
        }
        public string CalculateFormattedArea()
        {
            return FormatNumber(CalculateArea());
        }
        private string FormatNumber(double x) {
            return string.Format("{0:N2}",x);
        }
    }
}
