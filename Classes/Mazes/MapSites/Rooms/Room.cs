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

        public Room(Room otherRoom )
        {
            this.Sides = new Dictionary<Direction, IMapSite>();
            this.NoOfRoom = otherRoom.NoOfRoom;
            foreach (KeyValuePair<Direction, IMapSite> side in otherRoom.Sides)
            {
                this.Sides[side.Key] = otherRoom.Sides[side.Key].Clone();
            }
        }

        public virtual IMapSite Clone()
        {
            return new CommonRoom((CommonRoom) this);
        }

        public virtual void Initialize(int noOfRoom)
        {
            if (noOfRoom < 0)
            {
                throw new ArgumentException("Нельзя сделать отрицательную комнату");
            }
            this.NoOfRoom = noOfRoom;
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
