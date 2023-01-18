using System;
using System.Collections.Generic;
using System.Text;

namespace OOPExamples
{
    class Laptop : Computer, ISleep
    {
        private ISleep SleepController;
        public Display Display { get; private set; }

        public bool isSleeping
        {
            get
            {
                return SleepController.isSleeping;
            }
        }

        public Laptop(string name, int width, int height) : base(name)
        {
            Display = new Display(width, height);
            SleepController = new SleepController();
        }

        public void ToggleSleep()
        {
            SleepController.ToggleSleep();
        }
    }
}
