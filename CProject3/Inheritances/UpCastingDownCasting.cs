////UpCasting
Circle circle = new Circle();
Shape shape = circle;

////DownCasting
Circle anotherCircle = (Circle)shape;

////The "as" Keyword
Car car = object as Car;
if(car != null)
{
    ...
}




using System;
namespace CProject3.Inheritances
{
    public class UpCastingDownCasting
    {
        public UpCastingDownCasting()
        {
        }
    }
}
