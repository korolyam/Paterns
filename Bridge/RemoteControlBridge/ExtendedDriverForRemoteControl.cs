using RemoteControlClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.RemoteControlBridge
{
    public class ExtendedDriverForRemoteControl : DriverForRemoteControl
    {
        private Sound _sound;
        private Channel _channel;

        public ExtendedDriverForRemoteControl(Settings settings, Sound sound,  Channel channel) : base(settings)
        {
            _sound = sound ?? throw new ArgumentNullException(nameof(sound));
            _channel = channel ?? throw new ArgumentNullException(nameof(channel));
        }

        public override void Operation()
        {
            base.Operation();
            _channel.List();
            _channel.Next();
            _channel.Previous();
            _channel.Back();
            _channel.ForNumber(6);
            _sound.VolumeUp();
            _sound.VolumeDown();
            _sound.VolumeMute();
            _sound.VolumeUp();
            _sound.VolumeMute();
            _sound.VolumeUnMute();
        }
    }
}
