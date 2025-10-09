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
    public class BombedMazeFactory : IMazeFactory
    {
        public BombedMazeFactory()
        {

        }
        public IMaze MakeMaze()
        {
            return new BombedMaze();
        }
        public IRoom MakeRoom(int n)
        {
            return new RoomWithABomb(n);
        }
        public IDoor MakeDoor(IRoom room1, IRoom room2)
        {
            return new CommonDoor(room1, room2);
        }
        public IWall MakeWall()
        {
            return new BombedWall();
        }
    }
}
