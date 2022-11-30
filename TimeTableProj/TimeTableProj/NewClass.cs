using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Text.Json;
using System.Text.Json.Serialization;
using MyTimeTable;
using MyTimeTable.Models;

namespace TimeTableProj
{
    public partial class NewClass : Form
    {
        Helper helper = new Helper();
        public NewClass()
        {
            InitializeComponent();
        }

        private void NewClass_Load(object sender, EventArgs e)
        {
            helper.Read(HoursView, helper.HourGrid);
        }

        private void AddClass_Click(object sender, EventArgs e)
        {
            List<Class> data;
            try
            {
                string jason = File.ReadAllText(helper.Classes);
                data = JsonSerializer.Deserialize<List<Class>>(jason);
            }
            catch (Exception exception)
            {
                data = new List<Class>();
            }
            Dictionary<string, int> hours = new Dictionary<string, int>();
            for (int i = 0; i < HoursView.RowCount-1; i++)
            {
                var row = HoursView.Rows[i];
                int val = 0;
                bool success = int.TryParse(row.Cells[1].Value.ToString(), out val);
                if (!success || row.Cells[1].Value.ToString()=="")
                {
                    row.Cells[1].Value = "";
                    return;
                }
                hours.Add(row.Cells[0].Value.ToString(), int.Parse(row.Cells[1].Value.ToString()));
            }
            data.Add(new Class(name.Text, hours));
            string json = JsonSerializer.Serialize(data);
            File.WriteAllText(helper.Classes, json);
        }
    }
}
