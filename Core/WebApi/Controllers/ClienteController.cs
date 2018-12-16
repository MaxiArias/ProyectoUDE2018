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
        [ActionName("RegisterPersona")]
        [HttpPost]
        [AcceptVerbs("POST")]
        public IHttpActionResult Persona(PersonaVO cvo)
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

        [ActionName("RegisterEmpresa")]
        [HttpPost]
        [AcceptVerbs("POST")]
        public IHttpActionResult Empresa(EmpresaVO cvo)
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
