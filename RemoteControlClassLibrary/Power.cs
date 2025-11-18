using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteControlClassLibrary
{
    public class Power
    {
        private bool _power = false;

        public void TurnOn()
        {
            if (_power)
            {
                throw new Exception("Ошибка. Телевизор уже включён");
            }
            else
            {
                _power = true;
            }
        }

        public void TurnOff()
        {
            if (!_power)
            {
                throw new Exception("Ошибка. Телевизор уже выключен");
            }
            else
            {
                _power = false;
            }
        }
    }
}