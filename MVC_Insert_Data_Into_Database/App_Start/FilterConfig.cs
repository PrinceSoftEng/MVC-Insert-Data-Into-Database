﻿using System.Web;
using System.Web.Mvc;

namespace MVC_Insert_Data_Into_Database
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
