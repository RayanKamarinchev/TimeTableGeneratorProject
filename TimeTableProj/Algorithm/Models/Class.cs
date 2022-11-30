using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MyTimeTable.Models
{
    //BUG loops at sum = 6
    public class Class
    {
        public string Name { get; set; }
        public int Hours;
        [JsonIgnore]
        public Dictionary<string, List<int>> PickHours { get; set; }
        public Dictionary<string, int> HourTimes { get; set; }
        public Random rand = new Random();

        public Class()
        {
            
        }
        public Class(string name, Dictionary<string, int> hours)
        {
            this.Name = name;
            Random rand = new Random();
            hours = hours.OrderBy(d=>rand.Next()).ToDictionary(x => x.Key, x => x.Value);
            this.PickHours = new Dictionary<string, List<int>>();
            foreach (var dup in hours)
            {
                int[] hoursPerDay;
                switch (dup.Value)
                {
                    case 1:
                        hoursPerDay = new[] { 1};
                        break;
                    case 2:
                        hoursPerDay = new[] { 1, 1};
                        break;
                    case 3:
                        hoursPerDay = new[] { 1, 1, 1};
                        break;
                    case 4:
                        hoursPerDay = new[] { 2, 1, 1};
                        break;
                    case 5:
                        hoursPerDay = new[] { 2, 1, 1, 1};
                        break;
                    case 6:
                        hoursPerDay = new[] { 2, 2, 1, 1};
                        break;
                    case 7:
                        hoursPerDay = new[] { 2, 2, 1, 1, 1 };
                        break;
                    default:
                        int avg = dup.Value / 5;
                        hoursPerDay = new[]
                        {
                            avg + (dup.Value % 5 >= 1 ? 1 : 0), avg + (dup.Value % 5 >= 2 ? 1 : 0),
                            avg + (dup.Value % 5 >= 3 ? 1 : 0), avg + (dup.Value % 5 >= 4 ? 1 : 0), avg
                        };
                        break;
                }
                this.PickHours.Add(dup.Key, hoursPerDay.ToList());
            }

            HourTimes = hours;
            this.Hours = hours.Sum(h => h.Value);
        }
    }
}
