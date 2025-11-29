using RemoteControlClassLibrary;
using FacadeProject.RemoteControlFacade;

namespace FacadeProject
{
    class ProgramFacade
    {
        static void Main(string[] args)
        {
            Power power = new Power();
            Settings settings = new Settings();
            Sound sound = new Sound();
            Channel channel = new Channel();

            DriverForRemoteControl driverForRemoteControl = new DriverForRemoteControl(power, settings, sound, channel);
            RemoteControl.Use(driverForRemoteControl);
        }
    }
}
