using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;
using Algorithm.Models;
using MyTimeTable.Models;

namespace TimeTableProj
{
    public partial class NewTeacher : Form
    {
        private Helper helper = new Helper();
        public NewTeacher()
        {
            InitializeComponent();
        }

        private void NewTeacher_Load(object sender, EventArgs e)
        {
            ClassChoice.Items.AddRange(JsonSerializer.Deserialize<List<Class>>(
                                           File.ReadAllText(helper.Classes))
                                                     .Select(c => c.Name)
                                                     .ToArray());
            using (TextReader tr = new StreamReader(helper.HourGrid))
            {
                string line;
                while ((line = tr.ReadLine()) != null)
                {
                    subject.Items.Add(line.Split(" ")[0]);
                }
                tr.Close();
            }
        }

        private void AddClass_Click(object sender, EventArgs e)
        {
            List<string> classes = ClassChoice.CheckedItems.Cast<string>().ToList();
            if (subject.Text == "" || name.Text == "")
            {
                return;
            }
            TeacherDTO teacher = new TeacherDTO(name.Text, subject.Text, classes);
            List<TeacherDTO> data;
            try
            {
                string jason = File.ReadAllText(helper.Teachers);
                data = JsonSerializer.Deserialize<List<TeacherDTO>>(jason);
            }
            catch (Exception exception)
            {
                data = new List<TeacherDTO>();
            }
            data.Add(teacher);
            string json = JsonSerializer.Serialize(data);
            File.WriteAllText(helper.Teachers, json);
            Close();
        }

        private void NewTeacher_FormClosing(object sender, FormClosingEventArgs e)
        {
            List<string> classes = ClassChoice.CheckedItems.Cast<string>().ToList();
            if (subject.Text == "" || name.Text == "")
            {
                return;
            }
            TeacherDTO teacher = new TeacherDTO(name.Text, subject.Text, classes);
            List<TeacherDTO> data;
            try
            {
                string jason = File.ReadAllText(helper.Teachers);
                data = JsonSerializer.Deserialize<List<TeacherDTO>>(jason);
            }
            catch (Exception exception)
            {
                data = new List<TeacherDTO>();
            }
            data.Add(teacher);
            string json = JsonSerializer.Serialize(data);
            File.WriteAllText(helper.Teachers, json);
        }
    }
}
