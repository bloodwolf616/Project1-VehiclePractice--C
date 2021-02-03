using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1_tester_
{
    class GarbageCan
    {
        public int GarbageWeight { get; private set; }

        public GarbageCan(int garbageWeight)
        {
            GarbageWeight = garbageWeight;
        }


        public void EmptyOutGarbageCan()
        {
            GarbageWeight = 0;
        }
        
    }
}
