using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public interface IDuck
    {
        public void Name();

        public void Voice();

        public void CanFly();
    }
}
