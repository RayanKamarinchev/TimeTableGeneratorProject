using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTimeTable.Models
{
    public class Hour
    {
        public string Subject { get; set; }
        public int TimesIn { get; set; }
        public Teacher[] Teacher { get; set; }
        public Hour(string subject, Teacher[] teacher, int timesIn)
        {
            Subject = subject;
            Teacher = teacher;
            TimesIn = timesIn;
        }
    }
}
