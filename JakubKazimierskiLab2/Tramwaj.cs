using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JakubKazimierskiLab2
{
    class Tramwaj : Vehicle, IPantograph
    {
        bool panthographIsDown;
        /// <summary>
        /// Constructor of object
        /// </summary>
        /// <param name="nr"></param>
        /// <param name="year"></param>
        /// <param name="mod"></param>
        public Tramwaj(int nr, int year, string mod)
        {
            vehicleNumber = nr;
            yearOfProduction = year;
            name = mod;
            panthographIsDown = false;
        }

        /// <summary>
        /// Method imitating ringing of bustrain
        /// </summary>
        /// <returns></returns>
        public string Bell()
        {
            return "Tramwaj dzowni";
        }

        /// <summary>
        /// Methods inherited from IPanthograph interface
        /// </summary>
        /// <returns></returns>
        public string PantoghraphDown()
        {
            //else oszczedniejsze dla procesora
            if(panthographIsDown == false)
            {
                panthographIsDown = true;
                return "Opuszczono pantograf";
            }
            else
            {
                return "Pantograf juz opuszczony";
            }
        }

        public string PantographUp()
        {
            if(panthographIsDown == true)
            {
                panthographIsDown = false;
                return "podniesiono pantograf";
            }
            else 
            {
                return "Pantograf jest juz podniessiony";
            }

        }

        /// <summary>
        /// Overriding abstract method from vehicle abstract class
        /// </summary>
        /// <returns></returns>
        public override string StartVehicle()
        {
            if(panthographIsDown == false)
            {
                return "TramwajOdjezdza";
            }
            else
            {
                return "Pantograf jest opuszczony nie mozna ruszyc";
            }
        }

        public override string StopVehicle()
        {
            return "Tramwaj się zatrzymuje";

        }

        
    }
}
