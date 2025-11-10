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
        public int NumberOfRooms { get { return rooms.Count; } }

        private List<Room> rooms;

        public Maze()
        {
            this.rooms = new List<Room>();
        }

        public Maze(Maze otherMaze )
        {
            this.rooms = new List<Room>();
            foreach(var room in otherMaze.rooms)
            {
                this.rooms.Add((Room)room.Clone());
            }
        }

        public Maze Clone()
        {
            return new Maze(this);
        }

        public void AddRoom(Room room)
        {
            if (room == null || rooms.Any(x => x.NoOfRoom == room.NoOfRoom))
            {
                throw new ArgumentNullException("Такой комнаты нет или комната с таким номером уже существует");
            }
            this.rooms.Add(room);
        }

        public Room GetRoomFromItsInternalId(int roomId)
        {
            if (!rooms.Any(x => x.NoOfRoom == roomId))
            {
                throw new ArgumentOutOfRangeException("Такой комнаты нет");
            }
            return rooms.First(x => x.NoOfRoom == roomId);
        }
    }
}
