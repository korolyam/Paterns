using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class ConcreteUser : User
    {
        public ConcreteUser(IChatMediator mediator, string name) : base(mediator, name) { }

        public override void Send(string message)
        {
            Console.WriteLine($"{_name} отправляет: {message}");
            _mediator.SendMessage(message, this);
        }

        public override void Receive(string message)
        {
            Console.WriteLine($"{_name} получает: {message}");
        }
    }
}
