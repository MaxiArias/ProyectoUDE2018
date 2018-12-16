using LogicaPersistencia;
using LogicaPersistencia.Excepciones;
using Modelo.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.Models;

namespace WebApi.Controllers
    
{
    public class ClientePersonaController : ApiController
    {

        [ActionName("RegisterPersona")]
        [HttpPost]
        [AcceptVerbs("POST")]
        public IHttpActionResult Persona([FromBody] CreateClientPersona persona)
        {
            try
            {
                IFachadaWeb fac = new FabricaFachadas().CrearFachadaWeb;
                PersonaVO per = new PersonaVO();
                per.Activo = persona.Activo;
                per.Direccion = persona.Direccion;
                per.Email = persona.Email;
                per.Nombre = persona.Nombre;
                per.Password = persona.Password;
                per.Telefono = persona.Telefono;
                per.TipoCliente = persona.TipoCliente.ToString();
                per.TipoUsuario = persona.TipoUsuario.ToString();
                per.Cedula = persona.Cedula;
                fac.InsertarCliente(per);
                return Ok();
            }
            catch (UsuarioYaExisteException)
            {
                return Conflict();
            }

        }




    }
}
