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
        static List<IRoom> rooms;
        public void AddRoom(IRoom room)
        {

        }
        public int RoomNo()
        {
            return 0;
        }
        public List<IRoom> Rooms { get { return rooms; } }
    }
}
