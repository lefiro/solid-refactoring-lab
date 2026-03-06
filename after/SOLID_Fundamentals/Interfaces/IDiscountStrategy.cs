namespace SOLID_Fundamentals
{
    public interface IDiscountStrategy
    {
        public decimal Calculate(decimal orderAmount);
    }


}
