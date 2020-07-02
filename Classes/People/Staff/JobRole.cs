using Airport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AirportClassLibrary.Classes
{
    public class JobRole
    {
        public int ID { get; set; }

        public Rank Rank { get; set; }

        public Department Department { get; set; }

        public ICollection<JobTitle> JobTitles { get; set; }

        public ICollection<JobResponsibility> JobResponsibilityList { get; set; }
    }
}
