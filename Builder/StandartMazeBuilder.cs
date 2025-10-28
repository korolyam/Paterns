using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes.Mazes;
using Classes.Mazes.MapSites;
using Classes.Mazes.MapSites.Rooms;
using Classes.Mazes.MapSites.Walls;
using Classes.Mazes.MapSites.Doors;

namespace Builder
{
    public class StandartMazeBuilder : IMazeBuilder
    {
        private Maze currentMaze = null;

        private Direction CommonWall(Room roomOriginal, Room roomHelper)
        {
            foreach(Direction dir1 in Enum.GetValues(typeof(Direction)))
            {
               foreach(Direction dir2 in Enum.GetValues(typeof(Direction)))
                {
                    if (roomOriginal.GetSide(dir1) == roomHelper.GetSide(dir2))
                    {
                        return dir1;
                    }
                }
            }
            throw new ArgumentException("У этих комнат нет общей стены");
        }

        public StandartMazeBuilder()
        {

        }

        public void BuildMaze()
        {
            this.currentMaze = new Maze();
        }

        public void BuildRoom(int roomId)
        {
            if (roomId < 0)
            {
                throw new ArgumentException("Нулевых комнат не бывает");
            }
            Room room = new CommonRoom(roomId);
            this.currentMaze.AddRoom(room);
            room.SetSide(Direction.North, new CommonWall());
            room.SetSide(Direction.South, new CommonWall());
            room.SetSide(Direction.West, new CommonWall());
            room.SetSide(Direction.East, new CommonWall());
            if (this.currentMaze.NumberOfRooms > 1)
            {
                Random rand = new Random();
                var directions = Enum.GetValues(typeof(Direction));
                var directionIndex = rand.Next(directions.Length);
                var direction = (Direction)directions.GetValue(directionIndex);
                switch (direction)
                {
                    case Direction.North: room.SetSide(Direction.North, this.currentMaze.GetRoomFromItsInternalId(this.currentMaze.NumberOfRooms-2).GetSide(Direction.South)); break;
                    case Direction.East: room.SetSide(Direction.East, this.currentMaze.GetRoomFromItsInternalId(this.currentMaze.NumberOfRooms-2).GetSide(Direction.West)); break;
                    case Direction.West: room.SetSide(Direction.West, this.currentMaze.GetRoomFromItsInternalId(this.currentMaze.NumberOfRooms-2).GetSide(Direction.East)); break;
                    case Direction.South: room.SetSide(Direction.South, this.currentMaze.GetRoomFromItsInternalId(this.currentMaze.NumberOfRooms-2).GetSide(Direction.North)); break;
                }
            }
        }

        public void BuildDoor( int r1, int r2)
        {
            if (r1 > this.currentMaze.NumberOfRooms || r2 > this.currentMaze.NumberOfRooms)
            {
                throw new ArgumentException("Таких комнат нет");
            }
            Room roomOut = this.currentMaze.GetRoomFromItsInternalId(r1);
            Room roomIn = this.currentMaze.GetRoomFromItsInternalId(r2);
            CommonDoor door = new CommonDoor(roomOut, roomIn);
            Direction dir1 = CommonWall(roomOut, roomIn);
            Direction dir2 = CommonWall(roomIn, roomOut);
            roomOut.SetSide(dir1, door);
            roomIn.SetSide(dir2, door);
        }

        public IMaze GetMaze()
        {
            return this.currentMaze;
        }

    }
}
