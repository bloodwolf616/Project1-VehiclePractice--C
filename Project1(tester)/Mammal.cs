using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1_tester_
{
    class Mammal
    {
        private string _sound;

        public string NameOfMammal { get; set; }
        public string SoundOfMammal
        {
            get
            {
                switch(NameOfMammal)
                {
                    case "Lion":
                        return "Roar";
                        
                    case "Dog":
                        return "Bark";
                    default:
                        return "Noise";
                }
            }
           
        }
    }
}
