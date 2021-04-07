using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1_tester_
{
    interface IAutomobile
    {
        int GasTank { get; }
        string Color { get; }
        int MilesPerGallon { get;  }
        
       int YearOfManufacturer { get;  }
        int Milage { get;  }

        string Model { get; }

        int GasInTank { get; }

        void Fill();

        void Drive(int miles);
         void PerformTowable();

        void GetOilChange();



    }
}
