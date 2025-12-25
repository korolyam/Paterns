using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class NoDiscount : IDiscount
    {
        public decimal CalculateDiscount(decimal price)
        {
            return 0;
        }
    }
}
