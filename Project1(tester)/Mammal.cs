using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1_tester_
{
  public class Mammal : IAnimal
  {
        private string _nameOfMammal;
        public string Name { get; private set; }
        public string Species { get; private set; }

        public string Move()
        {
            throw new NotImplementedException();
        }

            //create a constructor that sets the name of the mammal

            public Mammal(string name)
        {
            NameOfMammal = name;
            
        }

                  

            public string NameOfMammal 
            { 
            
                    get
                    {
                return _nameOfMammal;
                    }

                    set
                    {
                        if(value == "Fish")
                        {
                            throw new InvalidOperationException("this is not a mammal");
                        }
                        _nameOfMammal = value;
                    }
            
                
            }
            
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
