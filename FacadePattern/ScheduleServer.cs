using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    class ScheduleServer
    {
		public void startBooting()
		{
			Console.WriteLine("Starts booting...");
		}

		public void readSystemConfigFile()
		{
			Console.WriteLine("Reading system config files...");
		}

		public void init()
		{
			Console.WriteLine("Initializing...");
		}

		public void initializeContext()
		{
			Console.WriteLine("Initializing context...");
		}

		public void initializeListeners()
		{
			Console.WriteLine("Initializing listeners...");
		}

		public void createSystemObjects()
		{
			Console.WriteLine("Creating system objects...");
		}

		public void releaseProcesses()
		{
			Console.WriteLine("Releasing processes...");
		}

		public void destory()
		{
			Console.WriteLine("Destorying...");
		}

		public void destroySystemObjects()
		{
			Console.WriteLine("Destroying system objects...");
		}

		public void destoryListeners()
		{
			Console.WriteLine("Destroying listeners...");
		}

		public void destoryContext()
		{
			Console.WriteLine("Destroying context...");
		}

		public void shutdown()
		{
			Console.WriteLine("Shutting down...");
		}
	}
}
