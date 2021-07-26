using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1_tester_
{
    class Garage
    {

        public List<AutoMobile> GarageCollection { get; set; }

        /// <summary>
        /// This class contains a collection of all of our Automobile objects.
        /// </summary>
        /// <param name="listOfAutomobiles">A list that contains objects of base type "AutoMobile"</param>
        public Garage(List<AutoMobile> listOfAutomobiles)
        {
            GarageCollection = listOfAutomobiles;
        }


    }
}
