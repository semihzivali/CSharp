namespace Azon.Business
{
    public class Order
    {
        public int Id { get; set; }
        public int Amount { get; set; }
        public CustomerType CustomerType { get; set; }
    }
}