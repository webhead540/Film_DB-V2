using System;
using System.Collections.Generic;
using System.Text;
using log4net;
using log4net.Core;
using log4net.Repository;
using log4net.Repository.Hierarchy;
namespace commonLibraries
{
    public class Logging
    {
        public void changeLogLevel(string logLevel)
        {
            Level level = null;

            if (logLevel != null)
            {
                level = LogManager.GetRepository().LevelMap[logLevel];
            }


            if (level == null)
            {
                level = Level.Warn;
            }

            ILoggerRepository[] repositories = LogManager.GetAllRepositories();

            //Configure all loggers to be at the same level.
            foreach (ILoggerRepository repository in repositories)
            {
                repository.Threshold = level;
                Hierarchy hier = (Hierarchy)repository;
                ILogger[] loggers = hier.GetCurrentLoggers();
                foreach (ILogger logger in loggers)
                {
                    ((Logger)logger).Level = level;
                }
            }

            //Configure the root logger.
            Hierarchy h = (Hierarchy)LogManager.GetRepository();
            Logger rootLogger = h.Root;
            rootLogger.Level = level;
            /*switch(logLevel)
            {
                case "All":
                {
                        ((Hierarchy)LogManager.GetRepository()).Root.Level = Level.All;
                        LogManager.GetRepository().Threshold = Level.All;
                    }
            }
            */
            ((Hierarchy)LogManager.GetRepository()).RaiseConfigurationChanged(EventArgs.Empty);
        }
        public string getLoglevel()
        {
            return ((Hierarchy)LogManager.GetRepository()).Root.Level.ToString();
        }
    }
}
