using FSL.Redemption.Mvc.Models.Old1;
using System.Web.Mvc;

namespace FSL.Redemption.Mvc.Controllers
{
    public class Old1Controller : Controller
    {
        private readonly ProductService _productService;

        public Old1Controller()
        {
            _productService = new ProductService();
        }

        // GET: Old1
        public ActionResult Index()
        {
            var allProducts = _productService.GetAllProducts();

            return View();
        }
    }
}