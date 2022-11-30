using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyTimeTable.Models;

namespace MyTimeTable
{
    public class Index
    {
        public int DayOfTheWeek { get; set; }
        public int HourPositionInDay { get; set; }
        public int RepeatedClassIndex { get; set; }
        public int OriginalClassIndex { get; set; }
        public int RepeatedHourGroupPosition { get; set; }
        public int OriginalHourGroupPosition { get; set; }

        public Index(int dayOfTheWeek, int hourPositionInDay, int repeatedClassIndex, int originalClassIndex, int repeatedHourGroupPosition, int originalHourGroupPosition)
        {
            DayOfTheWeek = dayOfTheWeek;
            HourPositionInDay = hourPositionInDay;
            RepeatedClassIndex = repeatedClassIndex;
            RepeatedHourGroupPosition = repeatedHourGroupPosition;
            OriginalClassIndex = originalClassIndex;
            OriginalHourGroupPosition = originalHourGroupPosition;
        }
    }
}
