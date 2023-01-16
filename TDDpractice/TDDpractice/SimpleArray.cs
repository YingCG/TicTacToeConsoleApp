using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDpractice
{
    public class SimpleArray
    {
        public string[] TodoList;

        public SimpleArray()
        {
            TodoList = new string[5] {"eat", "programming", "relax", "workout","sleep"};
        }

        public override string ToString()
        {
            return "Everday we have " + TodoList.Length + " tasks" + TodoList.ToString();
        }
    }
}
