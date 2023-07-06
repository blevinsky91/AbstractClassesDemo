using System;
namespace ConsoleUI
{
	internal class Car : Vehicle
	{
        public bool HasSunRoof { get; set; } = true;
        public bool HasBigWheels { get; set; } = true;

        

        public override void DriveAbstract()
        {
            Console.WriteLine("Driving a Car with abstract method");
        }
    }
}

