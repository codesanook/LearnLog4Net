using System;
using System.Threading;
using log4net;
using log4net.Config;

//[assembly: XmlConfigurator]
namespace Log4NetLevel
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlConfigurator.Configure();

            var log = LogManager.GetLogger(typeof(Program));

            log.Debug("This DEBUG message");
            log.Info("This INFO message");
            log.Error("This ERROR message");

            log.WarnFormat("This [{0}] message","WARN");
            log.FatalFormat("This [{0}] message","FATAL");
        }


    }
}
