﻿using System.Web;
using System.Web.Mvc;

namespace Comp2084_CarStore
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
