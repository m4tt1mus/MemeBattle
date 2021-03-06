﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace MemeBattle
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.Routes.MapHttpRoute(
                name: "Api",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            // This removes XML request support, but makes things return in JSON by default
            var appXmlType = config.Formatters.XmlFormatter
                .SupportedMediaTypes.FirstOrDefault(t => t.MediaType == "application/xml");
            config.Formatters.XmlFormatter.SupportedMediaTypes.Remove(appXmlType);
        }
    }
}
