using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanPandaRobot
{
	// Homework for week 4 Day 1
	class Program
	{
		static void Main(string[] args)
		{
			List<Being> BeingList = new List<Being>();
			List<Mammal> MammalList = new List<Mammal>();
			// Create a Human
			var human1 = new Human("James", "Hi, how are you.");
			BeingList.Add(human1);
			MammalList.Add(human1);

			human1.Eat("Pizza");
			human1.GoToSleep();
			human1.WakeUp();
			human1.GoToSleep();

			// Create a Panda
			var panda1 = new Panda("Teddy", "EeeeW eeeew bark.");
			BeingList.Add(panda1);
			MammalList.Add(panda1);

			panda1.Eat("Tree Leaves");
			panda1.GoToSleep();

			// Create a Robot
			var robot1 = new Robot("Tobor", "How may I serve you.", "Terminator");
			BeingList.Add(robot1);

			robot1.StartUp();
			if (robot1.IsTerminator())
			{
				Console.WriteLine($"{robot1.DisplayName()} says: I'm a Terminator. Be very afraid!");
			}
			robot1.ShutDown();


			foreach (Being item in BeingList)
			{

			Console.WriteLine($"{item.DisplayName()} says: {item.DisplayGreeting()}.");
			if (item.IsASleep())
			{
				string activity = (item.DisplayType() == "Robot" ? "Shut Down" : "Sleeping");
				Console.WriteLine($"{ item.DisplayName()} is {activity}");
			}

			}

			Console.ReadLine();

		}
	}
}
