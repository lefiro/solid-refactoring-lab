namespace SOLID_Fundamentals
{
    public class InternationalShippinglCost : IShippingCost
    {
        private readonly IDestinationCost _destination;

        public InternationalShippinglCost(IDestinationCost destination)
        {
            _destination = destination;
        }
        public decimal CalculateCost(decimal weight)
        {
            return _destination.CalculateCost();
        }
    }



}
