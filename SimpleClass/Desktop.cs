using System;
using System.Collections.Generic;
using System.Text;

namespace OOPExamples
{
    class Desktop : Computer, ISleep
    {
        private ISleep SleepController;
        public enum CaseType
        {
            Tower,
            MiniTower
        }

        //public bool isSleeping { get; private set; }
        public bool isSleeping { 
            get { return SleepController.isSleeping; }
        }
        public CaseType caseType { get; private set; }

        public override string name { 
            get
            {
                return base.name + " " + caseType;
            }
        }

        public Desktop(string name, CaseType caseType) : base(name)
        {
            this.caseType = caseType;
            SleepController = new SleepController();
        }

        public void ToggleSleep()
        {
            if (!isOn)
            {
                return;
            }

            //isSleeping = !isSleeping;
            SleepController.ToggleSleep();
        }

        public override void TogglePower()
        {
            if (isSleeping)
            {
                return;
            }

            base.TogglePower();
        }
    }
}
