using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteControlClassLibrary
{
    public class Settings
    {
        private bool _subtitles = false;
        private const int _maxBrightness = 100;
        private const int _minBrightness = 0;

        public int Brightness { get; private set; } = 50;

        public void Subtitles()
        {
            if (_subtitles)
            {
                _subtitles = false;
            }
            else
            {
                _subtitles = true;
            }
        }

        public void SetBrightness(int brightness)
        {
            if (brightness <= _maxBrightness && brightness >= _minBrightness)
            {
                Brightness = brightness;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Ошибка. Неверное значение яркости");
            }
        }

        public void BrightnessUp()
        {
            if (Brightness >= _maxBrightness)
            {
                throw new ArgumentOutOfRangeException("Ошибка. Яркость на максмимальном значении");
            }
            else
            {
                Brightness += 1;
            }
        }

        public void BrightnessDown()
        {
            if (Brightness <= _minBrightness)
            {
                throw new ArgumentOutOfRangeException("Ошибка. Яркость на минимальном значении");
            }
            else
            {
                Brightness -= 1;
            }
        }
    }
}