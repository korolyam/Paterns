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
        private int numberOfRooms = 0;
        public int NumberOfRooms { get { return this.numberOfRooms; } }

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
            this.numberOfRooms++;
            this.rooms.Add(room);
        }

        public Room GetRoom(int RoomNo)
        {
            if (RoomNo - 1 > this.numberOfRooms)
            {
                throw new ArgumentOutOfRangeException("Такой комнаты нет");
            }
            return this.rooms[RoomNo - 1];
        }
    }
}
