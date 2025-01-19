
namespace Azon.Business
{
    public class OrderingService
    {
        public OrderingService()
        {
        }

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
            decimal total = order.Amount;
            if (order.CustomerType== CustomerType.Gold)
            {
                total = order.Amount * 0.90M;
            }
            else if(order.CustomerType== CustomerType.Blue)
            {
                total = order.Amount * 0.95M;
            }
            return new Result<decimal>
            {
                Value = total,
                IsSuccess = true,
            };
            
        }
    }
}