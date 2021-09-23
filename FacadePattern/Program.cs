using System;

namespace FacadePattern
{
    class Program
    {
        static void Main(string[] args)
        {
			ScheduleServer scheduleServer = new ScheduleServer();
			// Older run
			scheduleServer.startBooting();
			scheduleServer.readSystemConfigFile();
			scheduleServer.init();
			scheduleServer.initializeContext();
			scheduleServer.initializeListeners();
			scheduleServer.createSystemObjects();

            Console.WriteLine("Start working......");
			Console.WriteLine("After work done.........");

			scheduleServer.releaseProcesses();
			scheduleServer.destory();
			scheduleServer.destroySystemObjects();
			scheduleServer.destoryListeners();
			scheduleServer.destoryContext();
			scheduleServer.shutdown();

			// Facade Run

			ScheduleServerFacade facadeServer = new ScheduleServerFacade(scheduleServer);
			facadeServer.startServer();

			Console.WriteLine("Start working......");
			Console.WriteLine("After work done.........");

			facadeServer.stopServer();
		}
    }
}
