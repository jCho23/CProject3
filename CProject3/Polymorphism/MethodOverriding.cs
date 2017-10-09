////Method Overriding = Modifiying the implementation of an inherited method

public class Shape
{
    public virtual void Draw()
    {
        ////Default implementation
    }
}

public class Circle : Shape
{
    public override void Draw()
    {
        ////New implemenation
    }
}

public class Image : Shape
{

}

using System;
namespace CProject3.Polymorphism
{
    public class MethodOverriding
    {
        public MethodOverriding()
        {
        }
    }
}
