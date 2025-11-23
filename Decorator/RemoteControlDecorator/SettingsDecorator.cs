using RemoteControlClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.RemoteControlDecorator
{
    public class SettingsDecorator : Decorator
    {
        private SettingsDriver _settingsDriver;

        public SettingsDecorator(Driver driver, SettingsDriver settingsDriver) : base(driver) 
        {
            _settingsDriver = settingsDriver;
        }

        public override void Operation()
        {
            base.Operation();
            _settingsDriver.Operation();
            
        }
    }
}
