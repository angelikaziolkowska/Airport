using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportClassLibrary.Classes
{
    public abstract class Person
    {
        public int PersonID { get; set; }

        public struct Name
        {
            public string FirstName { get; set; }

            public string MiddleNames { get; set; }

            public string Surename { get; set; }
        }

        public string PassportNumber { get; set; }

        public int CitizenshipCountryRef { get; set; }
    }
}
