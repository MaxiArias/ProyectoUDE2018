using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Routing;

namespace WebApi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Configuración y servicios de API web

            // Rutas de API web
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
            name: "AuthentificateRoute",
            routeTemplate: "api/Usuario/Login;{mail};{password}",
            defaults: new
        {
            controller = "Usuario",
            action = "Login",
            mail = RouteParameter.Optional,
            password = RouteParameter.Optional
        },
        constraints: new { httpMethod = new HttpMethodConstraint(HttpMethod.Get) }
        );


         config.Routes.MapHttpRoute(
         name: "PersonaRoute",
         routeTemplate: "api/ClientePersona;{Activo};{Direccion};{Email};{Nombre};{Password};{Telefono};{TipoCliente};{TipoUsuario};{Cedula}",
         defaults: new
        {
            controller = "ClientePersona",
            action = "RegisterPersona",
            mail = RouteParameter.Optional,
            password = RouteParameter.Optional
        },
            constraints: new { httpMethod = new HttpMethodConstraint(HttpMethod.Post) }
        );


            config.Routes.MapHttpRoute(
            name: "EmpresaRoute",
            routeTemplate: "api/ClienteEmpresa;{Rut};{Contacto};{Direccion};{Telefono};{TipoCliente};{Nombre};{Email};{Password};{Activo};{TipoUsuario}",
            
          defaults: new
          {
              controller = "ClienteEmpresa",
              action = "RegisterEmpresa",
              mail = RouteParameter.Optional,
              password = RouteParameter.Optional
         },
               constraints: new { httpMethod = new HttpMethodConstraint(HttpMethod.Post) }
           );

            config.Routes.MapHttpRoute(
            name: "InsertItem",
            routeTemplate: "api/InsertItem;{IdCliente};{IdProducto};{Cantidad}",

          defaults: new
          {
              controller = "ItemCarrito",
              action = "InsertItem",
              mail = RouteParameter.Optional,
              password = RouteParameter.Optional
          },
               constraints: new { httpMethod = new HttpMethodConstraint(HttpMethod.Post) }
           );



            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );


        }
    }
}
