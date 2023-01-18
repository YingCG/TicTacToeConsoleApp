using System;

namespace ShippingInfoDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press A for shipping fees calculation, Press Q for Exit");
            string operation = Console.ReadLine();
            if(operation == "q")
            {
                Environment.Exit(0);
            }
            else
                Console.WriteLine("Shipping Cost base on where you sending your goods to, all high risk good have $25 on top: ");
            {
                Console.WriteLine("Zone1 - 25% \r\nZone2 - 12% - high risk \r\nZone3 - 8% \r\nZone4 - 4% - high risk");
                Console.WriteLine("What is the destination zone?");
                string zone = Console.ReadLine();
                
                Console.WriteLine("What is the price of the goods?");
                var productPrice = Console.ReadLine();
                //ShippingDelegate newOrder = FeeCalculate;

                ShippingInfo order1 = new ShippingInfo();
                Console.WriteLine(order1.FeeCalculate(zone, decimal.Parse(productPrice)).ToString());
            }

        }
    }
}
