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
			if (this.RobotType.ToLower() == "terminator")
			{
				return true;
			}
			else
			{
				return false;
			}
		}
	}
}
