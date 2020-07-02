using Airport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportClassLibrary.Classes
{
    public class JobTitle
    {
        public int ID { get; set; }

        public string Title { get; set; }

        public int JobRoleRef { get; set; } // same title could be linked to many same positions.

        public ICollection<StaffMember> StaffMemberList { get; set; }
    }
}
