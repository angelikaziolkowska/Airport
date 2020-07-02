using System;
using System.Collections.Generic;

namespace Airport
{
    public class Shift
    {
        public int ID { get; set; }

        public int AirportIDRef { get; set; }

        public DateTime ShiftStart { get; set; }

        public DateTime ShiftEnd { get; set; }

        ICollection<StaffMember> StaffMembers { get; set; }
    }
}