
namespace Azon.Business
{
    public class OrderingService
    {
        public Result<decimal> CalculateTotal(Order order)
        {
            if (order == null)
            {
                return new Result<decimal> { 
                    IsSuccess = false,
                    Value = 0,
                    ErrorMessage = "Invalid order"
                };
            }
            
            var discountStrategy = CustomerDiscountStrategyFactor.GetDiscountStrategy(order.CustomerType);
            var total = discountStrategy.Apply(order.Amount);
            
            /*
            switch (order.CustomerType)
            {
                case CustomerType.Gold:
                    total = order.Amount * 0.90M;
                    break;
                case CustomerType.Blue:
                    total = order.Amount * 0.95M;
                    break;
            }
            */
            return new Result<decimal>
            {
                Value = total,
                IsSuccess = true,
            };
            
        }
    }
}