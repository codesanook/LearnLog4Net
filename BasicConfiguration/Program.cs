using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using log4net;
using log4net.Config;

namespace BasicConfiguration
{
    class Program
    {
        static void Main(string[] args)
        {
            BasicConfigurator.Configure();
            var log = LogManager.GetLogger(typeof(Program));
            log.Debug("Hello from log4net");
        }
    }
}
