using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes.Mazes.MapSites.Rooms;
using Classes.Mazes.MapSites.Doors;
using Classes.Mazes.MapSites.Walls;

namespace Classes.Mazes
{
    public interface IMaze
    {
        abstract void AddRoom(Room room);

        abstract int RoomNo();

        List<Room> Rooms { get;}
    }
}
