using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG6221_ICE_TASK_3
{
    //extends the shape class and implements the ICalculateArea interface
    class Rectangle : Shape, ICalculateArea
    {
        //create 2 properties for the length and width
        public double length { get; set; }
        public double width { get; set; }

        //create a constructor for the rectangle class
        //it takes in the name, length and width of the rectangle
        public Rectangle(string name, double l, double w) : base(name)
        {
            length = l;
            width = w;
        }

        //create a method to calculate the area of the rectangle
        public double Area()
        {
            return length * width;
        }

    }
}
