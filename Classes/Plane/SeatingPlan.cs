using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportClassLibrary.Classes
{
    public class SeatingPlan
    {
        public int ID { get; set; }

        public int SeatCount
        {
            get
            {
                return CustomerRowCount * CustomerColumnCount + StaffSeatCount;
            }
        }

        public int CustomerRowCount { get; set; }

        public int CustomerColumnCount { get; set; }

        public int StaffSeatCount { get; set; }

        public ICollection<PlaneType> PlaneTypeList { get; set; }
    }
}
