using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes.Mazes;

namespace Builder
{
    public class Director
    {
        private IMazeBuilder builder;

        public Director(IMazeBuilder builder)
        {
            this.builder = builder ?? throw new ArgumentNullException(nameof(builder));
        }

        public IMaze CreateSimpleMaze()
        {
            this.builder.BuildMaze();
            this.builder.BuildRoom(0);
            this.builder.BuildRoom(1);
            this.builder.BuildDoor(0, 1);
            return this.builder.GetMaze();
        }
    }
}
