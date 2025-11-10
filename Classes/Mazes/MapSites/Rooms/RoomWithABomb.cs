using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Mazes.MapSites.Rooms
{
    public class RoomWithABomb : Room
    {
        public RoomWithABomb(int noOfRoom) : base(noOfRoom)
        {
            
        }

        public RoomWithABomb(Room room) : base(room)
        {

        }

        public override RoomWithABomb Clone()
        {
            return new RoomWithABomb(this);
        }
    }
}
