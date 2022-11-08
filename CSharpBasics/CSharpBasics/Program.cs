using System;

namespace CSharpBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }

        public class Appliance
        {
            string Color;
            string Room;

            public Appliance(string color, string room)
            {
                Color = color;
                Room = room;
            }

            public void Use()
            {
                Console.WriteLine($"Appliance is in use");
            }
            public void CleanAppliance()
            {
                Console.WriteLine($"Clean applience");
            }
        }

        

    }
}
