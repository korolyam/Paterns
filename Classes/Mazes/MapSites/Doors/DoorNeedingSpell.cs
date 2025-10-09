using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes.Mazes.MapSites.Rooms;

namespace Classes.Mazes.MapSites.Doors
{
    public class DoorNeedingSpell : IDoor
    {
            private IRoom room_out;
            private IRoom room_in;
            private bool is_open;
            public DoorNeedingSpell(IRoom room_out, IRoom room_in)
            {
                this.room_out = room_out ?? throw new ArgumentNullException("Такой комнаты нет");
                this.room_in = room_in ?? throw new ArgumentNullException("Такой комнаты нет");
                this.is_open = false;
            }
            public void Enter()
            {
                if (is_open)
                {
                Console.WriteLine("Вы прошли через дверь");
                }
                else
                {
                Console.WriteLine("Вы ударились о закрытую дверь");
                }
            }
    }   
}

