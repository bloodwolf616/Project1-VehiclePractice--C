using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1_tester_
{
    class NotTowable : ITowable
    {
        public int TrailerWeight { get; } = 0;
        public bool CanTow() 
        {
            Console.WriteLine("This vehicle cannot tow objects.");
            return false;
        }
    }
}
