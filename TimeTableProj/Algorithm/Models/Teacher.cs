using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTimeTable.Models
{
    public class Teacher
    {
        public List<Class> classes { get; set; }
        public string Subject { get; set; }
        public string Name { get; set; }
        public Teacher(List<Class> classes, string subject, string name)
        {
            this.classes = classes;
            this.Subject = subject;
            this.Name = name;
        }

        public Teacher()
        {
            
        }
    }
}
