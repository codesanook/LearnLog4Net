using log4net;

namespace LoggerObject.Repositories
{
    public class UserRepository
    {

        private ILog _log = LogManager.GetLogger(typeof(UserRepository));

        public void Add()
        {
            _log.Debug("Add");
        }
    }
}