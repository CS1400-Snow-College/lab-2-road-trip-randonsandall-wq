using System;

class Program
{
    static void Main()
    {
        //Show the intro lines
        Console.WriteLine("We are going to map out a road trip for Fall Break. I'm going to ask you some specific questions about");
        Console.WriteLine("the trip, and then I'll calculate a trip summary from that information.");

        // recieve info from user
        Console.Write("Where will you be driving? ");
        string destination = Console.ReadLine();

        Console.Write("Who will be driving? ");
        string driver = Console.ReadLine();

        Console.Write("How many miles to get to " + destination + "? ");
        int miles = int.Parse(Console.ReadLine());

        Console.Write("What average speed (MPH) will " + driver + " be travelling? ");
        int averageSpeed = int.Parse(Console.ReadLine());

        Console.Write("How many MPG does your car get? ");
        double mpg = double.Parse(Console.ReadLine());

        Console.Write("How many gallons of gas does your car hold? ");
        double tankCapacity = double.Parse(Console.ReadLine());

        Console.Write("Excluding the driver, how many riders in the car? ");
        int riders = int.Parse(Console.ReadLine());

        Console.Write("What unit of currency ($, £, ¥, €) do you use? ");
        string currency = Console.ReadLine();

        Console.Write("What is the fuel price per gallon (" + currency + ")? ");
        double fuelPrice = double.Parse(Console.ReadLine());

        // Calculate trip values
        double timeHours = (double)miles / averageSpeed;
        int hours = (int)timeHours;
        int minutes = (int)((timeHours - hours) * 60);

        double fuelNeeded = (double)miles / mpg;
        double rangePerTank = tankCapacity * mpg;
        int fuelStops = (int)Math.Ceiling(fuelNeeded / tankCapacity) - 1;

        double fuelCost = fuelNeeded * fuelPrice;
        int totalPeople = riders + 1; // riders + driver
        double costPerPerson = fuelCost / totalPeople;
        double costPerMile = fuelCost / miles;
        double costPerHour = fuelCost / timeHours;

        double averageSongLength = 3.5; // minutes
        int numberOfSongs = (int)(timeHours * 60 / averageSongLength);

        // Display results
        Console.WriteLine();
        Console.WriteLine("Driver:                    " + driver);
        Console.WriteLine("Currency:                  " + currency);
        Console.WriteLine();
        Console.WriteLine("Distance (miles):          " + miles);
        Console.WriteLine("Average Speed (mph):       " + averageSpeed);
        Console.WriteLine("Time Driving:              " + hours + "H " + minutes + "M");
        Console.WriteLine();
        Console.WriteLine("Vehicle Miles per Gallon:  " + mpg);
        Console.WriteLine("Fuel Needed (round trip):  " + fuelNeeded.ToString("F2") + " gallons");
        Console.WriteLine("Range per tank:            " + rangePerTank.ToString("F2"));
        Console.WriteLine("Estimated Fuel Stops:      " + fuelStops);
        Console.WriteLine();
        Console.WriteLine("Gas Price per gallon :     " + currency + fuelPrice.ToString("F2"));
        Console.WriteLine("Fuel Cost:                 " + currency + fuelCost.ToString("F2"));
        Console.WriteLine("Riders (split):            " + totalPeople);
        Console.WriteLine("Cost per person:           " + currency + costPerPerson.ToString("F2") + " (+ Snacks)");
        Console.WriteLine("Cost per mile:             " + currency + costPerMile.ToString("F2"));
        Console.WriteLine("Cost per driving hour      " + currency + costPerHour.ToString("F2"));
        Console.WriteLine();
        Console.WriteLine("Average song length (min): " + averageSongLength);
        Console.WriteLine("Number of songs needed:    " + numberOfSongs);
    }
}
