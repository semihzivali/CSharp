namespace Azon.Business.Test
{
    // Red(FAil), Green(Success), Blue(REfactor)
    public class OrderingTests
    {
        [Fact]
        public void CalculateTotal_ForNullOrder()
        {
            Order order = null;

            var orderService = new OrderingService();

            var result = orderService.CalculateTotal(order);

            Assert.False(result.IsSuccess);
        }
        [Fact]
        public void CalculateTotal_ForGoldCustomer()
        {
            var order = new Order
            {
                Id = 1,
                Amount = 100,
                CustomerType = CustomerType.Gold
            };

            var orderService = new OrderingService();

            var result = orderService.CalculateTotal(order);

            Assert.Equal(90, result.Value);  // total e�ittir 0 olmas� gerekiyo di�er t�rl� hata 
        }

        [Fact]
        public void CalculateTotal_ForUnknownCustomerType()
        {
            Order order = new Order
            {
                Id = 2,
                CustomerType = CustomerType.Standart,
                Amount = 20
            };

            var orderService = new OrderingService();
            var result = orderService.CalculateTotal(order);
            Assert.Equal(order.Amount, result.Value);
        }
    }
}