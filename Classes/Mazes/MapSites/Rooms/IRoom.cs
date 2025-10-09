using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes.Mazes.MapSites.Walls;

namespace Classes.Mazes.MapSites.Rooms
{
    public interface IRoom : IMapSite
    {
        public void SetSide(Direction direction,IMapSite side)
        {

        }
        public IMapSite GetSide(Direction direction)
        {
            return new CommonWall();
        }
        public void Enter(Direction direction);
    }
}
