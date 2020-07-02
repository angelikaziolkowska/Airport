using Airport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportClassLibrary.Classes.People.Customers
{
    public class BoardingPass
    {
        public int BaggegeSize { get; set; }

        public float TicketPrice { get; set; }

        public PaymentOption PaidWith { get; set; }

    }
}
