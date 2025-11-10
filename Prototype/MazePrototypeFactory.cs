using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes.Mazes;
using Classes.Mazes.MapSites;
using Classes.Mazes.MapSites.Doors;
using Classes.Mazes.MapSites.Rooms;
using Classes.Mazes.MapSites.Walls;

namespace Prototype
{
    public class MazePrototypeFactory
    {
        private Maze _prototypeMaze;
        private Room _prototypeRoom;
        private IWall _prototypeWall;
        private IDoor _prototypeDoor;

        public MazePrototypeFactory(Maze maze, IWall wall, Room room, IDoor door)
        {
            _prototypeDoor = door;
            _prototypeMaze = maze;
            _prototypeRoom = room;
            _prototypeWall = wall;
        }

        public Maze MakeMaze()
        {
            return _prototypeMaze.Clone();
        }

        public Room MakeRoom(int number)
        {
            Room room = (Room)_prototypeRoom.Clone();
            room.Initialize(number);
            return room;
        }

        public IWall MakeWall()
        {
            return (IWall)_prototypeWall.Clone();
        }

        public IDoor MakeDoor(Room room1, Room room2)
        {
            IDoor door = (IDoor)_prototypeDoor.Clone();
            door.Initialize(room1, room2);
            return door;
        }
    }
}
