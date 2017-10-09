////UpCasting
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
using System.Collections;
using System.IO;

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

    ////This Text Class is inheriting from Shape Class
    public class Text : Shape
    {
        public int FontSize { get; set; }
        public string FontName { get; set; }
    }

    class UpCastingDownCasting
    {
        ////Upcasting Demo
        //static void Main(string[] args)
        //{
            ////Creating an object of Text
            ////Notice that the text object has more options than the Shape object 
            //Text text = new Text();

			////Upcasting 
        //    Shape shape = text;

        //    text.Width = 200;
        //    shape.Width = 100;

        //    Console.WriteLine(text.Width);
        //}

        ////StreamReader= read data from any string from any kind
        static void Main(string[] args)
        {
            ////We can pass any object that derives from the Stream Class
            StreamReader reader = new StreamReader(new MemoryStream());

            ////Array list= Store objects in a list
            var list = new ArrayList();
            ////We can pass any object here since object is the base class for all classes
            list.Add(1);
            list.Add("June");
            list.Add(new Text());


        }
    }
}
