////Indexers = A way to access elements in a calss that represents a list of values

////Demo1
//var array = new int[5];
////This is an Indexer
////Notice that we can call the first number of the Index here 
//array[0]= 1;

////Demo2
////Here, we have a list of int
//var list = new List<int>();
////Again, using a Indexer, we can access the first element in the list
//list[0]= 1;

////Collection Semantics is one of the reasons for Indexers
////HttpCookie= A file that is sent from your browser to the WebServer upon each Request
////This file identifies the user and we can set those Parameters

////Here, we are creating a new Instance of the HttpCookie Class
//var cookie = new HttpCookie();
//cookie.Expire = DateTime.Today.AddDays(5);

////Notice that we are using the Indexer here to set the name, June
//cookie["name"] = "June";
////Without an Indexer, we have to use a SetItem like below and pass a Key and Value
//cookie.SetItem("name", "June");

////Here, we are getting the Value of the Cookie Item with an Indexer
//var name = cookie["name"];
//var name = cookie.GetItem("name");

////How can we Declare an Indexer?
////An Indexer is a property so we declare it the same way 
//public string HttpCookie
//{
//////Here, we have a String DataType
////Instead of an Identifier, we use "this" keyword
////Inside the [] we have the Type of Indexer 
//    public string this [string key]
//    {
//        get{...}
//        set{...}
//    }
//}

using System;
using System.Collections.Generic;

namespace CProject3.Classes
{
	////HttpCookie Class
	public class HttpCookie
	{
		////We need a Field to store the Key and Value pairs in the Cookie
		////Data Type we are going to use is "Dictionary"
		////Dictionary uses a hash table to store Data and works well with Keys

		////This is a Generic class with Generic Parameters which specify the Type of the Dictionary
		////In this case, Keys are type String and the Value should also be type String 
		////We are using ReadOnly to ensure that all the Data on this list is protected and not lost
		////ReadOnly= Intialize only once
		private readonly Dictionary<string, string> _dictionary;

		public DateTime Expiry
		{
			get;
			set;
		}

		////Intiializing Dictionary in the constructor
		public HttpCookie()
		{
			_dictionary = new Dictionary<string, string>();
		}

		////Declaring an Indexer
		////The Return type is String, becuase both Key/Value Pairs are Strings 
		public string this[string key]
		{
			get
			{
				////Here, we are Delagating to our Dictionary
				////Internally, Dictonary stores the Key/Value Pairs and HttpCookie is a wrapper around it
				return _dictionary[key];
			}

			set
			{
				////Value is a KeyWord which represnts what is on the right side of Assignment Operator
				_dictionary[key] = value;
			}
		}
	}

	//public class IndexersEx
	//{
	//    static void Main(string[] args)
	//    {
	//        ////Creating Instance of HttpCookie
	//        var cookie = new HttpCookie();

	//        ////We can store a Key/Value Pair using the Indexer
	//        ////name= Key
	//        ////June= Value  
	//        cookie["name"] = "June";

	//        System.Console.WriteLine(cookie["name"]);
	//    }
	//}
}
