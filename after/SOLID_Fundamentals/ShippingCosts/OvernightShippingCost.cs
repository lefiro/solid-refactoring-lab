namespace SOLID_Fundamentals
{
    public class OvernightShippingCost : IShippingCost
    {
        public decimal CalculateCost(decimal weight)
        {
            return 25.00m + (weight * 2.0m);
        }
    }



}
