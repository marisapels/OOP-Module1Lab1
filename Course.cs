using System.Collections.Generic;

namespace Mod1_Lab1
{
    public class Course
    {
        public string Name { get; set; }
        public IList<Student> Students { get; set; }
        public IList<Teacher> Teachers { get; set; }

        public Course(string name)
        {
            this.Name = name;
            this.Students = new List<Student>();
            this.Teachers = new List<Teacher>();
        }
    }
}