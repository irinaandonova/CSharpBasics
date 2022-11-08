using System;

namespace CSharpBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }

        public class Appliances
        {
            string Color;

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
