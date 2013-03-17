using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MemeBattle.Models
{
    public static class UrlHelperExtensions
    {
        //public static string WebApiRoute(string routeName, IDictionary<string, object> routeValues)
        //{
        //    var newRouteValues = new RouteValueDictionary(routeValues);
        //    newRouteValues.Add("httproute", string.Empty);
        //    return new UrlHelper(ControllerContext)
        //}


        public static string WebApiRoute(this UrlHelper urlHelper, string routeName, IDictionary<string, object> routeValues)
        {
            //urlHelper.ThrowIfArgumentNull("urlHelper");

            var newRouteValues = new RouteValueDictionary(routeValues);
            newRouteValues.Add("httproute", string.Empty);
            return urlHelper.RouteUrl(routeName, newRouteValues);
        }

        public static string WebApiRoute(this UrlHelper urlHelper, string routeName, object routeValues)
        {
            return WebApiRoute(urlHelper, routeName, new RouteValueDictionary(routeValues));
        }
    }
}