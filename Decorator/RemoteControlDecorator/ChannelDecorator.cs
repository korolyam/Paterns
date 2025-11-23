using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.RemoteControlDecorator
{
    public class ChannelDecorator : Decorator
    {
        private ChannelDriver _channelDriver;

        public ChannelDecorator(Driver driver, ChannelDriver channelDriver) : base(driver)
        {
            _channelDriver = channelDriver;
        }

        public override void Operation()
        {
            base.Operation();
            _channelDriver.Operation();
        }
    }
}
