using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Fundamentals
{
    public class ShippingCostCalculator
    {
        private readonly IShippingCost _shippingCost; 

        public ShippingCostCalculator(IShippingCost shippingCost)
        {
            _shippingCost = shippingCost;
        }
        public decimal CalculateShippingCost(decimal weight)
        {
            return _shippingCost.CalculateCost(weight);
        }
    }
}
