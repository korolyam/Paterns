using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes.Mazes.MapSites.Rooms;

namespace Classes.Mazes.MapSites.Doors
{
    public interface IDoor : IMapSite
    {
        public void Initialize(Room r1, Room r2);
    }
}
