using System;

namespace Lab_Events
{
    class Program
    {
        static void Main(string[] args)
        {
            Company company = new Company();
            Customer Jane = new Customer("Jane");
            Customer Mark = new Customer("Mark");

            int number;

            do
            {
                Console.Write("\nEvent Menu\n----------\n1 – Jane subscribe to company shipment arrived event.\n2 – Mark subscribe to company shipment arrived event.\n3 – Jane subscribe to company sale event.\n4 – Mark subscribe to company sale event.\n5 – Jane unsubscribe to company shipment arrived event.\n6 – Mark unsubscribe to company shipment arrived event.\n7 – Jane unsubscribe to company sale event.\n8 – Mark unsubscribe to company sale event.\n9 – Fire company shipment arrived event.\n10 – Fire company sale event.\n11 – Exit\nMenu choice: ");
                string input = Console.ReadLine();

                Int32.TryParse(input, out number);

                switch (number)
                {
                    case 1:
                        company.ShipmentArrived += Jane.ProcessShipmentArrivedEvent;
                        break;
                    case 2:
                        company.ShipmentArrived += Mark.ProcessShipmentArrivedEvent;
                        break;
                    case 3:
                        company.Sale += Jane.ProcessSaleEvent;
                        break;
                    case 4:
                        company.Sale += Mark.ProcessSaleEvent;
                        break;
                    case 5:
                        company.ShipmentArrived -= Jane.ProcessShipmentArrivedEvent;
                        break;
                    case 6:
                        company.ShipmentArrived -= Mark.ProcessShipmentArrivedEvent;
                        break;
                    case 7:
                        company.Sale -= Jane.ProcessSaleEvent;
                        break;
                    case 8:
                        company.Sale -= Mark.ProcessSaleEvent;
                        break;
                    case 9:
                        company.FireShipmentArrived();
                        break;
                    case 10:
                        company.FireSale("A description");
                        break;

                 
                }
            } while (number != 11);

            
        }
    }
}
