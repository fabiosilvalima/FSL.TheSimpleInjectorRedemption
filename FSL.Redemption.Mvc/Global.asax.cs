using FSL.Redemption.Mvc.Models.DI;
using SimpleInjector;
using SimpleInjector.Integration.Web.Mvc;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace FSL.Redemption.Mvc
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            RegisterContainer();
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        private void RegisterContainer()
        {
            var container = new Container();

            // 2. Configure the container (register)
            // See below for more configuration examples
            container.Register<IProductRepository, SqlProductRepository>(Lifestyle.Singleton);
            container.Register<IProductService, ProductService>(Lifestyle.Singleton);

            // 3. Optionally verify the container's configuration.
            container.Verify();

            // 4. Store the container for use by the application
            DependencyResolver.SetResolver(
                new SimpleInjectorDependencyResolver(container));

        }
    }
}
