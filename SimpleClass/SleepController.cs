using System;
using System.Collections.Generic;
using System.Text;

namespace OOPExamples
{
    class SleepController : ISleep
    {
        public bool isSleeping { get; private set; }

        public void ToggleSleep()
        {
            isSleeping = !isSleeping;
        }
    }
}
