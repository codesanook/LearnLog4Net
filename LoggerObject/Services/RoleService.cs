using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using log4net;

namespace LoggerObject.Services
{
    class RoleService
    {
        private ILog _log = LogManager.GetLogger(typeof(RoleService));

        public void AddRoleToUser()
        {
            _log.Debug("AddRoleToUser");
            _log.InfoFormat("added user to role successfully");
        }
    }
}
