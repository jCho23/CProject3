////Constructor Inheritance
////* Base Class constructors are always executed first
////* Base Class constructors are not inherited 

using System;

namespace CProject3.Inheritances
{
    public class Vehicle
    {
        private readonly string _registrationNumber;

        ////Parameterless Constructor
        public Vehicle()
        {
            Console.WriteLine("Vehicle is being initialized");
        }

        ////Constructor passing a Parameter
        public Vehicle(string registrationNumber)
        {
            _registrationNumber = registrationNumber;
        }
    }

    ////Car Class deriving from Vehicle Class
    public class Car : Vehicle
    {
        ////We are using the "base" keyword to call one of the constructors in the Vehicle Class
        ////Notice, that we are receiving the registrationNumber and passing the result through base 
        public Car(string registrationNumber)
            :base(registrationNumber)
        {
            Console.WriteLine("Car is being initialized {0}", registrationNumber);
        }
    }

    public class ConstructorsAndInheritance
    {
        //static void Main(string[] args)
        //{
			////Here, we are creating a new car object
			////Notice, that we have to pass in a registrationNumber for this to compile
			//var car = new Car("JC2323");
        //}
    }
}
