using AirportClassLibrary.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport
{
    public class Passenger : Person
    {        
       public List<Stuff> StuffList { get; set; }
       
    }
}
