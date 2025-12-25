using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class VIPDiscount : IDiscount
    {
        public decimal CalculateDiscount(decimal price)
        {
            return price * 0.2m;
        }
    }
}
