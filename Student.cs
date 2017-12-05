namespace Mod1_Lab1
{
    public class Student
    {
        public string Name { get; set; }

        public Student(string name){
            this.Name = name;
            Count++;
        }

        private static int Count=0;

        public static int CountStudents() => Count;

    }
}