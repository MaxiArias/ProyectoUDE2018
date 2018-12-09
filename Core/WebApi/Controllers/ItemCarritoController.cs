using LogicaPersistencia;
using System;
using LogicaPersistencia.Excepciones;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Modelo.ValueObjects;

namespace WebApi.Controllers
{
    public class ItemCarritoController : ApiController
    {
        
        [HttpPost]
        public IHttpActionResult InsertarItemCarrito(int cliid, ItemCarritoVO item)
        {
            try
            {
                IFachadaWeb fac = new FabricaFachadas().CrearFachadaWeb;
                fac.AgregarItemCarrito(cliid, item);
                return Ok();
            }
            catch (UsuarioYaExisteException)
            {
                return Conflict();
            }

        }

        
        [HttpDelete]
        public IHttpActionResult BorrarItemCarrito(int cliid, int proid)
        {
            try
            {
                IFachadaWeb fac = new FabricaFachadas().CrearFachadaWeb;
                fac.BorrarItemCarrito(cliid, proid);
                return Ok();
            }
            catch (ClienteNoExisteException)
            {
                return NotFound();
            }

        }

    }

}



