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
    public class MonedaController : ApiController
    {
        [Route("api/Moneda")]
        [HttpGet]
        public IHttpActionResult DarMonedas()
        {
            try
            {
                IFachadaWeb fac = new FabricaFachadas().CrearFachadaWeb;
                var monedas = fac.ListarMonedas();
                return Ok(monedas);
            }
            catch (Exception)
            {
                return InternalServerError();
            }
        }
    }
}
