using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1_tester_
{
    class Peacock : Bird
    {
        public Peacock(string primaryColor, string secondaryColor, int age) : base(primaryColor, secondaryColor, age)
        {

        }

        public override void fly()
        {
            Console.WriteLine("Woop");
        }
    }
}
