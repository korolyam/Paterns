using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Mazes.MapSites.Rooms
{
    public class EnchantedRoom : Room
    {
        private Spell spell;

        public EnchantedRoom(int noOfRoom, Spell spell) : base(noOfRoom)
        {
            this.spell = spell;    
        }

        public void Enter(Direction direction)
        {
            this.Sides[Direction.East].Enter();
        }
    }
}
