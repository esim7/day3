using System.Collections.Generic;

namespace WebApplication3.Models
{
    public class Subject
    {
        public int Id { get; set; }
        public string Title  { get; set; }
        public int Room  { get; set; }
        public string CourseName { get; set; }
        public List<Student> Students { get; set; }
    }
}