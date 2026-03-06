namespace SOLID_Fundamentals
{
    public class StudentTypeStrategy : IDiscountStrategy
    {
        public decimal Calculate(decimal orderAmount)
        {
            return orderAmount * 0.08m;
        }
    }



    
}
