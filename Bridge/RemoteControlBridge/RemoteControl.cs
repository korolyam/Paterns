using RemoteControlClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.RemoteControlBridge
{
    public class RemoteControl
    {
        protected Power _power;
        protected DriverForRemoteControl _driver;

        public RemoteControl(Power power, DriverForRemoteControl driver)
        {
            _power = power ?? throw new ArgumentNullException(nameof(power));
            _driver = driver ?? throw new ArgumentNullException(nameof(driver));
        }

        public virtual void Use()
        {
            _power.TurnOn();
            _driver.Operation();
            _power.TurnOff();
        }
    }
}
