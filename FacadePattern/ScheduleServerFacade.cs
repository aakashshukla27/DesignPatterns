using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    class ScheduleServerFacade
    {
        private readonly ScheduleServer scheduleServer;
        public ScheduleServerFacade(ScheduleServer scheduleServer)
        {
            this.scheduleServer = scheduleServer;
        }

		public void startServer()
		{
			scheduleServer.startBooting();
			scheduleServer.readSystemConfigFile();
			scheduleServer.init();
			scheduleServer.initializeContext();
			scheduleServer.initializeListeners();
			scheduleServer.createSystemObjects();
		}

		public void stopServer()
		{
			scheduleServer.releaseProcesses();
			scheduleServer.destory();
			scheduleServer.destroySystemObjects();
			scheduleServer.destoryListeners();
			scheduleServer.destoryContext();
			scheduleServer.shutdown();
		}
	}
}
