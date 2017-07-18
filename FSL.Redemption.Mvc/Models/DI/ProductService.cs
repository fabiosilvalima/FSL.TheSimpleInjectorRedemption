using System.Collections.Generic;

namespace FSL.Redemption.Mvc.Models.DI
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        
        public IList<string> GetAllProducts()
        {
            var criteria = "Status=1";

            return _productRepository.GetllAllProducts(criteria);
        }
    }
}