using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    internal class Motorcycle : Vehicle
    {
        public Motorcycle()
        {

        }
        public bool HasSideCar { get; set; } = true;

        public override void DriveAbstract()
        {
            Console.WriteLine("Motorcycle is in drive.");
        }
        public override void DriveVirtual()
        {
            Console.WriteLine($"{GetType().Name} is a {GetType().BaseType.Name} virtually in dirve");
        }
    }
    

}
