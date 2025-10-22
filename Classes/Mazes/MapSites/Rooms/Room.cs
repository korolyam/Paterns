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
        protected int noOfRoom;
        protected  Dictionary<Direction, IMapSite> sides = new Dictionary<Direction, IMapSite>();
        public virtual void SetSide(Direction direction, IMapSite side)
        {
            if (side is Room)
            {
                throw new ArgumentException("Нельзя поставить комнату в качестве стены");
            }
            else
            {
                this.sides[direction] = side;
            }
        }

        public virtual IMapSite GetSide(Direction direction)
        {
            if (this.sides[direction] == null)
            {
                throw new ArgumentException("Этой стороны ещё не существует");
            }
            else
            {
                return this.sides[direction];
            }
        }
        public void Enter()
        {
            this.sides[Direction.North].Enter();
        }

        public void Enter(Direction direction)
        {
            this.sides[direction].Enter();
        }
    }
}
