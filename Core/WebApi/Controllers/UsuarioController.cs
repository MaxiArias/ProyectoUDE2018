using LogicaPersistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi.Controllers
{
    public class UsuarioController : ApiController
    {

        public void GetUsuarioLogin(String mail, String password, out bool existeusr, out bool loginok)
        {
            IFachadaWeb fac = new FabricaFachadas().CrearFachadaWeb;
            fac.UsuarioLogin(mail, password, out existeusr, out loginok);
        }


    }
}
