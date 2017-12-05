using System;

namespace Mod1_Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
        /*
        // Instantinating an object of Car
        var MyPeugeot = new Car();
        MyPeugeot.Color = "White";
        MyPeugeot.Year = 2017;
        MyPeugeot.Mileage = 5001;

        Console.WriteLine($"This car is painted {MyPeugeot.Color}, was built in {MyPeugeot.Year}");

        var RedChevy = new Car("Red",1985);

        Console.WriteLine($"This RedChevy car is {RedChevy.Color}.");

        Console.WriteLine($"We have total {Car.CountCars()} cars.");
        */

        // Instantiate a UProgram object called Information Technology.
        var ITProgram = new UProgram("Information Technology");
        
        // Instantiate a Degree object, such as Bachelor, inside the UProgram object.
        ITProgram.Degree = new Degree("Bachelor");
        
        // Instantiate a Course object called Programming with C# inside the Degree object.
        ITProgram.Degree.Course = new Course("Programming with C#");

        // Instantiate your three students in this Course object.
        ITProgram.Degree.Course.Students.Add(new Student("Viktors"));
        ITProgram.Degree.Course.Students.Add(new Student("Inese"));
        ITProgram.Degree.Course.Students.Add(new Student("Aivars"));
        
        // Instantiate at least one Teacher object in the Course object
        ITProgram.Degree.Course.Teachers.Add(new Teacher("Gatis"));

        // Using Console.WriteLine statements, output the name of the program and the degree it contains
        Console.WriteLine($"Current programm is {ITProgram.Name} with {ITProgram.Degree.Name} degree.");
        
        // Using Console.WriteLine statements, output the name of the course in the degree
        Console.WriteLine($"Course name: {ITProgram.Degree.Course.Name}.");
        
        // Using Console.WriteLine statements, output the count of the number of students in the course.
        Console.WriteLine($"Students count: {Student.CountStudents()}");
        }
    }
}
