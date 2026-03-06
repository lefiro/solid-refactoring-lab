namespace SOLID_Fundamentals
{
    public class SeniorTypeStrategy : IDiscountStrategy
    {
        public decimal Calculate(decimal orderAmount)
        {
            return orderAmount * 0.07m;
        }
    }



    
}
