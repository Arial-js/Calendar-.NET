using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar
{
    class Event
    {
        public Event()
        {

        }

        public string Name { get; set; }

        public DateTime Date { get; set; }

        public float Start { get; set; }

        public float End { get; set; }

        public int Iterable { get; set; }
    }
}
