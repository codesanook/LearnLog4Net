using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using log4net;
using log4net.Appender;
using log4net.Config;
using log4net.Core;
using log4net.Layout;
using log4net.Repository.Hierarchy;

[assembly: XmlConfigurator]

namespace ConfiguringLog4Net
{
    class Program
    {
        static void Main(string[] args)
        {
            //XmlConfigurator.Configure();

            var log = LogManager.GetLogger(typeof(Program));
            log.Debug("This message from XML configuration");
            //ConfigFromCode();
        }

        static void ConfigFromCode()
        {
            //form code
            //create layout
            var layout = new SimpleLayout();
            layout.ActivateOptions();

            //create appender
            var appender = new ConsoleAppender();
            appender.Layout = layout;
            appender.ActivateOptions();
            BasicConfigurator.Configure(appender);


            //get root logger
            var hierarchy = (Hierarchy)LogManager.GetRepository();
            var root = hierarchy.Root;
            root.Level = Level.All;


            var log = LogManager.GetLogger(typeof(Program));
            log.Debug("This message from Code configuration");
        }
    }
}
