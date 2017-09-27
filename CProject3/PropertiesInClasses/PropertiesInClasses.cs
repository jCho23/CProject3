////Properties= A class member that encapsulates a getter/setter for accessing a field
//// Why do we need Properties? = To create a getter/setter with less code

using System;
namespace CProject3.PropertiesInClasses
{
    ////Fields Example
    public class Person
    {
        private DateTime _birthdate;

        public void SetBirthdate(DateTime birthdate)
        {
            this._birthdate = birthdate;
        }

        public DateTime GetBirthdate()
        {
            return _birthdate;
        }
    }

    ////Properties Example
    ////This is the same code as above
    //// Private Fields= Always prefixed by "_"  
    public class Person2
    {
        private DateTime _birthdate;

        //This is the Property
        //Notice that this Property is Public
        public DateTime Birthdate
        {
            //Here, we just return the field: _birthdate
            get
            {
                return _birthdate;
            }

            //We use the "value" keyword to get what is on the right side of the assignment
            set
            {
                _birthdate = value;
            }
        }
    }
}