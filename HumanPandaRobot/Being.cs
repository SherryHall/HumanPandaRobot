using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanPandaRobot
{
	abstract class Being
	{
		public string Name { get; set; }
		public string Greeting { get; set; }

		public Being(string name, string greeting)
		{
			this.Name = name;
			this.Greeting = greeting;
		}
		public string DisplayName()
		{
			return this.Name;
		}

		public string DisplayGreeting()
		{
			return this.Greeting;
		}
	}
}
