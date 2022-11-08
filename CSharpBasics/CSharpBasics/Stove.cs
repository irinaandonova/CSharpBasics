using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasics
{
    public class Stove: Appliance
    {
        public int MaxTemperature { get; }
        public Stove(string owner, string brand, int maxTemperature) : base(owner, brand)
        {
            MaxTemperature = maxTemperature;
        }
        public void Cook(string food, uint temperature, uint cookingTime)
        {
            if (temperature > MaxTemperature)
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
