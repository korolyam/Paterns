using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes.Mazes.MapSites.Rooms;

namespace Classes.Mazes.MapSites.Doors
{
    public class CommonDoor : IDoor
    {
        protected Room RoomOut { get; private set; }
        protected Room RoomIn { get; private set; }
        protected bool IsOpen { get; set; }
        public CommonDoor(Room roomOut, Room roomIn)
        {
            RoomOut = roomOut ?? throw new ArgumentNullException("Такой комнаты нет");
            RoomIn = roomIn ?? throw new ArgumentNullException("Такой комнаты нет");
            IsOpen = true;
        }

        public void Enter()
        {
            if (IsOpen)
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
