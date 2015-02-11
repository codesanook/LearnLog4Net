using log4net;
using log4net.Config;

[assembly: XmlConfigurator]
namespace LayoutAndPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var log = LogManager.GetLogger(typeof(Program));
            log.Debug("This DEBUG message");
            log.Info("This INFO message");

            log.Warn("This WARN message");
            log.Error("This ERROR message");
            log.Fatal("This FATAL message");

        }


    }
}
