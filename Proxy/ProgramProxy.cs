using RemoteControlClassLibrary;
using ProxyProject.RemoteControlProxy;

namespace ProxyProject
{
    class ProgramProxy
    {
        static void Main(string[] args)
        {
            Power power = new Power();
            Settings settings = new Settings();
            Sound sound = new Sound();
            Channel channel = new Channel();

            SettingsDriver settingsDriver = new SettingsDriver(settings);
            SoundDriver soundDriver = new SoundDriver(sound);
            ChannelDriver channelDriver = new ChannelDriver(channel);

            Console.WriteLine("---------------------- Пульт с Settings ----------------------");
            RemoteControl.Use(power, settingsDriver);

            Console.WriteLine("---------------------- Пульт с Sound ----------------------");
            RemoteControl.Use(power, soundDriver);

            Console.WriteLine("---------------------- Пульт с Channel ----------------------");
            RemoteControl.Use(power, channelDriver);

            Proxy guestProxySettings = new Proxy(settingsDriver, AccessLevel.Guest);
            Proxy userProxySound = new Proxy(soundDriver, AccessLevel.User);
            Proxy adminProxyChannel = new Proxy(channelDriver, AccessLevel.Admin);

            Console.WriteLine("---------------------- Пульт с Settings с уровнем доступа Guest ----------------------");
            RemoteControl.Use(power, guestProxySettings);

            Console.WriteLine("---------------------- Пульт с Sound в с уровнем доступа User ----------------------");
            RemoteControl.Use(power, userProxySound);

            Console.WriteLine("---------------------- Пульт с Channel в уровнем доступа Admin ----------------------");
            RemoteControl.Use(power, adminProxyChannel);

        }
    }
}
