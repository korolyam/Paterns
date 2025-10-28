using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes.Mazes.MapSites.Rooms;

namespace Classes.Mazes
{
    public class Maze : IMaze
    {
        public int NumberOfRooms { get; set; }

        private List<Room> rooms;

        public Maze()
        {
            this.rooms = new List<Room>();
        }

        public void AddRoom(Room room)
        {
            if (room == null)
            {
                throw new ArgumentNullException("Такой комнаты нет");
            }
            NumberOfRooms++;
            this.rooms.Add(room);
        }

        public Room GetRoomFromItsInternalId(int roomId)
        {
            if (roomId > NumberOfRooms)
            {
                throw new ArgumentOutOfRangeException("Такой комнаты нет");
            }
            return this.rooms[roomId];
        }
    }
}
