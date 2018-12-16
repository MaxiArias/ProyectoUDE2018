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

        //public class CreateClientPersona
        //{
        //    public bool Activo { get; set; }
        //    public string Direccion { get; set; }
        //    public string Email { get; set; }
        //    public string Nombre { get; set; }
        //    public string Password { get; set; }
        //    public string Telefono { get; set; }
        //    public Enumerados.TipoCliente TipoCliente { get; set; }
        //    public Enumerados.TipoUsuario TipoUsuario { get; set; }
        //    public int Cedula { get; set; }

        //}

        [ActionName("RegisterPersona")]
        [HttpPost]
        [AcceptVerbs("POST")]
        public IHttpActionResult Persona([FromBody] PersonaVO persona)
        {
            try
            {
                IFachadaWeb fac = new FabricaFachadas().CrearFachadaWeb;
                fac.InsertarCliente(persona);
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
        public IHttpActionResult Empresa([FromBody] EmpresaVO empresa)
        {
            try
            {
                IFachadaWeb fac = new FabricaFachadas().CrearFachadaWeb;
                fac.InsertarCliente(empresa);
                return Ok();
            }
            catch (UsuarioYaExisteException)
            {
                return Conflict();
            }

        }


    }
}
