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

        Teacher myTeacher = new Teacher("Tom");
        ITProgram.Degree.Course.Teachers[0] = myTeacher;

        Console.WriteLine(ITProgram.Degree.Course.Teachers[0].Name);


        // Using Console.WriteLine statements, output the name of the program and the degree it contains
        Console.WriteLine($"Current programm is {ITProgram.Name} with {ITProgram.Degree.Name} degree.");
        
        // Using Console.WriteLine statements, output the name of the course in the degree
        Console.WriteLine($"Course name: {ITProgram.Degree.Course.Name}.");
        
        // Using Console.WriteLine statements, output the count of the number of students in the course.
        Console.WriteLine($"Students count: {Student.CountStudents()}");

        //Create anonymous class
        var anonymousClass1 = new { Name = "Gerry", Age=19 };
        Console.WriteLine(anonymousClass1.Name);
        var anonymousClass2 = new { Name = "Bunny", Age=9 };
        anonymousClass2 = anonymousClass1;
        Console.WriteLine(anonymousClass2.Name);
        
        //Create Manager that is Inharitated from Employee class and add employee to him
        var bigBoss = new Manager();
        bigBoss.ID = 1;
        bigBoss.Name = "Jimm";
        bigBoss.Surname = "White";

        //Nodefinee ka bigBoss.Employees buus jauns employee masiivs ar iekshaa sho vienu Employeeu
        bigBoss.Employees = new[]{new Employee()};
        bigBoss.Employees[0].ID = 2;
        bigBoss.Employees[0].Name = "Mike";
        bigBoss.Employees[0].Surname = "Young";

        //Jaazin saakumaa izmeers, ja grib palielinaat- ieprieksh piemeers ar listiem :D
        //Bet nu ja iipashi izvirtis, var rakstiit kaa zemaak, bez Jamesona nesaprast
        var tempArrayToResize=bigBoss.Employees;
        Array.Resize(ref tempArrayToResize,tempArrayToResize.Length+1);
        bigBoss.Employees=tempArrayToResize;
        bigBoss.Employees[1] = new Employee
        {
            ID = 3,Name="Jhonatan",Surname="Jackson"
        };
        Console.WriteLine($"Manager's name is: {bigBoss.Name} and he has {bigBoss.Employees.Length} employees to manage.");

        //Inicializeeju kompaaniju kaa klientu, bet nu caur interfeisu (customer klasei ir interfeiss Loyality card holder)
        ILoyalityCardHolder Company = new Customer();
        Company.AddPoints(10000);
        Console.WriteLine(Company.TotalPoints);
        
        //vareeja arii taa
        Customer Company2 = new Customer();
        //Add points var, jo metode nav explicita
        Company2.AddPoints(10000);
        //Sho nevar jo taa explicita
        //Console.WriteLine(Company2.TotalPoints);
        }
    }
}
