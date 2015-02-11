using System;
using log4net;

[assembly:log4net.Config.XmlConfigurator]
namespace Filter
{
    class Program
    {
        private static ILog Log = LogManager.GetLogger(typeof (Program));

        static void Main(string[] args)
        {
            Log.Debug( "This is a debug message" );
            Log.Info("This is a info message");
            Log.Warn("This is a warn message");
            Log.Error("This is a error message");
            Log.Fatal("This is a fatal message");
           
            Log.Info("My home zip code is 10400");
 
            Console.ReadLine();
        }
    }
}

