namespace SOLID_Fundamentals
{
    public class VIPTypeStrategy : IDiscountStrategy
    {
        public decimal Calculate(decimal orderAmount)
        {
            return orderAmount * 0.15m;
        }
    }



    
}
