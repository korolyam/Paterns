using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes.Mazes;
using Classes.Mazes.MapSites.Rooms;
using Classes.Mazes.MapSites.Doors;
using Classes.Mazes.MapSites.Walls;

namespace AsbtractFactory.MazeFactories
{
    public class EnchantedMazeFactory : IMazeFactory
    {
        public EnchantedMazeFactory()
        {

        }
        public IMaze MakeMaze()
        {
            return new EnchantedMaze();
        }
        public IRoom MakeRoom(int n)
        {
            return new EnchantedRoom(n, CastSpell());
        }
        public IDoor MakeDoor(IRoom room1, IRoom room2)
        {
            return new DoorNeedingSpell(room1, room2);
        }
        public IWall MakeWall()
        {
            return new CommonWall();
        }
        protected Spell CastSpell()
        {
            return new Spell();
        }
    }
}
