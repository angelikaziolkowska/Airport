using Airport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportClassLibrary.Classes
{
    public class EquipmentItem
    {
        public int EquipmentItemID { get; set; }

        public EquipmentType EquipmentType { get; set; }

        public float Price { get; set; }

        public ICollection<JobResponsibility> JobResponsibilityList { get; set; }
    }
}
