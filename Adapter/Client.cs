using System.Buffers;
using System.Threading.Channels;

namespace Adapter
{
    class Client
    {
        static void Main(string[] args)
        {
            IDuck duck = new Duck();
            duck.Name();
            duck.Voice();
            duck.CanFly();

            IDuck turkey = new TurkeyToDuckAdapter(new Turkey());
            turkey.Name();
            turkey.Voice();
            turkey.CanFly();
        }
    }
}