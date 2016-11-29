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
			var human1 = new Human("James", "Hi, how are you.");
			BeingList.Add(human1);

			human1.Eat("Pizza");
			human1.GoToSleep();
			human1.WakeUp();

			var panda1 = new Panda("Teddy", "EeeeW eeeew bark.");
			BeingList.Add(panda1);

			panda1.Eat("Tree Leaves");
			panda1.GoToSleep();

			var robot1 = new Robot("Tobor", "How may I serve you.", "Terminator");
			BeingList.Add(panda1);

			panda1.Eat("Tree Leaves");
			panda1.GoToSleep();

			if (human1.IsASleep())
			{
				string activity = (human1.GetType().Name == "Robot" ? "Shut Down" : "Sleeping");
				Console.WriteLine($"{ human1.DisplayName()} is {activity}");
			}

			Console.WriteLine($"{human1.DisplayName()} says: {human1.DisplayGreeting()}.");

			Console.ReadLine();

		}
	}
}
