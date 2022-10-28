using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cuboid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            cuboid acuboid = new cuboid();
            acuboid.showallproperties();
            acuboid.height = 10;
            acuboid.width = 40;
            acuboid.showallproperties();
            cuboid cuboid2 = new cuboid(30,40,55);
            cuboid2.showallproperties();
            cuboid2.width = 50;
            cuboid2.showallproperties();
            Console.WriteLine("volume of the cuboid2 ={0}", cuboid2.volume());
            Console.ReadKey();
        }
    }
    class cuboid
    {
        private double _height;
        private double _length;
        private double _width;
        public double height //{ get; set; }
      {
            set { _height = value; }
            get { return _height; }
        }
        public double length //{ get; set; }
        {
            set { _length = value; }
            get { return _length; }
        }
        public double width //{ get; set; }
        {
            set { _width = value; }
            get { return _width; }
        }

        public cuboid()
        {
            height = 0;
            length = 0;
            width = 0;
        }
        public cuboid(double _height, double _length, double _width)
        {
            height= _height;
            length= _length;
            width= _width;
        }
        public void showallproperties()
        {
            Console.WriteLine("height={0},length={1},width={2}", height, length, width);
        }

        public double volume()
        {
            return _height * _length * _width;
        }
    }
}
