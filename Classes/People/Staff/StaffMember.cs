using AirportClassLibrary.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport
{
    public class StaffMember : Person
    {
        public int JobTitleRef { get; set; }

        public JobStatus JobStatus { get; set; }

        // reference to which airport staff member works at
        public int AirportIDRef { get; set; }

        public struct BankDetails
        {
            public string BankName { get; set; }

            public string BankAddress { get; set; }

            public int AccountNumber { get; set; }

            public int SortCode { get; set; }
        }

        ICollection<Flight> FlightList { get; set; }

        ICollection<Shift> ShiftList { get; set; }
    }
}
