using LogicaPersistencia;
using LogicaPersistencia.Excepciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi.Controllers
{
    public class CategoriaController : ApiController
    {
        
        [HttpGet]
        public IHttpActionResult ListarCategorias()
        {
            try
            {
                IFachadaWeb fac = new FabricaFachadas().CrearFachadaWeb;
                var categorias = fac.ListarCategoriasActivas();
                return Ok(categorias);
            }
            catch (Exception)
            {
                return InternalServerError();
            }
        }
    }
}

