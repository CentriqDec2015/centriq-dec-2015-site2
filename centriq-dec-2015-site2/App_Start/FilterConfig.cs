using System.Web;
using System.Web.Mvc;

namespace centriq_dec_2015_site2
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
