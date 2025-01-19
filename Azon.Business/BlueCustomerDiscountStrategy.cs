namespace Azon.Business
{
    internal class BlueCustomerDiscountStrategy
        : IDiscountStrategy
    {
        public decimal Apply(decimal amount)
        {
            return amount * 0.95M;
        }
    }
}
