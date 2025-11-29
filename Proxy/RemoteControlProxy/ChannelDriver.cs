using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RemoteControlClassLibrary;

namespace ProxyProject.RemoteControlProxy
{
    public class ChannelDriver : IDriver
    {
        private Channel _channel;

        public ChannelDriver(Channel channel)
        {
            _channel = channel;
        }

        public void Operation()
        {
            _channel.List();
            _channel.ForNumber(6);
            _channel.Previous();
            _channel.Next();
            _channel.Next();
            _channel.ForNumber(7);
        }
    }
}
