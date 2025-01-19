using Moq;

namespace Azon.Business.Test
{
    public class CatalogServiceTest
    {
        [Fact]
        public void GetTotalPrice_ProductPrice()
        {
            // Mock Framework olarak Moq isimli Nuget paketini kullanıyoruz.
            //Arange
            var mockProductRepository = new MockProductRepository();
            var catalogSerivce = new CatalogService(mockProductRepository);

            //Act
            var actual = catalogSerivce.GetTotalPrice();

            // Assert
            Assert.Equal(190.00M, actual);
        }

        [Fact]
        public void GetTotalPrice_ReturnValidTotal()
        {
            //Arrange
            var mockRepository = new Mock<IProductRepository>();
            var products = new List<Product>()
            {
                new Product { Id = 1, Name = "Screen", ListPrice = 100.00M },
                new Product { Id = 2, Name = "Book", ListPrice = 90.00M }
            };
            // Setup ile hangi metodu çağıracağımızı ve Returns işe de bu metot çağırldığında geriye ne döneceğini belirtiyouz.
            mockRepository.Setup(f => f.GetProduct()).Returns(products);
            
            // act
            var service = new CatalogService(mockRepository.Object);
            var actual = service.GetTotalPrice();

            //Assert
            Assert.Equal(190,actual);
        }
    }
}
