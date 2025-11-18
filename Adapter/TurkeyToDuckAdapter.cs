using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class TurkeyToDuckAdapter : IDuck
    {
        private readonly Turkey turkey;

        public TurkeyToDuckAdapter(Turkey turkey)
        {
            this.turkey = turkey ?? throw new ArgumentNullException(nameof(turkey));
        }

        public void Name()
        {
            this.turkey.SpecificName();
        }

        public void Voice()
        {
            this.turkey.SpecificVoice();
        }

        public void CanFly()
        {
            this.turkey.SpecificCanFly();
        }
    }
}
