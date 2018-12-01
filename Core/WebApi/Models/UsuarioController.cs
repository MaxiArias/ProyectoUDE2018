using LogicaPersistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi.Models
{
    public class UsuarioController : ApiController
    {

        public bool GetUsuarioLogin(String mail, String password)
        {
            IFachadaWeb fac = new FabricaFachadas().CrearFachadaWeb;
            return fac.UsuarioLogin(mail, password);
        }
    }

}
