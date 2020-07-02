using Airport;
using AirportClassLibrary.Classes.Areas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportClassLibrary.Classes
{
    public class AirportDetail
    {
        public int AirportID { get; set; }

        public string AirportName { get; set; }

        public Location Location { get; set; }

        

        public ICollection<Flight> FlightList { get; set; }

        public ICollection<Terminal> TerminalList { get; set; }
    }
}
