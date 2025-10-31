using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes.Mazes.MapSites.Walls;

namespace Classes.Mazes.MapSites.Rooms
{
    public abstract class Room : IMapSite
    {
        public int NoOfRoom { get;  private set; }
        protected Dictionary<Direction, IMapSite> Sides { get; private set; }

        public Room(int noOfRoom)
        {
            if (noOfRoom < 0)
            {
                throw new ArgumentOutOfRangeException("Отрицательных комнат не бывает");
            }
            NoOfRoom = noOfRoom;
            Sides = new Dictionary<Direction, IMapSite>();
        }

        public virtual void SetSide(Direction direction, IMapSite side)
        {
            if (side is Room)
            {
                throw new ArgumentException("Нельзя поставить комнату в качестве стены");
            }
            else
            {
                Sides[direction] = side;
            }
        }

        public virtual IMapSite GetSide(Direction direction)
        {
            return Sides[direction];         
        }
        public void Enter()
        {
            Sides[Direction.North].Enter();
        }

        public void Enter(Direction direction)
        {
            Sides[direction].Enter();
        }
    }
}
