using System.Collections.Generic;

namespace AirportClassLibrary.Classes
{
    public class JobResponsibility
    {
        public int ID { get; set; }

        public string Description { get; set; }

        public ICollection<JobRole> JobRoleList { get; set; }

        public ICollection<EquipmentItem> EquipmentList { get; set; }
    }
}