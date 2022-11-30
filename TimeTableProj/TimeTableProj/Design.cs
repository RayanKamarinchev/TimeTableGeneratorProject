using MyTimeTable.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Text;
using System.Windows.Forms;

namespace TimeTableProj
{
    public partial class Design : Form
    {
        private Helper helper = new Helper();
        List<string[]> hours = new List<string[]>();
        public Design()
        {
            InitializeComponent();
        }


        private void Design_Load(object sender, EventArgs e)
        {
            string[] data = new string[4];
            void PickColor(object sender, EventArgs e)
            {
                colorDialog1.ShowDialog();
                Button btn = (Button)sender;
                btn.BackColor = colorDialog1.Color;
                int i = int.Parse(btn.Name.Substring(3, btn.Name.Length - 3));
                hours[i][1] = colorDialog1.Color.R.ToString();
                hours[i][2] = colorDialog1.Color.G.ToString();
                hours[i][3] = colorDialog1.Color.B.ToString();
            }
            try
            {
                using (TextReader tr = new StreamReader(helper.HourGrid))
                {
                    string line;
                    int i = 0;
                    while ((line = tr.ReadLine()) != null)
                    {
                        Label l = new Label();
                        l.Location = new Point(30, i * 30);
                        data = line.Split(" ");
                        l.Text = data[0];
                        Controls.Add(l);
                        Button btn = new Button();
                        btn.Name = "btn" + i;
                        btn.Location = new Point(200, i * 30);
                        btn.Size = new Size(60, 20);
                        btn.BackColor = Color.FromArgb(int.Parse(data[1]), int.Parse(data[2]), int.Parse(data[3]));
                        btn.Click += new EventHandler(PickColor);
                        Controls.Add(btn);
                        hours.Add(data);
                        i++;
                    }
                    tr.Close();
                }
            }
            catch (Exception exception)
            {
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (TextWriter tw = new StreamWriter(helper.HourGrid))
            {
                for (int i = 0; i < hours.Count; i++)
                {
                    tw.Write($"{hours[i][0]} {hours[i][1]} {hours[i][2]} {hours[i][3]}");
                    tw.WriteLine();
                }
            }
            Close();
        }

        private void Design_FormClosing(object sender, FormClosingEventArgs e)
        {
            using (TextWriter tw = new StreamWriter(helper.HourGrid))
            {
                for (int i = 0; i < hours.Count; i++)
                {
                    tw.Write($"{hours[i][0]} {hours[i][1]} {hours[i][2]} {hours[i][3]}");
                    tw.WriteLine();
                }
            }

            TimeTableForm f = (TimeTableForm)Application.OpenForms[0];
            f.ResizeMenu();
        }
    }
}
