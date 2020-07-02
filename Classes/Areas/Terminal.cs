using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportClassLibrary.Classes.Areas
{
    public class Terminal
    {
        public int ID { get; set; }

        public List<int> Gates { get; set; }

        public int AirportDetailIDRef { get; set; }

    }
}
