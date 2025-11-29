using RemoteControlClassLibrary;
using DecoratorProject.RemoteControlDecorator;

namespace DecoratorProject
{
    public class ProgrammDecorator
    {
        static void Main(string[] args)
        {
            Power power = new Power();
            Settings settings = new Settings();
            Sound sound = new Sound();
            Channel channel = new Channel();

            Console.WriteLine("---------------------- Пульт с Power ----------------------");
            Decorator mainDecorator = new Decorator();
            RemoteControl.Use(power, mainDecorator);

            Console.WriteLine("---------------------- Пульт с Power + Settings ----------------------");
            mainDecorator = new SettingsDecorator(settings, mainDecorator);
            RemoteControl.Use(power, mainDecorator);

            Console.WriteLine("---------------------- Пульт с Power + Settings + Sound ----------------------");
            mainDecorator = new SoundDecorator(sound,mainDecorator);
            RemoteControl.Use(power, mainDecorator);

            Console.WriteLine("---------------------- Пульт с Power + Settings + Sound + Channel ----------------------");
            mainDecorator = new ChannelDecorator(channel,mainDecorator);
            RemoteControl.Use(power, mainDecorator);
        }
    }
}
