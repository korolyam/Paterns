using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class RegularDiscount : IDiscount
    {
        public decimal CalculateDiscount(decimal price)
        {
            return price * 0.1m;
        }
    }
}
