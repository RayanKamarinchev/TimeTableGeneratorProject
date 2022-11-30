using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTimeTable.Models
{
    public class Day
    {
        public List<Hour> Hours { get; set; }

        public int Sum
        {
            get
            {
                return IndexedHours.Count;
            }
        }

        public List<Hour> IndexedHours
        {
            get
            {
                List<Hour> res = new List<Hour>();
                foreach (var h in Hours)
                {
                    Hour copy = new Hour(h.Subject, h.Teacher, 1);
                    List<Hour> times = new List<Hour>();
                    for (int i = 0; i < h.TimesIn; i++)
                    {
                        times.Add(copy);
                    }

                    res.AddRange(times);
                }

                return res;
            }
        }

        public Day()
        {
            Hours = new List<Hour>();
        }
        public Day(List<Hour> hours)
        {
            Hours = hours;
        }
    }
}
