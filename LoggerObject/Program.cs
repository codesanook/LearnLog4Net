using System;
using System.Threading;
using LoggerObject.Services;
using log4net;
[assembly:log4net.Config.XmlConfigurator]
namespace LoggerObject
{
    class Program
    {
        private static readonly ILog _log = LogManager.GetLogger(typeof (Program));

        static void Main(string[] args)
        {
            _log.Debug("Program Start" );


            var userService = new UserService();
            userService.RegisterNewUser();

            var roleService = new RoleService();
            roleService.AddRoleToUser();


            //_log.DebugFormat("This [{0:000.00}] message",5.00F);
            //if (_log.IsDebugEnabled)
            //{
            //    _log.Debug(ExpensiveMethod());
            //}

        }
        static string ExpensiveMethod()
        {
            Thread.Sleep(5000);
            return "ExpensiveMethod done";
        }

    }
}

