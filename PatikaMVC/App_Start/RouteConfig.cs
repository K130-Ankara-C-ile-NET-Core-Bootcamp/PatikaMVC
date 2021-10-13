using System.Web.Mvc;
using System.Web.Routing;

namespace PatikaMVC
{
    public class RouteConfig
    {
        // Route sıralaması önemlidir. Üstteki route match olursa yönlendirme oraya gerçekleşir
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // site.com/home linki HomeController Index action'a yönlenir
            routes.MapRoute(
               "routeTest",
               "home",
               new { controller = "Home", action = "Index" });

            // site.com/about linki HomeController About action'a yönlenir
            routes.MapRoute(
               "routeTest2",
               "about",
               new { controller = "Home", action = "About" });

            // site.com linki HomeController Index action'a yönlenir
            // site.com/controller linki verilen controllerın Index'ine yönlenir
            // site.com/controller/action linki verilen controllerın verilen action'a yönlenir
            // site.com/controller/action/id linki verilen controllerın verilen action'a yönlenir ve id parametresini action'a paslar
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
