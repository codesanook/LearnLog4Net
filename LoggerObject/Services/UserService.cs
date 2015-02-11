using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LoggerObject.Repositories;
using log4net;

namespace LoggerObject.Services
{
    class UserService
    {
        private ILog _log = LogManager.GetLogger(typeof(UserService));
        public void RegisterNewUser()
        {
            _log.Info("RegisterNewUser");

            var repository = new UserRepository();
            repository.Add();

            _log.Info("RegisterNewUser successfully");
        }
    }
}
