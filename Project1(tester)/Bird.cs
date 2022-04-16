using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



//i erased the top comment.
namespace Project1_tester_
{
   public class Bird
    {
        public string PrimaryColor { get; }

        public string SecondaryColor { get; }

        public int Age { get; private set; }
        private int Belly;


        public Bird(string primaryColor, string secondaryColor, int age)
        {
            PrimaryColor = primaryColor.ToUpper();
            SecondaryColor = secondaryColor.ToUpper();
            Age = age;
            if(Age > 15)
            {
                throw new System.Exception("No bird can survive this long");
            }
        }


        public string ReturnColors()
        {
            return $"Primary Color: {PrimaryColor} \nSecondaryColor: {SecondaryColor}";
        }

        /// <summary>
        /// Feeds the bird multiple seeds to the belly. once the belly is too full it will call the Poop() method.
        /// </summary>
        /// <param name="seeds">number of seeds to feed the bird</param>
        public void Feed(int seeds)
        {
            Belly += seeds;
            Console.WriteLine("Ooh! found multiple seeds, Yummy!");
            if(Belly >= 10)
            {
                Console.WriteLine("My belly is full!");
                Poop();
            }
        }

        /// <summary>
        /// Feeds the bird one seed to the belly.  once the belly is too full it will call the Poop() method.
        /// </summary>
        public void Feed()
        {
            Belly ++;
            Console.WriteLine("Ooh! a seed, Yummy!");
            if (Belly >= 10)
            {
                Console.WriteLine("My belly is full!");
                Poop();
            }
        }



        /// <summary>
        /// private helper method that is called in the feed() method. Empties the belly and prints to the console
        /// </summary>
        private void Poop()
        {
            while(Belly > 0)
            {
                Belly--;
                Console.WriteLine("POOP!!!");
            }
        }

        public virtual void fly()
        {
            Console.WriteLine("Flap");
        }

        public override bool Equals(object obj)
        {
            if(!(obj is Bird))
            {
                return false;
            }

            Bird that = obj as Bird;

            return this.PrimaryColor == that.PrimaryColor &&
                   this.SecondaryColor == that.SecondaryColor &&
                   this.Age == that.Age;
        }
    }
}
