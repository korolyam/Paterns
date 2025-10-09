using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Mazes.MapSites.Rooms
{
    public class RoomWithABomb : IRoom
    {
        private int no_of_room;
        private Dictionary<Direction, IMapSite> sides;
        public RoomWithABomb(int no_of_room)
        {
            if (no_of_room > 0)
            {
                this.no_of_room = no_of_room;
                sides = new Dictionary<Direction, IMapSite>();
            }
            else
            {
                throw new ArgumentException("У лабиринта не может быть отрицательной (или нулевой) комнаты");
            }
        }
        public void SetSide(Direction direction, IMapSite side)
        {
            if (side is IRoom)
            {
                throw new ArgumentException("Нельзя поставить комнату в качестве стены");
            }
            else
            {
                sides[direction] = side;
            }
        }
        public IMapSite GetSide(Direction direction)
        {
            if (sides[direction] == null)
            {
                throw new ArgumentException("Этой стороны ещё не существует");
            }
            else
            {
                return sides[direction];
            }
        }
        public void Enter(Direction direction)
        {
            sides[direction].Enter();
        }
    }
}
