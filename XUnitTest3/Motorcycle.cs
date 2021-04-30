using System;

namespace XUnitTest3
{
    internal class Motorcycle
    {

        public int GasTank { get; private set; }
        public int Milage { get; private set; }

        private int _gasInTank;

        public int MilesperGallon { get; } = 20;

        public bool HazardLights { get; private set; }

        public int GasInTank
        {
            get { return _gasInTank; }
            protected set
            {



                if (value >= 0 && value <= GasTank)
                {
                    _gasInTank = value;
                }
                if (value > GasTank) { throw new InvalidOperationException("You are over filling the gas tank!"); }

                if (value <= 0) { throw new InvalidOperationException("There is no gas left in the tank."); }





            }


        }

        public Motorcycle(int gasTank)
        {
            
            GasTank = gasTank;
            GasInTank = GasTank;
        }

        public bool SetHazardLights(bool button)
        {

            if (button == true)
            { Console.WriteLine("Hazard lights are on"); }
            else
            {
                Console.WriteLine("Hazard lights are off.");
            }



            return  HazardLights = button;

        }






        /// <summary>
        /// Drives the Motorcycle
        /// </summary>
        /// <param name="miles">the miles you want to drive as a integer</param>
        /// <returns></returns>
        public void DriveBike(int miles)
        {
            int gallonsUsed = miles / MilesperGallon;

            while(gallonsUsed > 0)
            {
                Console.WriteLine("Vroom!");
                GasInTank--;
                gallonsUsed--;
                Milage += MilesperGallon;
            }

            if(gallonsUsed == 0) { Console.WriteLine("You have completed your jouney"); }
            else { Console.WriteLine("You have completed your journey"); }
        }
    }
}