using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes.Mazes;

namespace Builder
{
    public class CountingBuilder : IMazeBuilder
    {
        private int doors;
        private int rooms;

        public CountingBuilder()
        {
            this.doors = this.rooms = 0;
        }

        public void BuildMaze()
        {

        }

        public void BuildRoom( int n)
        {
            this.rooms++;
        }

        public void BuildDoor(int n1, int n2)
        {
            this.doors++;
        }

        public int GetCounts()
        {
            return this.doors + this.rooms;
        }
    }
}
