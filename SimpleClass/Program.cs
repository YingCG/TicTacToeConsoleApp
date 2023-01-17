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
            var computer1 = new Desktop("Student Machine 1", Desktop.CaseType.Tower);

            Console.WriteLine("Computer Type - " + computer1.GetType());

            var isComputer = computer1 is Computer;
            Console.WriteLine("Is computer - " + isComputer);
            Console.WriteLine("Lab Computer - " + computer1.name);
            Console.WriteLine("Case - " + computer1.caseType);

            //computer1.TurnOn();
            //Console.WriteLine("Computer is on: " + computer1.isOn);

            //computer1.TurnOff();
            //Console.WriteLine("Computer is on: " + computer1.isOn)


            computer1.TogglePower();
            Console.WriteLine("Computer is on: " + computer1.isOn);

            computer1.ToggleSleep();
            Console.WriteLine("Computer is sleeping: " + computer1.isSleeping);

            computer1.TogglePower();
            Console.WriteLine("Computer is on: " + computer1.isOn);

            //Console.WriteLine("Press S to toggle the power");
            //var toggle = Console.ReadKey();

            //do
            //{
            //    if (toggle.KeyChar == 's')
            //    {
            //        computer1.TogglePower();
            //        Console.WriteLine("Computer is on: " + computer1.isOn);
            //    }
            //    else
            //    {
            //    }
            //} while (toggle.KeyChar != 'q');
            Console.ReadLine();
        }
    }
}
