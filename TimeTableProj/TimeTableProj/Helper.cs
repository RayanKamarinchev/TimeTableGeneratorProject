using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace TimeTableProj
{
    public class Helper
    {
        //prefix is ../../../Saves/ on debug
        static string prefix = "";
        public string HourGrid = prefix + "lessons.txt";
        public string Classes = prefix + "classes.json";
        public string Teachers = prefix + "teachers.json";

        public void Read(DataGridView table, string path)
        {
            try
            {
                using (TextReader tr = new StreamReader(path))
                {
                    string line;
                    while ((line = tr.ReadLine()) != null)
                    {
                        table.Rows.Add(line.Split(" ")[0]);
                    }
                    tr.Close();
                }
            }
            catch (Exception exception)
            {
            }
        }

        public void Write(DataGridView table, string path)
        {
            using (TextWriter tw = new StreamWriter(path))
            {
                for (int i = 0; i < table.Rows.Count - 1; i++)
                {
                    tw.Write($"{table.Rows[i].Cells[0].Value.ToString()} 255 255 255");
                    tw.WriteLine();
                }
            }
        }
    }
}
