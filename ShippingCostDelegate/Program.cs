using System;

namespace ShippingCostDelegate
{
    class Program
    {
        private static decimal productPrice;

        static void Main(string[] args)
        {
            Console.WriteLine("Shipping Cost base on where you sending your goods to, all high risk good have $25 on top: ");
            Console.WriteLine("Zone1 - 25% \r\nZone2 - 12% - high risk \r\nZone3 - 8% \r\nZone4 - 4% - high risk");
            Console.WriteLine("What is the destination zone?");
            var zoneChoice = Console.ReadKey();
            Console.WriteLine(calculateShippingCost(zoneChoice, productPrice) );
            Console.WriteLine("Press Q for exit");
        }

        private static decimal calculateShippingCost(ConsoleKeyInfo zoneChoice, Decimal productPrice)
        {

                Console.WriteLine("\r\nWhat is the price of the goods?");
                string price = Console.ReadLine();
                productPrice = Decimal.Parse(price);
                if (zoneChoice.KeyChar == '1')
                {
                    productPrice = productPrice * 125 / 100;
                }
                if (zoneChoice.KeyChar == '2')
                {
                    productPrice = (productPrice * 112/100) + 25M;
                }
                if (zoneChoice.KeyChar == '3')
                {
                    productPrice = productPrice * 108/100;
                }
                if (zoneChoice.KeyChar == '4')
                {
                    productPrice = (productPrice * 104/100) + 25M;
                }
                return productPrice;
        }
    }
}
