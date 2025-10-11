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
            return new Maze();
        }

        public Room MakeRoom(int n)
        {
            if (n > 0)
            {
                return new EnchantedRoom(n, CastSpell());
            }
            throw new ArgumentOutOfRangeException("Нельзя создать комнату с отрицательным значением");
        }

        public IDoor MakeDoor(Room room1, Room room2)
        {
            if (room1 == null || room2 == null)
            {
                throw new ArgumentNullException("Таких комнат ещё нет");
            }
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
