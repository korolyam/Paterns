using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.ChainClassLibrary
{
    public class MonkeyHandler : AbstractHandler
    {
        public MonkeyHandler(IHandler handler) : base(handler) { }

        public override object Handle(object request)
        {
            if (request.ToString() == "Банан")
            {
                HandlerEvent($"Обезьяна съела {request}");
                return true;
            }
            else
            {
                Console.WriteLine($"- Обезьяна не смогла съесть {request.ToString()}");
                return base.Handle(request);
            }
        }
    }
}
