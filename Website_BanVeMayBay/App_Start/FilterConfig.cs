﻿using System.Web;
using System.Web.Mvc;

namespace Website_BanVeMayBay
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
