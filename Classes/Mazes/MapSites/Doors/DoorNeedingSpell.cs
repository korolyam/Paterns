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
        public DoorNeedingSpell(Room roomOut, Room roomIn) : base(roomOut,roomIn)
        {
            IsOpen = false;
        }
    }   
}

