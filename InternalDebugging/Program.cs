using System;
using log4net;
using log4net.Config;

//[assembly: XmlConfigurator]
namespace InternalDebugging
{
    class Program
    {
        static void Main(string[] args)
        {

            XmlConfigurator.Configure();
            var log = LogManager.GetLogger(typeof(Program));
            log.Debug("Program start");





        }
    }
}
