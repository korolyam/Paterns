using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteControlClassLibrary
{
    public class Sound
    {
        private bool _inMute = false;
        private int _volumeForMute;
        private const int _maxVolume = 100;
        private const int _minVolume = 0;

        public int Volume { get; private set; } = 50;

        public void VolumeUp()
        {
            if (_inMute)
            {
                VolumeUnMute();
            }

            if (Volume == _maxVolume)
            {
                throw new ArgumentOutOfRangeException("Ошибка. Звук на максимальной громкости");
            }
            else
            {
                Volume += 1;
            }
        }

        public void VolumeDown()
        {
            if (_inMute)
            {
                VolumeUnMute();
            }

            if (Volume == _minVolume)
            {
                throw new ArgumentOutOfRangeException("Ошибка. Звук на минимальной громкости");
            }
            else
            {
                Volume -= 1;
            }
        }

        public void VolumeMute()
        {
            if (_inMute)
            {
                throw new Exception("Ошибка. Звук уже выключен");
            }
            else
            {
                _volumeForMute = Volume;
                Volume = 0;
                _inMute = true;
            }
        }

        public void VolumeUnMute()
        {
            if (!_inMute)
            {
                throw new Exception("Ошибка. Звук уже включён");
            }
            else
            {
                Volume = _volumeForMute;
                _inMute = false;
            }
        }

        public void SetVolumeForYoutube()
        {
            Volume = 55;
            Console.WriteLine("Звук установлен для Youtube (55)");
        }

        public void SetVolumeForCinema()
        {
            Volume = 35;
            Console.WriteLine("Звук установлен для кинофильма (35)");
        }
    }
}