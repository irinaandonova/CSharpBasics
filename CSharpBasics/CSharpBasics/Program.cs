using System;
using System.Buffers;
using System.Drawing;

namespace CSharpBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }

        public class Appliance
        {
            public string Color { get; set; }
            public string Room { get; set; }
            public string Owner;

            public Appliance(string owner)
            {
                Owner = owner;
            }

        public virtual void Use()
            {
                Console.WriteLine($"Appliance is in use");
            }
            public void Repair()
            {
                Console.WriteLine($"Applience is repaired");
            }
        }

        public class Dishwasher : Appliance
        {
            public Dishwasher(string owner) : base(owner)
            {
            }

            public int capasity { get; set; }
            
            public override void Use()
            {
                Console.WriteLine("Dishwasher is washing dishes");
            }

        }
        
        

    }
}
