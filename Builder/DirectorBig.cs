using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes.Mazes;

namespace Builder
{
    public class DirectorBig
    {
        private StandartMazeBuilder builder;

        public DirectorBig(StandartMazeBuilder builder)
        {
            this.builder = builder ?? throw new ArgumentNullException(nameof(builder));
        }

        public IMaze CreateBigMaze()
        {
            this.builder.BuildMaze();
            for (int i = 0; i < 100; i+=2)
            {
                this.builder.BuildRoom(i);
                this.builder.BuildRoom(i + 1);
                this.builder.BuildDoor(i, i + 1);
            }
            return this.builder.GetMaze();
        }
    }
}
