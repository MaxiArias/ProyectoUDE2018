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
        public IHttpActionResult ListarProductos()
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
     
        //Get api/Producto/5
        /*[HttpGet]
        public IEnumerable<ProductoVO> Get (int catid)
        {
                IFachadaWeb fac = new FabricaFachadas().CrearFachadaWeb;
                var productoscat = fac.ListarProductosPorCategoriaHabilitados(catid);
                return productoscat;
        }*/

        //Get api/Producto/5
        [HttpGet]
        public IHttpActionResult ListarProductosCategoria(int catid)
        {
            try
            {
                IFachadaWeb fac = new FabricaFachadas().CrearFachadaWeb;
                var productoscat = fac.ListarProductosPorCategoriaHabilitados(catid);
                return Ok(productoscat);
            }
            catch (CategoriaNoExisteException)
            {
                return NotFound();
            }
            catch (Exception)
            {
                return InternalServerError();
            }
        }


    }
}
