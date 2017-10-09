////Method Overriding = Modifiying the implementation of an inherited method

//public class Shape
//{
    ////Virtual= Ability to change this Methods' implementation in the dervied class
    //public virtual void Draw()
    //{
        ////Default implementation
//    }
//}

//public class Circle : Shape
//{
    ////Override= Changes the implementation of the Method above
    //public override void Draw()
    //{
        ////New implemenation
//    }
//}

//public class Image : Shape
//{

//}

using System;
using System.Collections.Generic;

namespace CProject3.Polymorphism

////Demo
{
    public class Circle : Shape
    {
        
    }

    public class Rectangle : Shape
    {
        
    }


    public class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public Position Position { get; set; }
        ////Since we defined the shapes above, we no longer need this enum
        //public ShapeType Type { get; set; }
    }

    public enum ShapeType
    {
        Circle,
        Rectangle
    }

    public enum Position
    {
    }

    public class Canvas
    {
        public void DrawShapes(List<Shape> shapes)
        {
            foreach (var shape in shapes)
            {
                switch (shape.Type)
                {
                    case ShapeType.Circle:
                        Console.WriteLine("Draw a Circle");
                        break;

                    case ShapeType.Rectangle:
                        Console.WriteLine("Draw a rectangle");
                        break;
                }
            }
        }
    }

   
}
