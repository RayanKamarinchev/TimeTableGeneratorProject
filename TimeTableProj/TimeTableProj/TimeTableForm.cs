using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;
using MyTimeTable;
using MyTimeTable.Models;

namespace TimeTableProj
{
    public partial class TimeTableForm : Form
    {
        private Helper helper = new Helper();
        private Generator gen = new Generator();
        private List<TimeTable> data;
        private Data fakeData = new Data();
        public TimeTableForm()
        {
            InitializeComponent();
        }

        private void Classes_Click(object sender, EventArgs e)
        {
            Classes form = new Classes();
            form.Show();
        }

        private void Hours_Click(object sender, EventArgs e)
        {
            NewHour form = new NewHour();
            form.Show();
        }

        private void Teachers_Click(object sender, EventArgs e)
        {
            Teachers form = new Teachers();
            form.Show();
        }

        private void TimeTable_Load(object sender, EventArgs e)
        {
            ResizeMenu();
        }

        void ApplyBorder(Panel pan, PaintEventArgs e)
        {
            int thickness = 2; //it's up to you
            int halfThickness = thickness / 2;
            using (Pen p = new Pen(Color.Black, thickness))
            {
                e.Graphics.DrawRectangle(p, new Rectangle(halfThickness,
                                                          halfThickness,
                                                          pan.ClientSize.Width - thickness,
                                                          pan.ClientSize.Height - thickness));
            }
        }

        private void generate_Click(object sender, EventArgs e)
        {
            data = gen.Generate(helper.Classes, helper.Teachers);
            VisualizeTimeTable();
        }


        private void TimeTableForm_Resize(object sender, EventArgs e)
        {
            
        }

        public void VisualizeTimeTable()
        {
            List<Class> classes = JsonSerializer.Deserialize<List<Class>>(File.ReadAllText(helper.Classes));
            int i = 0;
            int startHeight = -3;
            int width = mon.Width;
            List<int> widths = new List<int>();
            widths.Add(0);
            int ad = width % 7;
            for (int j = 1; j < 8; j++)
            {
                widths.Add(width / 7 + (ad >= j ? 1 : 0));
            }

            int classHeight = 49;
            bool lastHours = false;
            List<string[]> hours = new List<string[]>();
            using (TextReader tr = new StreamReader(helper.HourGrid))
            {
                string line;
                while ((line = tr.ReadLine()) != null)
                {
                    hours.Add(line.Split(" "));
                }
                tr.Close();
            }
            TimeTableField.Controls.Clear();
            foreach (var timeTable in data)
            {
                Label c = new Label();
                c.AutoSize = false;
                c.Location = new Point(0, startHeight + i * classHeight);
                c.Height = classHeight;
                c.Width = Offset.Width;
                c.TextAlign = ContentAlignment.MiddleCenter;
                c.Text = classes[i].Name;
                c.Controls.Add(new Label()
                { Height = 1, Dock = DockStyle.Top, BackColor = Color.Black });
                c.Controls.Add(new Label()
                { Width = 1, Dock = DockStyle.Right, BackColor = Color.Black });
                TimeTableField.Controls.Add(c);
                int d = 0;
                foreach (var day in timeTable.days)
                {
                    int h = 0;
                    foreach (var hour in day.IndexedHours)
                    {
                        Label l = new Label();
                        l.AutoSize = false;
                        l.Location = new Point(widths.Take(h + 1).Sum() + (width + 1) * d + Offset.Width, startHeight + classHeight * i + 1);
                        l.Height = classHeight;
                        l.Width = widths[h + 1] + 1;
                        l.TextAlign = ContentAlignment.MiddleCenter;
                        l.Text = hour.Subject;
                        if (hour.Subject.Length > 4)
                        {
                            l.Text = hour.Subject.Substring(0, 4);
                        }
                        var color = hours.FirstOrDefault(h => h[0] == hour.Subject);
                        if (!(color is null))
                        {
                            l.BackColor = Color.FromArgb(int.Parse(color[1]), int.Parse(color[2]), int.Parse(color[3]));
                        }
                        l.Controls.Add(new Label()
                        { Height = 1, Dock = DockStyle.Bottom, BackColor = Color.Black });
                        if (h != 6 || d != 4)
                        {
                            l.Controls.Add(new Label()
                            { Width = 1, Dock = DockStyle.Right, BackColor = Color.Black });
                        }
                        if (0 == h && lastHours)
                        {
                            l.Controls.Add(new Label()
                            { Width = 1, Dock = DockStyle.Left, BackColor = Color.Black });
                            l.Location = new Point(l.Location.X - 1, l.Location.Y);
                            l.Width++;
                        }

                        if (i != 0 && h == 6)
                        {
                            if (data[i - 1].days[d].IndexedHours.Count != 7)
                            {
                                l.Controls.Add(new Label()
                                { Height = 1, Dock = DockStyle.Top, BackColor = Color.Black });
                                l.Height++;
                                l.Location = new Point(l.Location.X, l.Location.Y - 1);
                            }
                        }
                        TimeTableField.Controls.Add(l);
                        h++;
                    }

                    lastHours = h == 6;
                    d++;
                }
                i++;
            }
        }

        private void Content_Paint(object sender, PaintEventArgs e)
        {

        }

        private void design_Click(object sender, EventArgs e)
        {
            Design form = new Design();
            form.Show();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void label33_Click(object sender, EventArgs e)
        {

        }

        private void label48_Click(object sender, EventArgs e)
        {

        }

        private void label49_Click(object sender, EventArgs e)
        {

        }

        private void label54_Click(object sender, EventArgs e)
        {

        }

        private void label55_Click(object sender, EventArgs e)
        {

        }

        private void label35_Click(object sender, EventArgs e)
        {

        }

        private void TimeTableForm_ResizeEnd(object sender, EventArgs e)
        {
            ResizeMenu();
        }

        public void ResizeMenu()
        {
            mon.Width = (Content.Width - 77) / 5;
            tue.Width = (Content.Width - 77) / 5;
            wed.Width = (Content.Width - 77) / 5;
            thu.Width = (Content.Width - 77) / 5;
            fri.Width = (Content.Width - 77) / 5;
            int partSize = mon.Width / 7;
            int add = mon.Width % 7;
            Mon1.Width = partSize + (add >= 1 ? 1 : 0);
            Mon2.Width = partSize + (add >= 2 ? 1 : 0) - 1;
            Mon3.Width = partSize + (add >= 3 ? 1 : 0) - 1;
            Mon4.Width = partSize + (add >= 4 ? 1 : 0) - 1;
            Mon5.Width = partSize + (add >= 5 ? 1 : 0) - 1;
            Mon6.Width = partSize + (add >= 6 ? 1 : 0) - 1;
            Mon7.Width = partSize + (add >= 7 ? 1 : 0) - 1;

            Tue1.Width = partSize + (add >= 1 ? 1 : 0);
            Tue2.Width = partSize + (add >= 2 ? 1 : 0) - 1;
            Tue3.Width = partSize + (add >= 3 ? 1 : 0) - 1;
            Tue4.Width = partSize + (add >= 4 ? 1 : 0) - 1;
            Tue5.Width = partSize + (add >= 5 ? 1 : 0) - 1;
            Tue6.Width = partSize + (add >= 6 ? 1 : 0) - 1;
            Tue7.Width = partSize + (add >= 7 ? 1 : 0) - 1;

            Wed1.Width = partSize + (add >= 1 ? 1 : 0);
            Wed2.Width = partSize + (add >= 2 ? 1 : 0) - 1;
            Wed3.Width = partSize + (add >= 3 ? 1 : 0) - 1;
            Wed4.Width = partSize + (add >= 4 ? 1 : 0) - 1;
            Wed5.Width = partSize + (add >= 5 ? 1 : 0) - 1;
            Wed6.Width = partSize + (add >= 6 ? 1 : 0) - 1;
            Wed7.Width = partSize + (add >= 7 ? 1 : 0) - 1;

            Thu1.Width = partSize + (add >= 1 ? 1 : 0);
            Thu2.Width = partSize + (add >= 2 ? 1 : 0) - 1;
            Thu3.Width = partSize + (add >= 3 ? 1 : 0) - 1;
            Thu4.Width = partSize + (add >= 4 ? 1 : 0) - 1;
            Thu5.Width = partSize + (add >= 5 ? 1 : 0) - 1;
            Thu6.Width = partSize + (add >= 6 ? 1 : 0) - 1;
            Thu7.Width = partSize + (add >= 7 ? 1 : 0) - 1;

            Fri1.Width = partSize + (add >= 1 ? 1 : 0);
            Fri2.Width = partSize + (add >= 2 ? 1 : 0) - 1;
            Fri3.Width = partSize + (add >= 3 ? 1 : 0) - 1;
            Fri4.Width = partSize + (add >= 4 ? 1 : 0) - 1;
            Fri5.Width = partSize + (add >= 5 ? 1 : 0) - 1;
            Fri6.Width = partSize + (add >= 6 ? 1 : 0) - 1;
            Fri7.Width = partSize + (add >= 7 ? 1 : 0) - 1;
            if (!(data is null))
            {
                VisualizeTimeTable();
            }
        }

        private void TimeTableForm_SizeChanged(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                ResizeMenu();
            }
        }
    }
}
