using System.Web;
using System.Web.Mvc;

namespace DotNetSheff.MongoDbBlog
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}