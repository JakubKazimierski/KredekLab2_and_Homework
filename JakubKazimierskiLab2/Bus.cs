using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JakubKazimierskiLab2
{
    class Bus : Vehicle
    {
        bool panthographIsDown;
        int gasoilLevel;

        /// <summary>
        /// Constructor of object Bus, overriding inherited variables form abstract class Vehicle
        /// </summary>
        /// <param name="nr"></param>
        /// <param name="year"></param>
        /// <param name="mod"></param>
        public Bus(int nr, int year, string mod)
        {
            vehicleNumber = nr;
            yearOfProduction = year;
            name = mod;
            panthographIsDown = false;
        }

        /// <summary>
        /// Method to refuel bus
        /// </summary>
        /// <returns></returns>
        public string Refuel()
        {
            gasoilLevel = 100;
            return "Autobus zostal zatankowany";
        }
        
        /// <summary>
        /// Overriding absract methods from abstract class Vehicle
        /// </summary>
        /// <returns></returns>
        public override string StartVehicle()
        {
            return "Autobus odjezdza";
        }

        public override string StopVehicle()
        {
            return "Autobus zatrzymany";
        }



    }
}
