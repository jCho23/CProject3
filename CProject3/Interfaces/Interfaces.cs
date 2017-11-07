#region Interfaces
//What is an Interface?
//A language that is similar to a class(in terms of syntax)
//BUT is fundamentally different

//Declaring an Interface 
//Notice that the Interface's Name starts with an "I"
//This is proper convention

//public interface ITaxCalculator
//{
//    int Calculate();
//NOTE: Methods do not have bodies in Interfaces
//}

//Why use Interfaces?
//To build loosely-coupled applications

#endregion
using System;

namespace CProject3.Interfaces
{
    public class OrderProcessor
    {
        private readonly ShippingCalculator _shippingCalculator;

        public OrderProcessor()
        {
            _shippingCalculator = new ShippingCalculator();
        }

        public ShippingCalculator ShippingCalculator => _shippingCalculator;

        public void Process(Order order)
        {
            if (order.IsShipped)
                throw new InvalidOperationException("This Order is already processed");

            order.Shipment = new Shipment
            {
                Cost = ShippingCalculator.CalculatorShipping(order),
                ShippingDate = DateTime.Today.AddDays(1)
            };
        }


    }


    public class Testability
    {
       static void Main(string[] args)
        {
            var orderProcessor = new OrderProcessor();
            var order = new Order { DatePlaced = DateTime.Now, TotalPrice = 100f };
            orderProcessor.Process(order);
        }
    }
}
