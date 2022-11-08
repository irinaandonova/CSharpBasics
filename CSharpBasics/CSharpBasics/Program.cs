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
    }
}
