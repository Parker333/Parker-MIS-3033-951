﻿using System.Web;
using System.Web.Mvc;

namespace MVC_EF_P_
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
