namespace Mod1_Lab1
{
    // Declaring the Car Class
    // This class has 3 properties: Color, Year and Mileage
    public class Car
    {
        private static int instances = 0;
        public string Color { get; set; }
        public int Year { get; set; }
        public int Mileage { get; set; }

        public Car(string color, int year)
        {
            this.Color = color;
            this.Year = year;
            instances++;
        }

        public Car()
        { 
            instances++;
        }

        public static int CountCars()
        {
            return instances;
        }
    }
}