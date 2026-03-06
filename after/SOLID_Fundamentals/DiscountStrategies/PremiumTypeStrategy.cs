namespace SOLID_Fundamentals
{
    public class PremiumTypeStrategy : IDiscountStrategy
    {
        public decimal Calculate(decimal orderAmount)
        {
            return orderAmount * 0.10m;
        }
    }



    
}
