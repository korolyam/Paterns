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

        public EnchantedRoom(EnchantedRoom room) : base(room)
        {
            this.spell = room.spell.Clone();
        }

        public override EnchantedRoom Clone()
        {
            return new EnchantedRoom(this);
        }

        public void Initialize(Spell spell)
        {
            this.spell = spell ?? throw new ArgumentNullException("Пустое заклятие");
        }

        public void Enter(Direction direction)
        {
            this.Sides[Direction.East].Enter();
        }
    }
}
