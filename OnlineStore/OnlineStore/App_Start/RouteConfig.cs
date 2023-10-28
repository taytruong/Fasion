using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace OnlineStore
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            
            routes.MapRoute(
                name: "Products",
                url: "sản-phảm",
                defaults: new { controller = "Products", action = "Index", Alias = UrlParameter.Optional },
                namespaces: new[] { "OnlineStore.Controllers" }
            );

            routes.MapRoute(
                name: "CategoryProduct",
                url: "danh-muc-san-pham/{alias}-{id}",
                defaults: new { controller = "Products", action = "ProductCategory", id = UrlParameter.Optional },
                namespaces: new[] {"OnlineStore.Controllers"}            
            ); 
            
            routes.MapRoute(
                name: "DetailProduct",
                url: "chi-tiet/{alias}-p{id}",
                defaults: new { controller = "Products", action = "Detail", Alias = UrlParameter.Optional },
                namespaces: new[] {"OnlineStore.Controllers"}               
            );
            
            routes.MapRoute(
                name: "ShoppingCart",
                url: "gio-hang",
                defaults: new { controller = "ShoppingCart", action = "Index", Alias = UrlParameter.Optional },
                namespaces: new[] {"OnlineStore.Controllers"}               
            );
            
            routes.MapRoute(
                name: "CheckOut",
                url: "thanh-toan",
                defaults: new { controller = "ShoppingCart", action = "CheckOut", Alias = UrlParameter.Optional },
                namespaces: new[] {"OnlineStore.Controllers"}               
            );
            
            routes.MapRoute(
                name: "Contact",
                url: "lien-hẹ",
                defaults: new { controller = "Contact", action = "Index", Alias = UrlParameter.Optional },
                namespaces: new[] {"OnlineStore.Controllers"}                
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "OnlineStore.Controllers" }
            );
        }
    }
}
