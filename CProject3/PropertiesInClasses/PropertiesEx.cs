using System;
namespace CProject3.PropertiesInClasses
{
	public class Person
	{
		////We are creating another Auto-Implemented property
		////Code Snippet= "prop"
		////Notice that we put all the properties at the TOP, the we have the Constructor

		public string Name
		{
			get;
			set;
		}

		public string UserName
		{
			get;
			set;
		}

		//Here we are creating an Auto-Implemented property without any fields
		//Note, that the compiler will create internally create a private field 
		//And implements the "get" and "set" Accessor Methods
		////Notice that we are using a "Private" set here to ensure that the Birthday is only set once
		public DateTime Birthdate { get; private set; }



		//We are creating a Constructor here to access the Private Set below
		//Here, we are setting the dateTime parameter, which is "birthdate"
		public Person(DateTime birthdate)
		{
			//We are setting the "birthdate" property 
			Birthdate = birthdate;
		}

		//We are creating a property called "age"
		//This property cannot be Auto-Implemented because we need some logic
		//We want the Age to be based on person
		public int Age
		{
			get
			{
				//When you subtract Two Datetime Objects you get a Time-Span
				var timeSpan = DateTime.Today - Birthdate;

				//This will give you the total number of years
				var years = timeSpan.Days / 365;

				return years;
			}
			//Notice that we are not using the "set" method here becuase it doesn't make sense to set someone's birthday
		}
	}

	//public class PropertiesEx
	//{
	//static void Main(string[] args)
	//{
	////Here, we are creating an Instance of the Person class
	//var person = new Person();

	////We need to create a constructor for this Person Class
	////Where we get the Birthdate and the property can no longer be changed
	////Note we are creating the Constructor above
	//person.Birthdate = new DateTime(1990, 1, 1);
	//Console.WriteLine(person.Age);

	//Since we created a constuctor to access the Private Set, we are refactoring the code above to work
	//        var person = new Person(new DateTime(1982, 1, 1));
	//        Console.WriteLine(person.Age);
	//    }

	//}
}