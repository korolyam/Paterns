using RemoteControlClassLibrary;
using Decorator.RemoteControlDecorator;

namespace Decorator
{
    public class ProgrammDecorator
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

            Console.WriteLine("---------------------- Пульт с Power ----------------------");
            Driver mainDriver = new Driver();
            RemoteControl.Use(power, mainDriver);

            Console.WriteLine("---------------------- Пульт с Power + Settings ----------------------");
            mainDriver = new SettingsDecorator(mainDriver, settingsDriver);
            RemoteControl.Use(power, mainDriver);

            Console.WriteLine("---------------------- Пульт с Power + Settings + Sound ----------------------");
            mainDriver = new SoundDecorator(mainDriver, soundDriver);
            RemoteControl.Use(power, mainDriver);

            Console.WriteLine("---------------------- Пульт с Power + Settings + Sound + Channel ----------------------");
            mainDriver = new ChannelDecorator(mainDriver, channelDriver);
            RemoteControl.Use(power, mainDriver);
        }
    }
}
