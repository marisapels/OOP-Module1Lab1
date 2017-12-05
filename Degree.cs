namespace Mod1_Lab1
{
    public class Degree
    {
        public string Name { get; set;}

        // The Lab requests only one Course for Degree
        public Course Course { get; set; }
        
        public Degree(string name)
        {
            this.Name = name;
        }
    }
}