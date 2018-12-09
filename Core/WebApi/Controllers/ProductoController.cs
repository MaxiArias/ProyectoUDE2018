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
        public class ProductoController : ApiController
        {
        [HttpGet]
        public IHttpActionResult Get()
        {
            try
            {
                IFachadaWeb fac = new FabricaFachadas().CrearFachadaWeb;
                var productos = fac.ListarProductosHabilitados();
                return Ok(productos);
            }
            catch (Exception)
            { return InternalServerError();
            }
        }


        }
}
