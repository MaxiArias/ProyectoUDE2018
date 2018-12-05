using LogicaPersistencia;
using System;
using LogicaPersistencia.Excepciones;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi.Controllers
{
    public class CarritoController : ApiController
    {

        [Route("api/DarCarrito")]
        [HttpGet]
        public IHttpActionResult DarCarrito(int usrid)
        {
            try
            {
                IFachadaWeb fac = new FabricaFachadas().CrearFachadaWeb;
                var idcarrito = fac.DarCarritoCliente(usrid);
                return Ok(idcarrito);
            }
            catch (Exception)
            {
                return InternalServerError();
            }
        }


        [Route("api/DelCarrito")]
        [HttpGet]
        public IHttpActionResult BorrarCarrito(int usrid)
        {
            try
            {
                IFachadaWeb fac = new FabricaFachadas().CrearFachadaWeb;
                fac.BorrarCarrito(usrid);
                return Ok();
            }
            catch (CarritoNoExisteException)
            {
                return NotFound();
            }
        }
    }



}
