namespace PROG6221_ICE_TASK_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            //create a rectangle object
            Rectangle rectangle = new Rectangle("Rectangle", 5, 10);

            //display the area of the rectangle
            rectangle.DisplayArea();

            //create a circle object
            Circle circle = new Circle(5);

            //display the area of the circle
            circle.DisplayArea();

        }
    }
}
