using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JakubKazimierskiLab2
{
   abstract class  Vehicle
    {
        protected int vehicleNumber;
        protected int yearOfProduction;
        protected string name;

        /// <summary>
        /// Method takes and return number of vechicle
        /// </summary>
        /// <returns></returns>
        public virtual int GetVehicleNumber()
        {
            return vehicleNumber;
        }

        /// <summary>
        /// Method takes and reurn year of vechicle
        /// </summary>
        /// <returns></returns>
        public virtual int GetYearOfProduction()
        {
            return yearOfProduction;
        }

        /// <summary>
        /// Method to get name of vechicle
        /// </summary>
        /// <returns></returns>
        public virtual string GetName()
        {
            return name;
        }

        /// <summary>
        /// Method set vechicle name
        /// </summary>
        /// <param name="num"></param>
        public virtual void SetVehicleNumber(int num)
        {
            vehicleNumber = num;
        }

        //abstract methods
        abstract public string StartVehicle();
        abstract public string StopVehicle();



    }
}
