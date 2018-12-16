using LogicaPersistencia;
using System;
using LogicaPersistencia.Excepciones;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Modelo.ValueObjects;
using WebApi.Models;


namespace WebApi.Controllers
{
    public class ItemCarritoController : ApiController
    {

        [ActionName("InsertItem")]
        [HttpPost]
        [AcceptVerbs("POST")]
        public IHttpActionResult InsertarItemCarrito([FromBody] CreateItemCarrito items)
        {
            try
            {
                IFachadaWeb fac = new FabricaFachadas().CrearFachadaWeb;
                ItemCarritoInsVO itemvo = new ItemCarritoInsVO();
                itemvo.IdCarrito = items.
                itemvo.IdProducto = items.IdProducto;
                itemvo.Cantidad = items.Cantidad;
                fac.AgregarItemCarrito(itemvo);
                return Ok();
            }
            catch (UsuarioYaExisteException)
            {
                return Conflict();
            }

        }

        [ActionName("DeleteItem")]
        [HttpDelete]
        [AcceptVerbs("DELETE")]
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



