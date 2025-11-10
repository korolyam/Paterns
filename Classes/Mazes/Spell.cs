using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Mazes
{
    public class Spell
    {
        public Spell()
        {

        }

        public Spell(Spell spell)
        {

        }

        public Spell Clone()
        {
            return new Spell(this);
        }
    }
}
