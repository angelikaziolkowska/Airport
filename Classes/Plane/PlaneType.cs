using Airport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportClassLibrary.Classes
{
    public class PlaneType
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public PlaneManufacturer Manufacturer { get; set; }

        public ICollection<Plane> PlaneList { get; set; }

        public int SeatingPlanRef { get; set; }
    }
}
