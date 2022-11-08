using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasics
{
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
}
