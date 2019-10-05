using System.Web;
using System.Web.Mvc;

namespace MovieDatabase_ASP_MVCEF
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
