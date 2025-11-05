using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes.Mazes;
using Classes.Mazes.MapSites.Rooms;
using Classes.Mazes.MapSites.Doors;
using Classes.Mazes.MapSites.Walls;

    public class BombedMazeCreator : MazeCreator
    {
        public BombedMazeCreator()
        {

        }

        protected override Room MakeRoom(int n) 
        {
            if (n >= 0)  
            {
                return new RoomWithABomb(n);
            }
            throw new ArgumentOutOfRangeException("Нельзя создать комнату с отрицательным значением");
        }

        protected override IWall MakeWall()
        {
            return new BombedWall();
        }
    }

