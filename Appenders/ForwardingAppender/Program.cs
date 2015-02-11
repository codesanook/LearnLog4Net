using System;
using log4net;
using log4net.Config;

[assembly: XmlConfigurator]
namespace SmtpAppender
{
    class Program
    {
        static void Main(string[] args)
        {
            var log = LogManager.GetLogger(typeof(Program));

            log.Debug("program started");

            while (!Console.KeyAvailable)
            {
                log.InfoFormat("The current date & time is: [{0}]", DateTime.Now);
                System.Threading.Thread.Sleep(100);
            }

            log.Debug("exit program");
        }


    }
}
