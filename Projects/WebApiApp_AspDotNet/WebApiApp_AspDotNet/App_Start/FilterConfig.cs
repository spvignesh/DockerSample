﻿using System.Web;
using System.Web.Mvc;

namespace WebApiApp_AspDotNet
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
