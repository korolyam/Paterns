using RemoteControlClassLibrary;
using Bridge.RemoteControlBridge;

namespace ProgramBridge
{
    class ProgramBridge
    {
        public static void Main(string[] args)
        {
            Power power = new Power();
            Settings settings = new Settings();
            Sound sound = new Sound();
            Channel channel = new Channel();
            DriverForRemoteControl driver;

            driver = new DriverForRemoteControl(settings);
            RemoteControl remoteControl = new RemoteControl(power, driver);
            remoteControl.Use();

            driver = new ExtendedDriverForRemoteControl(settings, sound, channel);
            remoteControl = new ExtendedRemoteControl(power,driver,sound);
            remoteControl.Use();
        }
    }
}
