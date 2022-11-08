using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasics
{
    public class Dishwasher : Appliance
    {
        public Dishwasher(string owner, string brand) : base(owner, brand)
        {
            Brand = brand;
        }

        public int Capasity { get; }

        public override void Use()
        {
            Console.WriteLine("Dishwasher is washing dishes");
        }
        public void Wash()
        {
            Console.WriteLine("Dishwasher is using self cleaning program");
        }
        public void Wash(uint dishes)
        {
            if (dishes == 0)
            {
                Console.WriteLine("Dishwasher is washing a dish");
            }
            else
            {
                Console.WriteLine($"Dishwasher is washing {dishes}");

            }
        }
    }
}
