using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanPandaRobot
{
	class Robot : Being
	{

		bool IsShutDown { get; set; } = false;
		string RobotType { get; set; }

		public Robot(string name, string greeting, string robotType) 
			: base (name, greeting)
		{
			this.RobotType = robotType.Trim().ToLower();
		}
		public void StartUp()
		{
			Console.WriteLine("Started...");
			IsShutDown = false;
		}

		public void ShutDown()
		{
			Console.WriteLine("Shutdown...");
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

		public bool IsASleep()
		{
			return this.IsShutDown;
		}
	}
}
