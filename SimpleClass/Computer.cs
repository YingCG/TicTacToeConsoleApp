using System;
using System.Collections.Generic;
using System.Text;

namespace OOPExamples
{
    abstract class Computer
    {
        protected string _name = "Student lab Computer";
        public bool isOn { get; private set; }

        //public string name { get; set; }
        public virtual string name {
            get { return _name; }
            private set { _name = value; } 
        }
        public Computer(string name)
        {
            this.name = name;
        }

        protected void TurnOn()
        {
            isOn = true;
        }

        protected void TurnOff()
        {
            isOn = false;
        }

        public virtual void TogglePower()
        {
            if (isOn)
            {
                TurnOff();
            } else
            {
                TurnOn();
            }
        }
    }
}
