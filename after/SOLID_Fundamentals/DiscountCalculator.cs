using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Fundamentals
{

    public class DiscountCalculator
    {
        private readonly IDiscountStrategy _discountStrategy;
        
        public DiscountCalculator(IDiscountStrategy discountStrategy)
        {
            _discountStrategy = discountStrategy; // проверка на null?
        }

        public decimal CalculateDiscount(decimal orderAmount)
        {
            return _discountStrategy.Calculate(orderAmount);
        }

    }


}
