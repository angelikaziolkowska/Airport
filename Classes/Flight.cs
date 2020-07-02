using AirportClassLibrary.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport
{
    public abstract class Flight
    {
        public string FlightID { get; set; }

        public int PlaneRef { get; set; }

        public Connection Connection { get; set; }

        //airline

        public string Stand { get; set; }

        public int Gate { get; set; }

        public Terminal Terminals
        {
            get
            {
                return (Gate < 20) ? 1 : 2; //TODO 
            }
        }       

        public DateTime ActualFlightDepartureDateTime { get; set; }

        public DateTime ActualFlightArrivalDateTime { get; set; }

        public DateTime EstimatedFlightDepartureDateTime { get; set; }

        public DateTime EstimatedFlightArrivalDateTime { get; set; }

        public bool IsOnTime
        {
            get
            {
                return ActualFlightArrivalDateTime > EstimatedFlightArrivalDateTime ? false : true;
            }
        }

        ICollection<Passenger> PassengerList { get; set; }

        ICollection<StaffMember> StaffMemberList { get; set; }
    }
}
