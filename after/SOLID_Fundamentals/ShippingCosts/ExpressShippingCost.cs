namespace SOLID_Fundamentals
{
    public class ExpressShippingCost : IShippingCost
    {
        public decimal CalculateCost(decimal weight)
        {
            return 15.00m + (weight * 1.0m);
        }
    }



}
