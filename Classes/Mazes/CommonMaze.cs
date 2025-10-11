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
        private List<Room> rooms;

        public List<Room> Rooms { get { return this.rooms; } }

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

        public int RoomNo()
        {
            return this.numberOfRooms;
        }
    }
}
