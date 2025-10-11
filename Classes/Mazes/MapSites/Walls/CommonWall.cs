using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Mazes.MapSites.Walls
{
    public class CommonWall :IWall
    {
        public CommonWall()
        {
            
        }

        public void Enter()
        {
            Console.WriteLine("Вы ударились о стену");
        }
    }
}
