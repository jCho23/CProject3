using System;

namespace Amazon
{
    public class RateCalculator
    {
        public int Calculate(Customer customer)
        {
            return 0;
        }
   
    }

    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Promote()
        {
            ////Note, this is not best practice to instanticate a new RateCalculator here
            var calculator = new RateCalculator();
            var rating = calculator.Calculate(this);

           Console.WriteLine("Promote Logic Changed.");
        }
    }
}
