using System;

class Automobile
{
    //private fields
    private int year;
    private string make;
    private string model;
    private int doors;
    private string roof;

    //properties for encapsulation
    public int Year
    {
        get { return year; }
        set { year = value; }
    }

    public string Make
    {
        get { return make; }
        set { make = value; }
    }

    public string Model
    {
        get { return model; }
        set { model = value; }
    }

    public int Doors
    {
        get { return doors; }
        set
        {
            if (value == 2 || value == 4)
                doors = value;
            else
                throw new ArgumentException("Doors must be 2 or 4.");
        }
    }

    public string Roof
    {
        get { return roof; }
        set
        {
            if (value.ToLower() == "solid" || value.ToLower() == "sun roof")
                roof = value;
            else
                throw new ArgumentException("Roof must be 'solid' or 'sun roof'.");
        }
    }
}

class Program
{
    static void Main()
    {
        Automobile car = new Automobile();

        Console.WriteLine("Enter the car's information:");

        Console.Write("Year: ");
        car.Year = int.Parse(Console.ReadLine());

        Console.Write("Make: ");
        car.Make = Console.ReadLine();

        Console.Write("Model: ");
        car.Model = Console.ReadLine();

        Console.Write("Number of doors (2 or 4): ");
        car.Doors = int.Parse(Console.ReadLine());

        Console.Write("Type of roof (solid or sun roof): ");
        car.Roof = Console.ReadLine();

        Console.WriteLine("\n--- Vehicle Information ---");
        Console.WriteLine("Vehicle type: car");
        Console.WriteLine("Year: " + car.Year);
        Console.WriteLine("Make: " + car.Make);
        Console.WriteLine("Model: " + car.Model);
        Console.WriteLine("Number of doors: " + car.Doors);
        Console.WriteLine("Type of roof: " + car.Roof);
    }
}
