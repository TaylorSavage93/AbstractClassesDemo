using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    internal class Car : Vehicle
    {
        public Car()
        {
        }
        public override void DriveAbstract()
        {
            Console.WriteLine("This car is in drive");
        }
        public bool HasTrunk { get; set; }


    }
}
