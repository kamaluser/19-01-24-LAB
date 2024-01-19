using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_01_24_LAB
{
    internal class Bicycle:Vehicle
    {
        public override void Drive()
        {
            string kmStr;
            double km;
            do
            {
                Console.WriteLine("KM daxil edin: ");
                kmStr = Console.ReadLine();
            } while (!double.TryParse(kmStr, out km));

            Millage +=km;
            Console.WriteLine($"Current Millage: {Millage}");
        }

        public override void Showinfo()
        {
            Console.WriteLine($"Brand: {Brand},\n Model: {Model},\n Millage: {Millage}");
        }
    }
}
