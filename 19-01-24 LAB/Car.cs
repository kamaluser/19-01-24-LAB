using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_01_24_LAB
{
    internal class Car:Vehicle, IRefuel
    {
        public double FuelCapacity { get; set; }
        public double CurrentFuel { get; set; }

        public override void Drive()
        {
            double km;
            string kmStr;

            do
            {
                Console.WriteLine("KM daxil edin: ");
                kmStr = Console.ReadLine();
            } while (!double.TryParse(kmStr, out km));


            double fuelFor1Km = km / 5;


            if (CurrentFuel < fuelFor1Km * km)
            {
                throw new Exception("Benzinin catmir!");
            }
            
            

            if (CurrentFuel<fuelFor1Km)
            {
                throw new Exception("BENZIN YOXDU KASIB !");
            }
            else
            {
                CurrentFuel -= fuelFor1Km;
            }
            
            Millage+=km;
            Console.WriteLine($"Current Millage: {Millage}");
            Console.WriteLine($"Current Fuel: {CurrentFuel}");
        }
        public override void Showinfo()
        {
            Console.WriteLine($"Brand: {Brand},\n Model: {Model},\n Millage: {Millage},\n Fuel Capacity = {FuelCapacity},\n Current Fuel: {CurrentFuel}");
        }

        public void Refuel()
        {
            

            CurrentFuel = FuelCapacity;
        }
    }
}
