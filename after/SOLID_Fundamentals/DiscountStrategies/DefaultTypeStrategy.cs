using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Fundamentals.DiscountStrategies
{
    public class DefaultTypeStrategy : IDiscountStrategy
    {
        public decimal Calculate(decimal orderAmount)
        {
            return 0;
        }
    }
}
