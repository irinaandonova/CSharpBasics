using System;
using System.Buffers;
using System.Drawing;
using System.Net;

namespace CSharpBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dishwasher dishwasher = new Dishwasher("Irina", "Miele");
            dishwasher.InstallIntoRoom("Kitchen");
            dishwasher.Use();
            dishwasher.Wash();
            dishwasher.Wash(4);
            Stove stove = new Stove("Irina", "Arielli", 250);
            stove.Cook("Fish", 200, 40);
            stove.Cook("Patatoes", 300, 50);
            stove.Repair();
            stove.SellApplience("Nikolay");
        }

        public class Appliance
        {
            public string Color { get; set; }
            public string Room { get; set; }
            public string Owner;
            public string Brand;
            public Appliance(string owner, string brand)
            {
                Owner = owner;
                Brand = brand;
            }

            public virtual void Use()
            {
                Console.WriteLine($"Appliance is in use");
            }
            public void Repair()
            {
                Console.WriteLine($"Applience is repaired");
            }
            public void InstallIntoRoom(string room)
            {
                Room = room;
                Console.WriteLine($"Dishwasher is installed in the {Room}");
            }
            public void SellApplience(string buyer)
            {
                Owner = buyer;
                Console.WriteLine($"Dishwasher is sold to {Owner}");
            }
        }
        //Inheritance
        public class Dishwasher : Appliance
        {
            public Dishwasher(string owner, string brand) : base(owner, brand)
            {
                Brand = brand;
            }

            public int Capasity { get; }
            
            //Overriding
            public override void Use()
            {
                Console.WriteLine("Dishwasher is washing dishes");
            }
            //Overloading
            public void Wash()
            {
                Console.WriteLine("Dishwasher is using self cleaning program");
            }
            public void Wash(uint dishes)
            {
                if(dishes == 0)
                    {
                    Console.WriteLine("Dishwasher is washing a dish");
                    }
                else
                {
                    Console.WriteLine($"Dishwasher is washing {dishes}");

                }
            }
        }

        public class Stove : Appliance
        {
            public int MaxTemperature { get; }
            public Stove(string owner, string brand, int maxTemperature) : base(owner, brand)
            {
                MaxTemperature = maxTemperature;
            }
            public void Cook(string food, uint temperature, uint cookingTime)
            {
                if(temperature > MaxTemperature)
                {
                    Console.WriteLine("Temperature is greater than max temperature for this stove!");
                }
                else
                {
                    Console.WriteLine($"{food} is cooking on {temperature} °C for {cookingTime}");
                }
            }           

        }
    }
}
