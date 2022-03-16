using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMLtoProject
{
    class _3DObject
    {
        public double Heigth { get; set; }
        public double Length { get; set; }
        public double Width { get; set; }
        public double Weigth { get; set; }
        public _3DObject(double height,double length,double width,double weigth)
        {
            Heigth = height;
            Length = length;
            Width = width;
            Weigth = weigth;
        }
        public _3DObject(double height, double length, double width) : this(height, length, width, 1)
        {

        }
        public double GetVolume()
        {
            return Heigth * Width * Length;
        }
    }
}
