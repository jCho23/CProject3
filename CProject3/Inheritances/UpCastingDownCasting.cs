﻿////UpCasting
//Circle circle = new Circle();
//Shape shape = circle;

////DownCasting
//Circle anotherCircle = (Circle)shape;

////The "as" Keyword
//Car car = obj as Car;
//if(car != null)
//{
//    ...
//}

////The "is" Keyword
////"is" Keyword checks the Type of the object
//if (obj is Car)
//{
//    Car car = (car)obj;
//}

using System;
namespace CProject3.Inheritances
{
    public class Shape
    {
        ////Here, we are creating two properties to define Shape Class
        public int Width { get; set; }
        public int Height { get; set; }

        ////Defining position
        public int X { get; set; }
        public int Y { get; set; }

        ////Method to draw the Shape
        public void Draw()
        {
            
        }



    }


    class UpCastingDownCasting
    {
        static void Main(string[] args)
        {

        }
    }
}
