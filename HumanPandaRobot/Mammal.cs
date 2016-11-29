using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanPandaRobot
{
	abstract class Mammal : Being
	{
		bool ASleep { get; set; } = false;
		
		public Mammal(string name, string greeting)
			:base (name, greeting)
		{

		}
		
		public void Eat(string food)
		{
			Console.WriteLine($"{this.DisplayName()} says: Yum, I ate {food}");
		}
		public void GoToSleep()
		{
			ASleep = true;
		}
		public void WakeUp()
		{
			ASleep = false;
		}

		public override bool IsASleep()
		{
			return this.ASleep;
		}
	}
}
