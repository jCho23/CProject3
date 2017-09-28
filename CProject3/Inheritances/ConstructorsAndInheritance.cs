﻿////Constructor Inheritance
////* Base Class constructors are always executed first
////* Base Class constructors are not inherited 

using System;

namespace CProject3.Inheritances
{
    public class Vehicle
    {
        ////Parameterless Constructor
        public Vehicle()
        {
            Console.WriteLine("Vehicle is being initialized");
        }
    }

    ////Car Class deriving from Vehicle Class
    public class Car : Vehicle
    {
        public Car()
        {
            Console.WriteLine("Car is being initialized");
        }
    }


    public class ConstructorsAndInheritance
    {
        static void Main(string[] args)
        {
            
        }
    }
}
