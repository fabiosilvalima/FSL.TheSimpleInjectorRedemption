using FSL.Redemption.Mvc.Models.Old2;
using System.Web.Mvc;

namespace FSL.Redemption.Mvc.Controllers
{
    public class Old2Controller : Controller
    {
        private readonly ProductService _productService;

        public Old2Controller()
        {
            var repository = new SqlProductRepository();
            _productService = new ProductService(repository);
        }

        // GET: Old2
        public ActionResult Index()
        {
            var allProducts = _productService.GetAllProducts();

            return View();
        }
    }
}