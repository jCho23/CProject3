﻿////BlackBox = Limited visiblity from the outside-->Make Classes like this

////Access Modifiers
////* public = Accessible from everywhere
////* private = Accessible only from the Class
////* protected = Accessible only from the Class and its derived Classes (breaks encapsulation)
////* internal = Accessible only from the same assembly
////* protected internal = Accessible only from the same assebly or any derived Classes     

using System;
////using Amazon;


    ////Moved to Amazon.Customer
    //public class Customer
    //{
        ////Here, we are defining Properties of the Customer Class
    //    public int Id { get; set; }
    //    public string Name { get; set; }

    //    public void Promote()
    //    {
    //        ////We are calling the CalculateRating Method below
    //        var rating = CalculateRating();

    //        ////From the Return of CalculateRating Method we can make Decisions
    //        if (rating==0)
    //            Console.WriteLine("Promoted to Level 1");
    //        else
    //            Console.WriteLine("Promoted to Level 2");
    //    }

        ////This CalculateRating is the Implementation Detail of the CustomerClass
        ////Notice that we changed this Method to Private to encapsulate it from other Classes
        ////Now, we only need to changed the code once when it is getting called in the above Class
        ////More importantly, we don't want other Classes to have dependencies from this Method   
    //    //public int CalculateRating()
    //    private int CalculateRating()
    //    {
    //        return 0;
    //    }
    //}

    ////This GoldCustomer Class derives from the Customer Class
    //public class GoldCustomer : Customer
    //{

    //    public void OfferVoucher()
    //    {
            ////Notice that the CalculateRating Method above is not accessible
    //        //this.
    //    }
    //}



    //class AccessModifiers
    //{
    //    static void Main(string[] args)
    //    {
    //        ////We are creating a New Instance of Customer
    //        var customer = new Customer();

    //    }
    //}
//}
