using System.Collections.Generic;

namespace FSL.Redemption.Mvc.Models.DI
{
    public class SqlProductRepository : IProductRepository
    {
        public IList<string> GetllAllProducts(string criteria)
        {
            return new List<string>() { "product1", "product2" };
        }
    }
}