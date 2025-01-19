namespace Azon.Business
{
    internal class GoldCustomerDiscountStrategy
        : IDiscountStrategy
    {
        public decimal Apply(decimal amount)
        {
            return amount * 0.90M;
        }
    }
}
