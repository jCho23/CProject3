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


using System;
namespace CProject3.Classes
{
    public class Indexers
    {
        public Indexers()
        {
        }
    }
}
