﻿using System.Web;
using System.Web.Mvc;

namespace _0311KuzeyyeliMVC
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
