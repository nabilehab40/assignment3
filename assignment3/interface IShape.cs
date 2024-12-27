using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3
{
    internal class @interface
    {
        public interface IShape
        {
            double Area { get; }
            void DisplayShapeInfo();
        }

        public class Circle : IShape
        {
            public double Radius { get; set; }

            public double Area => Math.PI * Radius * Radius;

            public void DisplayShapeInfo()
            {
                Console.WriteLine($"Circle: Radius = {Radius}, Area = {Area:F2}");
            }
        }


        public class Rectangle : IShape
        {
            public double Length { get; set; }
            public double Width { get; set; }

            public double Area => Length * Width;

            public void DisplayShapeInfo()
            {
                Console.WriteLine($"Rectangle: Length = {Length}, Width = {Width}, Area = {Area}");
            }
        }
    }
}
