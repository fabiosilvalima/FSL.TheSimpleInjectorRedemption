using System.Collections.Generic;

namespace FSL.Redemption.Mvc.Models.DI
{
    public interface IProductService
    {
        IList<string> GetAllProductsByStatus();
    }
}