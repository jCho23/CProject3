////Abstract Modifier = Indicates that a class or a member is missing implementation

#region Abstract Members
// Do not include implementation
// If a member is declared as abstract, the containing class needs to be declared as abstract too
// Cannot be instantiated

//public abstract class Shape
//{   
//    public abstract void Draw();
//}

//Dervived Classes
// Must implement all abstract members in the base abstract class
//public class Circle : Shape
//{
//    public override void Draw()
//    {
//        //Implementation for Circle
//    }
//}
#endregion

#region Why Use Abstract?
// When you want to provide some common behaviour, 
// while forcing other developers to follow your design
#endregion

using System;

namespace CProject3.Polymorphism
{
    public abstract class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public abstract void Draw();

        ////Notice, that we can't state "Drawing a Shape"
        /// In this case, we use "abstract" to indicate this Method is missing implementation
        /// and we leave it to the dervied classes to provide an implementation for this Method


         ////When declaring a class "abstract" note that you state it both in the class and method
        ////Thus "abstract" are inherently "virtual", thus providing polymorphic behavior

        public void Copy()
        {
            
        }

    }

    public class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a Circle");
        }
    }

    public class Rectangle : Shape
    {

    }

    public class AbstractClassesandMembers
    {
        static void Main(string[] args)
        {
            var circle = new Circle();
            circle.Draw();

            var rectangle = new Rectangle();
            rectangle.Draw();
        }
    }
}

