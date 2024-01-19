using _19_01_24_LAB;
using System.ComponentModel.Design;

string brand;
string model;
string millageStr;
double millage;

do
{
    Console.WriteLine("Enter Brand: ");
    brand = Console.ReadLine();
} while (string.IsNullOrWhiteSpace(brand));

do
{
    Console.WriteLine("Enter Model: ");
    model = Console.ReadLine();
} while (string.IsNullOrWhiteSpace(model));

do
{
    Console.WriteLine("Enter Millage: ");
    millageStr = Console.ReadLine();
} while (!double.TryParse(millageStr, out millage) || millage<0);

string fuelCapacityStr;
double fuelCapacity;

do
{
    Console.WriteLine("Enter Fuel Capacity: ");
    fuelCapacityStr = Console.ReadLine();
} while (!double.TryParse(fuelCapacityStr, out fuelCapacity) || fuelCapacity<0);
string currentFuelStr;
double currentFuel;
do
{
    Console.WriteLine("Enter Current Fuel: ");
    currentFuelStr = Console.ReadLine();
} while (!double.TryParse(currentFuelStr, out currentFuel) || currentFuel<0);



Car car = new Car();
car.Brand = brand;
car.Model = model;
car.Millage = millage;
car.FuelCapacity = fuelCapacity;
car.CurrentFuel = currentFuel;


Bicycle bicycle= new Bicycle();
string opr;

do
{
    Menu:
    Console.WriteLine("\tMENU\t\n");
    Console.WriteLine("1. Drive a car");
    Console.WriteLine("2. Drive a bicycle");
    Console.WriteLine("3. Show info about car");
    Console.WriteLine("4. Show info about bicycle");
    Console.WriteLine("5. ReFuel");
    Console.WriteLine("0. Exit");

    Console.WriteLine("Emeliyyati Daxil Et: ");
    opr = Console.ReadLine();

    switch (opr)
    {

        case "1":
            try
            {
            car.Drive();
            }
            catch
            {
                Console.WriteLine("Benzin catmadi!");
                goto Menu;
            }
            break;
        case "2":
            bicycle.Drive();
            break;
        case "3":
            car.Showinfo();
            break;
        case "4":
            bicycle.Showinfo();
            break;
        case "5":
            Console.WriteLine(Balanis daxil et:);
            car.Refuel();
            break;
        case "0":
            Console.WriteLine("Proqram Bitdi!");
            break;
        default:
            Console.WriteLine("Yanlis Emeliyyat!");
            break;
    }
} while (opr == "0");