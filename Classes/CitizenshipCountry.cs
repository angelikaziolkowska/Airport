using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport
{
    public class CitizenshipCountry
    {
        // saved in enums
        public Country CountryName { get; set; }

        // saved in enums
        public Continent Continent { get; set; } 

        public RestrictionZone RestrictionZone { get; set; }

    }
}
