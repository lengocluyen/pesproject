using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PrimaryEducationSystem.Families.Helpers
{
    public static class Html
    {
        public static string ResolveUrl(this HtmlHelper helper, string virtualUrl)
        {
            HttpContext httpContext = System.Web.HttpContext.Current;
            string str = virtualUrl;
            if (!virtualUrl.StartsWith("~/", StringComparison.OrdinalIgnoreCase))
            {
                return str;
            }
            virtualUrl = virtualUrl.Remove(0, 2);
            string applicationPath = httpContext.Request.ApplicationPath;
            if (string.IsNullOrEmpty(applicationPath) || !applicationPath.EndsWith("/"))
            {
                applicationPath = applicationPath + "/";
            }

            return applicationPath + virtualUrl;
        } 
    }
}
