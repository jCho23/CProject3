////BlackBox = Limited visiblity from the outside-->Make Classes like this

////Access Modifiers
////* public = Accessible from everywhere
////* private = Accessible only from the Class
////* protected = Accessible only from the Class and its derived Classes (breaks encapsulation)
////* internal = Accessible only from the same assembly
////* protected internal = Accessible only from the same assebly or any derived Classes     

using System;
namespace CProject3.Inheritances
{
    public class Customer
    {
        ////Here, we are defining Properties of the Customer Class
        public int Id { get; set; }
        public string Name { get; set; }

        public void Promote()
        {
            
        }
    }


    class AccessModifiers
    {
        static void Main(string[] args)
        {
            
        }
    }
}
