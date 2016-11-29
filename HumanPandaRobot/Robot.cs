using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanPandaRobot
{
	class Robot : Being
	{

		bool IsShutDown { get; set; } = true;
		string RobotType { get; set; }

		public Robot(string name, string greeting, string robotType) 
			: base (name, greeting)
		{
			this.RobotType = robotType.Trim().ToLower();
		}
		public void StartUp()
		{
			Console.WriteLine($"{this.Name} Started...");
			IsShutDown = false;
		}

		public void ShutDown()
		{
			Console.WriteLine($"{this.Name} Shutdown...");
			IsShutDown = true;
		}
		public bool IsTerminator()
		{
			if (this.RobotType == "terminator")
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		public override bool IsASleep()
		{
			return this.IsShutDown;
		}
	}
}
