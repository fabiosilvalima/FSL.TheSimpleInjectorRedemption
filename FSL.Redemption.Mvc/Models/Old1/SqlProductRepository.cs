using System.Collections.Generic;

namespace FSL.Redemption.Mvc.Models.Old1
{
    public class SqlProductRepository
    {
        public IList<string> GetAllProducts(string criteria)
        {
            return new List<string>() { "product1", "product2" };
        }
    }
}