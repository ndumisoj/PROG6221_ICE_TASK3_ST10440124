using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG6221_ICE_TASK_3
{
    //extends the shape class and implements the ICalculateArea interface
    class Circle : Shape, ICalculateArea
    {
        //private field to store the radius of the circle
        private double radius;

        //constructor to initialize the radius of the circle
        public Circle(double radius)
        {
            this.radius = radius;
        }

        //method to calculate the area of the circle
        public double CalculateArea()
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        //method to display the area of the circle
        public void DisplayArea()
        {
            Console.WriteLine("The area of the circle is: " + CalculateArea());
        }
    }
    

    
}
