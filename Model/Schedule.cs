using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workinterview.Model
{
    public class Schedule
    {
        public int type { get; set; }
        public int weekday { get; set; }
        public bool allDay { get; set; }
        public string startHour { get; set; }
        public string stopHour { get; set; }
    }
}
