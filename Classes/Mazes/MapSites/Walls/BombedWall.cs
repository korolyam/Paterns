using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Mazes.MapSites.Walls
{
    public class BombedWall : IWall
    {
        public BombedWall()
        {
            
        }

        public void Enter()
        {
            Console.WriteLine("Вы прошли через взорванную стену");
        }
    }
}
