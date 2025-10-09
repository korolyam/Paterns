using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes.Mazes.MapSites.Rooms;

namespace Classes.Mazes
{
    public class BombedMaze : IMaze
    {
        private int number_of_rooms = 0;
        private List<IRoom> rooms;
        public BombedMaze()
        {
            rooms = new List<IRoom>();
        }
        public void AddRoom(IRoom room)
        {
            number_of_rooms++;
            rooms.Add(room);
        }
        public int RoomNo()
        {
            return number_of_rooms;
        }
        public List<IRoom> Rooms { get { return rooms; } }
    }
}
