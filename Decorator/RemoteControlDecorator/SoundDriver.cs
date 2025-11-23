using RemoteControlClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.RemoteControlDecorator
{
    public class SoundDriver : Driver
    {
        private Sound _sound;

        public SoundDriver(Sound sound)
        {
            _sound = sound;
        }

        public override void Operation()
        {
            _sound.VolumeUp();
            _sound.VolumeUp();
            _sound.VolumeUp();
            _sound.VolumeDown();
            _sound.VolumeMute();
            _sound.VolumeUp();
            _sound.VolumeMute();
            _sound.VolumeUnMute();
        }
    }
}
