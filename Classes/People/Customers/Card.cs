using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportClassLibrary.Classes.People.Customers
{
    public class Card
    {
        public int ID { get; set; }

        public string NameOnCard { get; set; }
        // card details / info
        public int LongCardNumber { get; set; }

        public int SortCode { get; set; }

        public DateTime? ValidFromDate { get; set; }

        public DateTime ValidToDate { get; set; }

        public int CVC { get; set; }

        public struct CardAddress
        {
            public int BuildingNo { get; set; }

            public string FirstLineOfAddress { get; set; }

            public string SecondLineOfAddress { get; set; }
           
            public string PostCode { get; set; }

            public string City { get; set; }
        }
    }
}
