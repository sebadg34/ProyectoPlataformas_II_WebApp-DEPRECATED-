using System.Web;
using System.Web.Mvc;

namespace AplicacionReservaVuelos_2021_S1
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
