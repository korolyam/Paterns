using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.RemoteControlDecorator
{
    public class SoundDecorator : Decorator
    {
        private SoundDriver _soundDriver;

        public SoundDecorator(Driver driver, SoundDriver soundDriver) : base(driver)
        {
            _soundDriver = soundDriver;
        }

        public override void Operation()
        {
            base.Operation();
            _soundDriver.Operation();
        }
    }
}
