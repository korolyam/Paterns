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
    public class CommonMazeFactory : IMazeFactory
    {
        public CommonMazeFactory()
        {

        }
        public IMaze MakeMaze()
        {
            return new CommonMaze();
        }
        public IRoom MakeRoom(int n)
        {
            return new CommonRoom(n);
        }
        public IDoor MakeDoor(IRoom room1, IRoom room2)
        {
            return new CommonDoor(room1, room2);
        }
        public IWall MakeWall()
        {
            return new CommonWall();
        }
    }
}
