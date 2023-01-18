using System;

namespace OOPExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            //var computer1 = new Computer();
            //computer1.name = "Student Machine 1";
            //var computer1 = new Computer("Student Machine 1");
            //var computer1 = new Desktop("Student Machine 1", Desktop.CaseType.Tower);
            var computer1 = new Laptop("Laptop 1", 1024, 768);

            Console.WriteLine("Computer Type - " + computer1.GetType());

            var isComputer = computer1 is Computer;
            Console.WriteLine("Is computer - " + isComputer);
            Console.WriteLine("Lab Computer - " + computer1.name);
            //Console.WriteLine("Case - " + computer1.caseType);

            //computer1.TurnOn();
            //Console.WriteLine("Computer is on: " + computer1.isOn);

            //computer1.TurnOff();
            //Console.WriteLine("Computer is on: " + computer1.isOn)


            //computer1.TogglePower();
            //Console.WriteLine("Computer is on: " + computer1.isOn);



            //computer1.TogglePower();
            //Console.WriteLine("Computer is on: " + computer1.isOn);

            Console.WriteLine("Press A to toggle the power, Press S to put machine in sleeping mode");
            ConsoleKeyInfo toggle;
            do
            {
                toggle = Console.ReadKey();
                var sleepingComp = computer1 as ISleep;

                if (toggle.KeyChar == 'a')
                {
                    computer1.TogglePower();
                    Console.WriteLine("Computer is on: " + computer1.isOn);
                } if (toggle.KeyChar == 's')
                {
                    
                        //computer1.ToggleSleep();
                        //Console.WriteLine("Computer is sleeping: " + computer1.isSleeping);
                        
                        Console.WriteLine();
                        computer1.TogglePower();
                        Console.WriteLine("Computer is on: " + computer1.isOn);
                        Console.WriteLine();
                    }
                if (sleepingComp != null)
                {
                    sleepingComp.ToggleSleep();
                    Console.WriteLine("Computer is sleeping: " + sleepingComp.isSleeping);
                }
            } while (toggle.KeyChar != 'q');

  
            Console.ReadLine();
        }
    }
}
