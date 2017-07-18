using System.Collections.Generic;

namespace FSL.Redemption.Mvc.Models.Old2
{
    public class ProductService
    {
        private readonly SqlProductRepository _productRepository;

        public ProductService(SqlProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public IList<string> GetAllProducts()
        {
            var criteria = "Status=1";

            return _productRepository.GetAllProducts(criteria);
        }
    }
}