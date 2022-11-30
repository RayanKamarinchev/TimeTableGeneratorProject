using Algorithm.Models;
using MyTimeTable.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;

namespace MyTimeTable
{
    public class Generator
    {
        static List<TimeTable> timetable = new List<TimeTable>();
        private static List<Index> indexes = new List<Index>();

        static Random rand = new Random();

        static List<int> HoursToday(int hours)
        {
            List<int> options = new List<int>();
            for (int i = 0; i < 5; i++)
            {
                options.Add((int)Math.Round((double)hours / (5 - i) + 0.2));
                hours -= options[i];
            }

            return options;
        }

        

        static TimeTable RandWeek(List<Teacher> teachers, Class clas)
        {
            Class copy = new Class(clas.Name, clas.HourTimes);
            Day[] days = new Day[5];
            for (int j = 0; j < 5; j++)
            {
                days[j] = new Day();
            }

            int hours = copy.Hours;

            KeyValuePair<string, int> maxHour;
            List<int> options = new List<int>() { 0, 1, 2, 3, 4 };
            int i = 0;
            List<int> hoursForToday = HoursToday(hours);
            do
            {
                if (i % options.Count == 0)
                {
                    options = options.OrderBy(o => rand.Next()).ToList();
                    i = 0;
                }

                maxHour = copy.HourTimes.Aggregate((l, r) => l.Value > r.Value ? l : r);
                Hour hour = new Hour(maxHour.Key,
                                     teachers.Where(t => t.Subject == maxHour.Key &&
                                                         t.classes.Any(c => c.Name == copy.Name))
                                             .ToArray()
                                     , copy.PickHours[maxHour.Key].Max());
                copy.PickHours[maxHour.Key].Remove(hour.TimesIn);
                if (copy.PickHours[maxHour.Key].Count == 0)
                {
                    copy.HourTimes[maxHour.Key] = 0;
                }

                int tries = SeePossibilities(hour);
                if (tries == -1)
                {
                    return RandWeek(teachers, clas);
                }

                days[options[tries]].Hours.Add(hour);
                int sum = days[options[tries]].Sum;
                bool succes = hoursForToday.Remove(sum);
                if (succes)
                {
                    options.Remove(options[tries]);
                    if (options.Count == 0)
                    {
                        break;
                    }

                    if (i % options.Count == 0)
                    {
                        options = options.OrderBy(o => rand.Next()).ToList();
                        i = 0;
                    }
                }

                if (sum > hoursForToday[0])
                {
                    return RandWeek(teachers, clas);
                }

                i++;
            } while (hoursForToday.Count != 0);

            for (int j = 0; j < 5; j++)
            {
                days[j].Hours = days[j].Hours.OrderBy(h => rand.Next()).ToList();
            }

            if (hours != days.Sum(d => d.Sum))
            {
                return RandWeek(teachers, clas);
            }

            return new TimeTable(days);

            bool InRange(int sum)
            {
                return sum <= hoursForToday.Max();
            }

            int SeePossibilities(Hour hour)
            {
                //BUG: Infinite loop
                int counter = 0;
                int tries = i;
                while (days[options[tries]].Hours.Any(h => h.Subject == hour.Subject) ||
                       !InRange(days[options[tries]].Sum + hour.TimesIn))
                {
                    tries++;
                    if (tries == options.Count)
                    {
                        if (tries == 1 || counter > 5)
                        {
                            for (int j = 0; j < 5; j++)
                            {
                                for (int k = 0; k < days[j].Hours.Count; k++)
                                {
                                    if (!days[options[0]].Hours.Any(s => s.Subject == days[j].Hours[k].Subject) &&
                                        InRange(days[options[0]].Sum + days[j].Hours[k].TimesIn))
                                    {
                                        Hour removedHour = days[j].Hours[k];
                                        days[j].Hours.RemoveAt(k);
                                        days[options[0]].Hours.Add(removedHour);
                                        return 0;
                                    }
                                }
                            }
                        }

                        return -1;
                    }

                    counter++;
                }

                return tries;
            }
        }

        static void FindMistakesALL()
        {
            indexes = new List<Index>();

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    //get teachers in particular hour
                    var first = timetable
                                .Where(t => t.days[i].Sum > j)
                                .Select(t => new
                                {
                                    teacher = t.days[i].IndexedHours[j].Teacher,
                                    indexOfClass = timetable.IndexOf(t)
                                }).ToList();
                    List<string> repeats = new List<string>();
                    for (int k = 0; k < first.Count; k++)
                    {
                        var teach = repeats.FirstOrDefault(r => first[k].teacher.Any(t => t.Name == r.Split("/")[0]));
                        if (indexes.Count == 0 && teach != null)
                        {
                            indexes.Add(new Index(i, j, first[k].indexOfClass, int.Parse(teach.Split("/")[1]),
                                                  timetable[first[k].indexOfClass].days[i].Hours
                                                                                  .FindIndex(h => h.Subject ==
                                                                                                  first[k].teacher[0]
                                                                                                          .Subject),
                                                  timetable[int.Parse(teach.Split("/")[1])].days[i].Hours
                                                                                           .FindIndex(
                                                                                               h => h.Teacher.Any(
                                                                                                   t => first[k].teacher
                                                                                                                .Any(
                                                                                                                    k =>
                                                                                                                        k.Name ==
                                                                                                                        t.Name)))));
                        }
                        else if (teach != null && !(indexes[^1].RepeatedClassIndex != first[k].indexOfClass &&
                                                    indexes[^1].DayOfTheWeek != i &&
                                                    indexes[^1].HourPositionInDay != j))
                        {
                            indexes.Add(new Index(i, j, first[k].indexOfClass, int.Parse(teach.Split("/")[1]),
                                                  timetable[first[k].indexOfClass].days[i].Hours
                                                                                  .FindIndex(h => h.Subject ==
                                                                                                  first[k].teacher[0]
                                                                                                          .Subject),
                                                  timetable[int.Parse(teach.Split("/")[1])].days[i].Hours
                                                                                           .FindIndex(
                                                                                               h => h.Teacher.Any(
                                                                                                   t => first[k].teacher
                                                                                                                .Any(
                                                                                                                    k =>
                                                                                                                        k.Name ==
                                                                                                                        t.Name)))));
                        }
                        else
                        {
                            repeats.AddRange(first[k].teacher.Select(r => r.Name)
                                                     .Select(t => t += "/" + first[k].indexOfClass));
                        }
                    }
                }
            }
        }

        static bool FindMistake(int i, int j, Teacher[] teachers)
        {
            var first = timetable
                        .Where(t => t.days[i].Sum > j)
                        .Select(t => new
                        {
                            teacher = t.days[i].IndexedHours[j].Teacher,
                            indexOfClass = timetable.IndexOf(t)
                        }).ToList();
            return first.Count(f => f.teacher.Any(t => teachers.Any(r => r.Name == t.Name))) == 0;
        }

        public List<TimeTable> Generate(string classPath, string teachersPath)
        {
            var oldClasses = JsonSerializer.Deserialize<List<Class>>(File.ReadAllText(classPath));
            for (int i = 0; i < oldClasses.Count; i++)
            {
                oldClasses[i] = new Class(oldClasses[i].Name, oldClasses[i].HourTimes);
            }
            int timesUntilReset = 20;
            int target = 2;
            Stopwatch watch = new Stopwatch();
            int min = 100;
            watch.Start();
            do
            {
                timetable = new List<TimeTable>();
                indexes = new List<Index>();
                //INPUT
                List<Class> classses = new List<Class>(oldClasses);
                var teachers = JsonSerializer.Deserialize<List<TeacherDTO>>(File.ReadAllText(teachersPath))
                                             .Select(t => new Teacher(classses.FindAll(c => t.Classes.Contains(c.Name)), t.Subject, t.Name)).ToList();

                //GENERATE
                foreach (var clas in classses)
                {
                    timetable.Add(RandWeek(teachers, clas));
                }

                //MISSES
                FindMistakesALL();
                int t = 0;
                while (true)
                {
                    FindMistakesALL();
                    //Console.WriteLine();
                    //PrintTable();
                    //Console.WriteLine(Math.Min(min, indexes.Count));
                    //Console.WriteLine();
                    foreach (var index in indexes)
                    {
                        //Number 1 - First to other mistake timetable[indexes[index] / 1000].hours[hour] FLIPPING;
                        //Number 2 Shuffle
                        //Number 3 Special care Shuffle
                        var repeatedHoursList = timetable[index.RepeatedClassIndex].days[index.DayOfTheWeek].Hours;
                        var originalHoursList = timetable[index.OriginalClassIndex].days[index.DayOfTheWeek].Hours;
                        Hour theHour = repeatedHoursList[index.RepeatedHourGroupPosition];
                        Hour first = originalHoursList[index.OriginalHourGroupPosition];
                        List<int> hourValids = new List<int>();
                        List<int> firstHourValids = new List<int>();
                        int pos = 0;
                        for (int i = 0; i < repeatedHoursList.Count; i++)
                        {
                            //check statement useful only the first time
                            if (i == index.RepeatedHourGroupPosition)
                            {
                                pos += repeatedHoursList[i].TimesIn;
                                continue;
                            }

                            //TODO try not to modify remove
                            //repeatedHoursList.RemoveAt(index.RepeatedHourGroupPosition);
                            //repeatedHoursList.Insert(i, theHour);
                            if (FindMistake(index.DayOfTheWeek, pos,
                                            timetable[index.RepeatedClassIndex].days[index.DayOfTheWeek]
                                                                               .IndexedHours[index.HourPositionInDay]
                                                                               .Teacher)
                             && FindMistake(index.DayOfTheWeek, index.HourPositionInDay,
                                            timetable[index.RepeatedClassIndex].days[index.DayOfTheWeek]
                                                                               .IndexedHours[pos].Teacher))
                            {
                                hourValids.Add(i);
                            }

                            pos += repeatedHoursList[i].TimesIn;
                        }

                        pos = 0;
                        for (int i = 0; i < originalHoursList.Count; i++)
                        {
                            //check statement useful only the first time
                            if (i == index.OriginalHourGroupPosition)
                            {
                                pos += originalHoursList[i].TimesIn;
                                continue;
                            }

                            //originalHoursList.RemoveAt(index.OriginalHourGroupPosition);
                            //originalHoursList.Insert(i, first);
                            index.OriginalHourGroupPosition = i;
                            if (FindMistake(index.DayOfTheWeek, pos,
                                            timetable[index.OriginalClassIndex].days[index.DayOfTheWeek]
                                                                               .IndexedHours[index.HourPositionInDay]
                                                                               .Teacher)
                             && FindMistake(index.DayOfTheWeek, index.HourPositionInDay,
                                            timetable[index.RepeatedClassIndex].days[index.DayOfTheWeek]
                                                                               .IndexedHours[pos].Teacher))
                            {
                                firstHourValids.Add(i);
                            }
                        }

                        if (hourValids.Count != 0)
                        {
                            repeatedHoursList.Remove(theHour);
                            repeatedHoursList.Insert(hourValids[0], theHour);
                        }
                        else if (firstHourValids.Count != 0)
                        {
                            originalHoursList.Remove(first);
                            originalHoursList.Insert(firstHourValids[0], first);
                        }
                        else
                        {
                            timetable[index.RepeatedClassIndex] = RandWeek(
                                teachers, oldClasses[index.RepeatedClassIndex]);
                            break;
                        }
                    }

                    t++;
                    if (indexes.Count <= target)
                    {
                        break;
                    }

                    if (t == timesUntilReset)
                        break;
                }

                FindMistakesALL();
                //Console.WriteLine(indexes.Count);
                min = Math.Min(min, indexes.Count);
            } while (indexes.Count >= target && watch.ElapsedMilliseconds < 8000);
            //indexes.Count != 4 && watch.ElapsedMilliseconds < 1000
            FindMistakesALL();
            //Console.WriteLine();
            //PrintTable();
            //Console.WriteLine(Math.Min(min, indexes.Count));
            //Console.WriteLine();
            int ti = 0;
            timesUntilReset = 5;
            while (true)
            {
                FindMistakesALL();
                foreach (var index in indexes)
                {
                    //Number 1 - First to other mistake timetable[indexes[index] / 1000].hours[hour] FLIPPING;
                    //Number 2 Shuffle
                    //Number 3 Special care Shuffle
                    var repeatedHoursList = timetable[index.RepeatedClassIndex].days[index.DayOfTheWeek].Hours;
                    var originalHoursList = timetable[index.OriginalClassIndex].days[index.DayOfTheWeek].Hours;
                    Hour theHour = repeatedHoursList[index.RepeatedHourGroupPosition];
                    Hour first = originalHoursList[index.OriginalHourGroupPosition];
                    List<int> hourValids = new List<int>();
                    List<int> firstHourValids = new List<int>();
                    int pos = 0;
                    for (int i = 0; i < repeatedHoursList.Count; i++)
                    {
                        //check statement useful only the first time
                        if (i == index.RepeatedHourGroupPosition)
                        {
                            pos += repeatedHoursList[i].TimesIn;
                            continue;
                        }

                        //TODO try not to modify remove
                        //repeatedHoursList.RemoveAt(index.RepeatedHourGroupPosition);
                        //repeatedHoursList.Insert(i, theHour);
                        if (FindMistake(index.DayOfTheWeek, pos,
                                        timetable[index.RepeatedClassIndex].days[index.DayOfTheWeek]
                                                                           .IndexedHours[index.HourPositionInDay]
                                                                           .Teacher)
                         && FindMistake(index.DayOfTheWeek, index.HourPositionInDay,
                                        timetable[index.RepeatedClassIndex].days[index.DayOfTheWeek].IndexedHours[pos]
                                                                           .Teacher))
                        {
                            hourValids.Add(i);
                        }

                        pos += repeatedHoursList[i].TimesIn;
                    }

                    pos = 0;
                    for (int i = 0; i < originalHoursList.Count; i++)
                    {
                        //check statement useful only the first time
                        if (i == index.OriginalHourGroupPosition)
                        {
                            pos += originalHoursList[i].TimesIn;
                            continue;
                        }

                        //originalHoursList.RemoveAt(index.OriginalHourGroupPosition);
                        //originalHoursList.Insert(i, first);
                        index.OriginalHourGroupPosition = i;
                        if (FindMistake(index.DayOfTheWeek, pos,
                                        timetable[index.OriginalClassIndex].days[index.DayOfTheWeek]
                                                                           .IndexedHours[index.HourPositionInDay]
                                                                           .Teacher)
                         && FindMistake(index.DayOfTheWeek, index.OriginalHourGroupPosition,
                                        timetable[index.RepeatedClassIndex].days[index.DayOfTheWeek].IndexedHours[pos]
                                                                           .Teacher))
                        {
                            firstHourValids.Add(i);
                        }
                    }

                    if (hourValids.Count != 0)
                    {
                        repeatedHoursList.Remove(theHour);
                        repeatedHoursList.Insert(hourValids[0], theHour);
                    }
                    else if (firstHourValids.Count != 0)
                    {
                        originalHoursList.Remove(first);
                        originalHoursList.Insert(firstHourValids[0], first);
                    }
                    else
                    {
                        continue;
                    }
                }
                ti++;
                if (ti == timesUntilReset || indexes.Count == 0)
                    break;
            }
            return timetable;
        }
    }
}
