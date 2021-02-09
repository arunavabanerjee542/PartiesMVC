using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartiesMVC.Models
{
    public static  class Repository
    {

        public static List<Attendes> attendesList = new List<Attendes>();

        public static void AddAttendes(Attendes attendes)
        {
            attendesList.Add(attendes);
        }

        public static List<Attendes> GetAttendes()
        {
            return attendesList;
        }



    }
}
