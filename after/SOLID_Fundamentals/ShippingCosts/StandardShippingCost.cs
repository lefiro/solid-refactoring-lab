namespace SOLID_Fundamentals
{
    public class StandardShippingCost : IShippingCost
    {
        public decimal CalculateCost(decimal weight)
        {
            return 5.00m + (weight * 0.5m);
        }
    }



}
