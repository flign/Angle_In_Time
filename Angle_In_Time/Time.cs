using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Angle_In_Time
{
    public class Time
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }

        public Time(int Hours, int Minutes)
        {
            this.Hours = Hours;
            this.Minutes = Minutes;
        }
    }
}
