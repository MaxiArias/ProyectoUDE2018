using LogicaPersistencia;
using LogicaPersistencia.Excepciones;
using Modelo;
using Modelo.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi.Controllers
{
    public class ClienteController : ApiController
    {
   
        [HttpPost]
        public IHttpActionResult InsertarCliente(ClienteVO cvo)
        {
            try
            {
                IFachadaWeb fac = new FabricaFachadas().CrearFachadaWeb;
                fac.InsertarCliente(cvo);
                return Ok();
            }
            catch (UsuarioYaExisteException)
            {
                return Conflict();
            }

        }
        
   
    }
}
