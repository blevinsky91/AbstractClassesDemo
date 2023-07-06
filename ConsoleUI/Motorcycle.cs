using System;
namespace ConsoleUI
{
	internal class Motorcycle : Vehicle
	{
        public bool HasSideCart { get; set; } = true;
        public bool IsStretched { get; set; } = false;

        

        public override void DriveAbstract()
        {
            Console.WriteLine("Driving Motorcycle with an abstract method");
        }
        public override void DriveVirtual()
        {
            Console.WriteLine("Driving");
        }
    }
}

