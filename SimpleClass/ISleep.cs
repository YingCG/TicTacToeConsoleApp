using System;
using System.Collections.Generic;
using System.Text;

namespace OOPExamples
{
    interface ISleep
    {
        bool isSleeping { get; }
        void ToggleSleep();
    }
}
