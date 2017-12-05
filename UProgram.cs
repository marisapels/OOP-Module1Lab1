namespace Mod1_Lab1
{
    public class UProgram
    {
        public string Name { get; set; }

        // The Lab requests only one Degree for program
        public Degree Degree { get; set; }
        public UProgram(string name) => this.Name = name;
    }
}