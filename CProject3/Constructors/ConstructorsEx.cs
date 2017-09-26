using System;
using System.Collections.Generic;


////Creating a Customer Class
//    public class Customers
//    {
////*NOTE= This is not the best way to declare fields (i.e. public)
//        public int Id;
//        public string Name;

////This List takes a generic parameter, "Order"
////Whenever a Class has a list of objects, ALWAYS initialize that List as an EMPTY LIST
//        public List<Order> Orders;

////We are creating a parameter-less Constructor to ensure the code works without any parameters
//      public Customers()
//      {
//            //This is the EMPTY LIST
//            Orders = new List<Order>();
//      }

////Declaring a constructor to intialize this field upon instanciation of a customer 
////Two ways to declare a Constructor
//        //1) public Customer{}
//        public Customers(int id)
////Instead of initializng a new List in every Constructor,
////we can use ":this()" to reference the empty Constructor above
//            :this()
//        {
//            this.Id = id;
//        }

////We are Overloading the Constructors here
//        public Customers(int id, string name)
////Notice that we are Referencing the "id" constructor above here 
////thereby initializing the Order List
//            :this(id)
//        {
//            this.Id = id;
//            this.Name = name;
//        }


//    public class Order
//    {

//    }

//    public class ConstructorsEx
//    {
//        static void Main(string[] args)
//        {
////Here, we are Creating a New Instance of Customers
//            var customers = new Customers();

////We are creating a New Order for Customers
//            var order = new Order();
//            customers.Orders.Add(order);

//            Console.WriteLine(customers.Id);
//          Console.WriteLine(customers.Name);
//        }
//    }
//}
