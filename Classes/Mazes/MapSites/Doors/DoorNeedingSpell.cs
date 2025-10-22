using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes.Mazes.MapSites.Rooms;

namespace Classes.Mazes.MapSites.Doors
{
    public class DoorNeedingSpell : CommonDoor
    {
        private Room roomOut;
        private Room roomIn;
        private bool isOpen;
        public DoorNeedingSpell(Room roomOut, Room roomIn) : base(roomOut,roomIn)
        {
            this.roomOut = roomOut ?? throw new ArgumentNullException("Такой комнаты нет");
            this.roomIn = roomIn ?? throw new ArgumentNullException("Такой комнаты нет");
            this.isOpen = false;
        }
    }   
}

