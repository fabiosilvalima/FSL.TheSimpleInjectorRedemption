using System.Collections.Generic;

namespace FSL.Redemption.Mvc.Models.Old1
{
    public class ProductService
    {
        private readonly SqlProductRepository _productRepository;

        public ProductService()
        {
            _productRepository = new SqlProductRepository();
        }

        public IList<string> GetAllProductsByStatus()
        {
            var criteria = "Status=1";

            return _productRepository.GetAllProducts(criteria);
        }
    }
}