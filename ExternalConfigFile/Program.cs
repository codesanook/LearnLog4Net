using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using log4net;
//[assembly: log4net.Config.XmlConfigurator(ConfigFile = "log4net.xml", Watch = true)]
[assembly: log4net.Config.XmlConfigurator(ConfigFileExtension = "log4net", Watch = true)]
namespace ExternalConfigFile
{
    public class Program
    {
        private static ILog _log = LogManager.GetLogger(typeof(Program));

        static void Main(string[] args)
        {
            _log.Debug("program started");
        }
    }
}
