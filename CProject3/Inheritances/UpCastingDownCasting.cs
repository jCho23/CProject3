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
using System.Collections.Generic;
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

    ////Upcasting is implicit
    class UpCasting
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

        ////Upcasting Demo2
        ////StreamReader= read data from any string from any kind
        //static void Main(string[] args)
        //{
            ////We can pass any object that derives from the Stream Class
            //StreamReader reader = new StreamReader(new MemoryStream());

            ////Array list= Store objects in a list
            //var list = new ArrayList();
            ////We can pass any object here since object is the base class for all classes
            //list.Add(1);
            //list.Add("June");
            //list.Add(new Text());

            ////Generic Classes
            ////Notice that "< >" sets the type of the list 
        //    var anotherList = new List<int>();
        //    var anotherList2 = new List<Shape>();
        //}
    }

    ////Downcasting to convert an object to a more specific type to use more properties or methods
    class Downcasting
    {
        ////Downcasting Demo 1
        //static void Main(string[] args)
        //{
            ////We created a new Shape object and assigned it to Text
            ////Thus, at runtime it will be type Text 
            //Shape shape = new Text();

            ////Here, we are downcasting the Text object to acess its properties
            //Text text = (Text)shape;
            ////Now, we have access to all the properties of the text object
        //}

        ////DownCasting Demo 2
        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
            ////The "as" Keyowrd is used when we don't know the runtime type of an object
            //var button = sender as button;
            //if (button != null)
            //{
                
            //}

        //}
    }
}
