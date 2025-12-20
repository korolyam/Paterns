using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.ChainClassLibrary
{
    public class PandaHandler : AbstractHandler
    {
        public PandaHandler(IHandler handler) : base(handler) { }

        public override object Handle(object request)
        {
            if (request.ToString() == "Бамбук")
            {
                HandlerEvent($"Панда съела {request}");
                return true;
            }
            else
            {
                Console.WriteLine($"- Панда не смогла съесть {request.ToString()}");
                return base.Handle(request);
            }
        }
    }
}
