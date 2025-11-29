using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RemoteControlClassLibrary;

namespace DecoratorProject.RemoteControlDecorator
{
    public class SoundDecorator : Decorator
    {
        private Sound _sound;

        public SoundDecorator(Sound sound, Decorator decorator) : base(decorator)
        {
            _sound = sound;
        }

        public override void Operation()
        {
            base.Operation();
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
