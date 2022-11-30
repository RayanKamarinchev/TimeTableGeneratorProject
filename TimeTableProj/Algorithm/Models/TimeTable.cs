using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTimeTable.Models
{
    public class TimeTable
    {
        public Day[] days { get; set; }
        public TimeTable(Day[] days)
        {
              this.days = days;
        }
    }
}
