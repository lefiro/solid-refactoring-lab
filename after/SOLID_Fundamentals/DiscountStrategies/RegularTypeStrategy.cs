namespace SOLID_Fundamentals
{
    public class RegularTypeStrategy : IDiscountStrategy
    {
        public decimal Calculate(decimal orderAmount)
        {
            return orderAmount * 0.05m;
        }
    }



    
}
