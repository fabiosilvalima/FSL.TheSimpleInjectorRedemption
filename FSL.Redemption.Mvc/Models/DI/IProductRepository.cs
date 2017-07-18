using System.Collections.Generic;

namespace FSL.Redemption.Mvc.Models.DI
{
    public interface IProductRepository
    {
        IList<string> GetllAllProducts(string criteria);
    }
}