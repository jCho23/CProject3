////Abstract Modifier = Indicates that a class or a member is missing implementation

#region Abstract Members
// Do not include implementation
// If a member is declared as abstract, the containing class needs to be declared as abstract too

//public abstract class Shape
//{   
//    public abstract void Draw();
//}


#endregion

public class Shape
{
    public virtual void Draw()
    {
        ////Notice, that we can't state "Drawing a Shape"
        /// In this case, we use "abstract" to indicate this Method is missing implementation
        /// and we leave it to the dervied classes to provide an implementation for this Method
    }

    ////When declaring a class "abstract" note that you state it both in the class and method
    ////Thus "abstract" are inherently "virtual", thus providing polymorphic behavior
    public abstract class Shape
    {
        public abstract void Draw();
    }
}

public class Circle : Shape
{
    public override void Draw()
    {
        System.Console.WriteLine("Drawing a Circle");
    }
}

using System;
namespace CProject3.Polymorphism
{
    public class AbstractClassesAndMembers
    {
        public AbstractClassesAndMembers()
        {
        }
    }
}
