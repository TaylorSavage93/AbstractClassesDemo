using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    internal abstract class Vehicle
    {
        public int Year { get; set; } = 1;
        public string Make { get; set; } = "default";
        public string Model { get; set; } = "default";   

        public abstract void DriveAbstract();
        public virtual void DriveVirtual()
        {
            Console.WriteLine($"This {GetType().Name} is virtually in drive");
        }

    }
}
