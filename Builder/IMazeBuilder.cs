using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes.Mazes;

namespace Builder
{
    public interface IMazeBuilder
    {
        void BuildMaze();
        void BuildRoom(int roomNumber);
        void BuildDoor(int roomOut, int roomIn);
        public IMaze GetMaze()
        {
            return null;
        }
    }
}
