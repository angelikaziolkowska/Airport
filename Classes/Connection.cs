using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportClassLibrary.Classes
{
    public class Connection
    {
        // ID of connecting airports
        public int ConnectionID { get; set; }

        // from/to---- Ref to Aiport ID
        public int AirportDetail1IDRef {get; set;}

        // from/to ---- Ref to AirportID
        public int AirportDetail2IDRef {get; set;}
    }
}
