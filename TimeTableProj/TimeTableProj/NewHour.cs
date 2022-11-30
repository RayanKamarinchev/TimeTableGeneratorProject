using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using MyTimeTable.Models;
using static System.Net.WebRequestMethods;

namespace TimeTableProj
{
    public partial class NewHour : Form
    {
        private Helper helper = new Helper();
        public NewHour()
        {
            InitializeComponent();
        }

        private void NewHour_Load(object sender, EventArgs e)
        {
            helper.Read(HourTable, helper.HourGrid);
        }

        private void NewHour_FormClosing(object sender, FormClosingEventArgs e)
        {
            helper.Write(HourTable, helper.HourGrid);
        }
    }
}
