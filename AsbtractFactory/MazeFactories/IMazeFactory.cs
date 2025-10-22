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
    public interface IMazeFactory
    {
        IMaze MakeMaze();

        Room MakeRoom(int n);

        IDoor MakeDoor(Room room1, Room room2);

        IWall MakeWall();
    }
}
