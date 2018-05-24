using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace WebApi2_Produtos
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            // Macoratti colocou esse código para forçar sempre retornar JSON, só que assim nunca terá a opção por XML.
            // Teria algum problema deixar?
            // Será que teria que passar o formato desejado no HEADER?
            var formatters = GlobalConfiguration.Configuration.Formatters;
            formatters.Remove(formatters.XmlFormatter);
        }
    }
}
