using RemoteControlClassLibrary;

namespace Bridge.RemoteControlBridge
{
    public class DriverForRemoteControl
    {
        protected Settings _settings;

        public DriverForRemoteControl(Settings settings)
        {
            _settings = settings ?? throw new ArgumentNullException(nameof(settings));
        }

        public virtual void Operation()
        {
            _settings.BrightnessUp();
            _settings.BrightnessDown();
            _settings.Subtitles();
            _settings.SetBrightness(54);
        }
    }
}
