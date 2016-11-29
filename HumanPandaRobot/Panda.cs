using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanPandaRobot
{
	class Panda : Mammal
	{

		public void Eat(string food)
		{
			Console.WriteLine($"Yum, I ate {food}");
		}
	}
}
