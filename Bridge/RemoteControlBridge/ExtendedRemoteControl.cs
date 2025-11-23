using RemoteControlClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.RemoteControlBridge
{
    public class ExtendedRemoteControl : RemoteControl
    {
        private Sound _sound;

        public ExtendedRemoteControl(Power power, DriverForRemoteControl driver, Sound sound) : base(power, driver)
        {
            _sound = sound ?? throw new ArgumentNullException(nameof(sound));
        }

        public override void Use()
        {
            base.Use();
            _power.TurnOn();
            _sound.SetVolumeForYoutube();
            _sound.SetVolumeForCinema();
            _power.TurnOff();
        }
    }
}
