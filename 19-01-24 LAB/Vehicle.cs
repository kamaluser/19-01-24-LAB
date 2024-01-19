using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_01_24_LAB
{
    internal abstract class Vehicle
    {
        
        public string? Model;
        public double Millage = 0;

        public string Brand {
            get
            {
                if (!string.IsNullOrWhiteSpace(Brand)) return Brand;
                throw new Exception("Brand null veya bosluqdur!"); 
            }
            set 
            {
                if (HasOnlyLetter(value))
                {
                    Brand = value;
                }
            }
        }
        public bool HasOnlyLetter(string brand)
        {
            if (!string.IsNullOrWhiteSpace(brand)) return false;
            for (int i = 0; i < brand.Length; i++)
            {
                if (!char.IsLetter(brand[i])) return false;
            }
            return true;
        }

        public abstract void Drive();

        public virtual void Showinfo()
        {
            Console.WriteLine($"Brand: {Brand},\n Model: {Model},\n Millage: {Millage}");
        }
    }
}
