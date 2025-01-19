using System.Net.Http.Headers;

namespace Azon.Business
{
    public static class CustomerDiscountStrategyFactor
    {
        public static IDiscountStrategy GetDiscountStrategy(CustomerType customerType)
        {
            switch (customerType)
            {
                case CustomerType.Gold:
                    return new GoldCustomerDiscountStrategy();
                case CustomerType.Blue:
                    return new BlueCustomerDiscountStrategy();
                default:
                    return new DefaultCustomerDiscountStrategy();
            }
        }
    }
}
