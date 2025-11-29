using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RemoteControlClassLibrary;

namespace DecoratorProject.RemoteControlDecorator
{
    public class ChannelDecorator : Decorator
    {
        private Channel _channel;

        public ChannelDecorator(Channel channel, Decorator decorator): base(decorator)
        {
            _channel = channel;
        }

        public override void Operation()
        {
            base.Operation();
            _channel.List();
            _channel.ForNumber(6);
            _channel.Previous();
            _channel.Next();
            _channel.Next();
            _channel.ForNumber(7);
        }
    }
}
