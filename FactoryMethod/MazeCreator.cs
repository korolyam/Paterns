using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes.Mazes;
using Classes.Mazes.MapSites.Rooms;
using Classes.Mazes.MapSites.Doors;
using Classes.Mazes.MapSites.Walls;
using Classes.Mazes.MapSites;

    public abstract class MazeCreator
    {
        public Maze CreateMaze()
        {
            Maze maze = MakeMaze();
            Room r1 = MakeRoom(0);
            Room r2 = MakeRoom(1);
            IDoor aDoor = MakeDoor(r1, r2);
            maze.AddRoom(r1);
            maze.AddRoom(r2);
            r1.SetSide(Direction.North, MakeWall());
            r1.SetSide(Direction.East, aDoor);
            r1.SetSide(Direction.South, MakeWall());
            r1.SetSide(Direction.West,  MakeWall());
            r2.SetSide(Direction.North, MakeWall());
            r2.SetSide(Direction.East, MakeWall());
            r2.SetSide(Direction.South, MakeWall());
            r2.SetSide(Direction.West, aDoor);
            return maze;
        }

       protected virtual Maze MakeMaze()
        {
            return new Maze();
        }

        protected virtual Room MakeRoom(int n)
        {
            if (n < 0)
            {
                throw new ArgumentException("Отрицательных комнат не существует");
            }
            return new CommonRoom(n);
        }

        protected virtual IDoor MakeDoor(Room room1, Room room2)
        {
            if (room1 == null || room2 == null)
            {
                throw new ArgumentNullException("Комнат нет");
            }
            return new CommonDoor(room1, room2);
        }

        protected virtual IWall MakeWall()
        {
            return new CommonWall();
        }
    }

