using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Mazes.MapSites.Rooms
{
    public class RoomWithABomb : Room
    {
        public RoomWithABomb(int noOfRoom)
        {
            if (noOfRoom >= 0)
            {
                NoOfRoom = noOfRoom;
                Sides = new Dictionary<Direction, IMapSite>();
            }
            else
            {
                throw new ArgumentException("У лабиринта не может быть отрицательной (или нулевой) комнаты");
            }
        }
    }
}
