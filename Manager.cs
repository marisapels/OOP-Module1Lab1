namespace Mod1_Lab1
{
    public class Manager: Employee
    {

        public Employee[] Employees { get; set; }

        public Manager()
        {
            // This is acvard- I vould use List instead...
           // this.Employees = new Employee[1];
        }

    }
}