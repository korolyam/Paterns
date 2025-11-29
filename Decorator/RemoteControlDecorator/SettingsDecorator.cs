using RemoteControlClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorProject.RemoteControlDecorator
{
    public class SettingsDecorator : Decorator
    {
        private Settings _settings;

        public SettingsDecorator(Settings settings, Decorator decorator) : base(decorator)
        {
            _settings = settings;
        }

        public override void Operation()
        {
            base.Operation();
            _settings.BrightnessUp();
            _settings.BrightnessUp();
            _settings.BrightnessDown();
            _settings.Subtitles();
            _settings.SetBrightness(77);
        }
    }
}
