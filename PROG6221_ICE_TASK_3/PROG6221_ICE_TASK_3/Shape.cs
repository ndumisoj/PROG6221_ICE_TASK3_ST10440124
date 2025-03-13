using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG6221_ICE_TASK_3
{
    class Shape
    {
        //create a property for the name
        public string shapeName { get; set; }

        //create a constructor for the shape class
        public Shape(string name)
        {
            shapeName = name;
        }

        //create a method to display the shape name
        public virtual void DisplayShape()
        {
            Console.WriteLine("The shape is: " + shapeName);
        }

    }
}
