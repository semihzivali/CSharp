namespace Azon.Business.Test
{
    public class MockProductRepository
        : IProductRepository
    {
        public IEnumerable<Product> GetProduct()
        {
            return new List<Product>
            {
                 new Product { Id = 1, Name = "Screen", ListPrice = 100.00M },
                 new Product { Id = 2, Name = "Book", ListPrice = 90.00M }
            };
        }
    }
}
