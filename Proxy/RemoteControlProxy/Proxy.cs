using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyProject.RemoteControlProxy
{
    public class Proxy : IDriver
    {
        private AccessLevel _accessLevel;
        private IDriver _driver;

        public Proxy(IDriver driver, AccessLevel accessLevel)
        {
            _accessLevel = accessLevel;
            _driver = driver ?? throw new ArgumentNullException(nameof(driver));
        }

        public void Operation()
        {
            if (CheckAccessLevel())
            {
                _driver.Operation();
            }
            else
            {
                Console.WriteLine("Недостаточный уровень доступа");
            }
        }
        private bool CheckAccessLevel()
        {
            if (_accessLevel == AccessLevel.Admin)
            {
                return true;
            }
            return false;
        }
    }
}
