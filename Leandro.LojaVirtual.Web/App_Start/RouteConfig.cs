using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Leandro.LojaVirtual.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");


            // Pagina 1
            routes.MapRoute(null, "", new
            {
                controller = "Vitrine",
                Action = "ListarPaginaProuto",
                categoria = (string)null,
                pagina = 1
            }
              );

            // Pagina 2
            routes.MapRoute(
                null,
                "Pagina{pagina}",
                new
                {
                    controller = "Vitrine",
                    Action = "ListarPaginaProuto",
                    categoria = (string)null
                },
                        new { pagina = @"\d+" }
                );

            // Pagina 3
            routes.MapRoute(null, "{categoria}",
                new
                {
                    controller = "Vitrine",
                    action = "ListarPaginaProduto",
                    pagina = 1
                });

            // Pagina 4
            routes.MapRoute(null, "{categoria}/Pagina{pagina}",
                new
                {
                    controller = "Vitrine",
                    action = "ListarPaginaProduto",
                },
                new { pagina = @"\d+" }
                );


            //Default
            routes.MapRoute(null, "{controller}/{action}");
        }
    }
}
