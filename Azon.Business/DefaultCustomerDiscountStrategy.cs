namespace Azon.Business
{
    internal class DefaultCustomerDiscountStrategy
        : IDiscountStrategy
    {
        public decimal Apply(decimal amount)
        {
            return amount;
        }
    }
}
