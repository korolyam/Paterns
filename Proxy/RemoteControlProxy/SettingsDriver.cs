using RemoteControlClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyProject.RemoteControlProxy
{
    public class SettingsDriver : IDriver
    {
        private Settings _settings;

        public SettingsDriver(Settings settings)
        {
            _settings = settings;
        }

        public void Operation()
        {
            _settings.BrightnessUp();
            _settings.BrightnessUp();
            _settings.BrightnessDown();
            _settings.Subtitles();
            _settings.SetBrightness(77);
        }
    }
}
