using System.Web;
using System.Web.Mvc;
using MVCCrud1.Filtros;

namespace MVCCrud1
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new VerificarSesion());
        }
    }
}
