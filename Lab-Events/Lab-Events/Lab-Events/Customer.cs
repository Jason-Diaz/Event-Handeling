using System;

namespace Lab_Events
{
    class Customer
    {
        string Name { get; set; }
        public Customer(string v)
        {
            Name = v;
        }

        public void ProcessShipmentArrivedEvent()
        {
            Console.WriteLine("\nProcessed sale event");
            Console.WriteLine(Name + " handled the event\n");
        }

        public void ProcessSaleEvent(Object sender, Company.SaleEventArgs evtArgs)
        {
            Console.WriteLine("\nProcessed sale event");
            Console.WriteLine(Name + " handled the event\n");
            Console.WriteLine(evtArgs.SaleDescription);

        }
    }
}
