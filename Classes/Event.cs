using System;

namespace Calendar
{
    class Event
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime Date { get; set; }

        public float Start { get; set; }

        public float End { get; set; }

        public int Iterable { get; set; }
    }
}
