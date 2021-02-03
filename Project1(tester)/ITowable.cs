using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1_tester_
{
    // Our interface that take a CanTow Method. Think about adding a Traielr weight property.
    interface ITowable
    {
        int TrailerWeight { get; }

        bool CanTow();
    }
}
