using System;
namespace ConsoleUI
{
	internal abstract class Vehicle
	{
		public string Year { get; set; } = "2010";
		public string Make { get; set; } = "Toyota";
		public string Model { get; set; } = "Corolla";
	
		

	public abstract void DriveAbstract();

	public virtual void DriveVirtual()
		{
			Console.WriteLine("This is the default implementation");
		}
		

    



	}
}

