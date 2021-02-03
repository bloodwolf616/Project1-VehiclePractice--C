using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1_tester_
{
   abstract class Trailer
    {
        public int TrailerWeight { get; set; }
        public Trailer(int weight)
        {
            TrailerWeight = weight;
        }
    }
}
