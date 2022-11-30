using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Algorithm.Models
{
    public class TeacherDTO
    {
        public string Name { get; set; }
        public string Subject { get; set; }
        [JsonPropertyName("classes")]
        public List<string> Classes { get; set; }

        public TeacherDTO()
        {
            
        }

        public TeacherDTO(string name, string subjects, List<string> classes)
        {
            Name = name;
            Subject = subjects;
            Classes = classes;
        }
    }
}
