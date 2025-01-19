﻿namespace Azon.Business
{
    public class CatalogService
    {
        private readonly IProductRepository _productRepository;
        public CatalogService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public decimal GetTotalPrice()
        {
            var products = _productRepository.GetProduct();
            return products.Sum(p => p.ListPrice);
        }


    }
}
