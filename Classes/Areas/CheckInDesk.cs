using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportClassLibrary.Classes
{
    public class CheckInDesk
    {
        public int ID { get; set; }

        public int StaffMemberRef { get; set; }

        public DateTime WorkShiftFrom { get; set; }

        public DateTime WorkShiftTo { get; set; }
    }
}
