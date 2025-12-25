using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class PriceCalculator
    {
        private IDiscount _discount;

        public PriceCalculator(IDiscount discount)
        {
            _discount = discount;
        }

        public void SetStrategy(IDiscount discount)
        {
            _discount = discount;
        }

        public decimal CalculateFinalPrice(decimal price)
        {
            var discount = _discount.CalculateDiscount(price);
            return price - discount;
        }
    }
}