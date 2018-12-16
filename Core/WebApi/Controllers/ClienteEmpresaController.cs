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
    public class ClienteEmpresaController : ApiController
    {
        [ActionName("RegisterEmpresa")]
        [HttpPost]
        [AcceptVerbs("POST")]
        public IHttpActionResult Persona([FromBody] CreateClientEmpresa empresa)
        {
            try
            {
                IFachadaWeb fac = new FabricaFachadas().CrearFachadaWeb;
                EmpresaVO emp = new EmpresaVO();
                emp.Rut = empresa.Rut;
                emp.Contacto = empresa.Contacto;
                emp.Direccion = empresa.Direccion;
                emp.Telefono = empresa.Telefono;
                emp.TipoCliente = empresa.TipoCliente.ToString();
                emp.Nombre = empresa.Nombre;
                emp.Email = empresa.Email;
                emp.Password = empresa.Password;
                emp.Activo = empresa.Activo;
                emp.TipoUsuario = emp.TipoUsuario.ToString();
                fac.InsertarCliente(emp);
                return Ok();
                
            }
            catch (UsuarioYaExisteException)
            {
                return Conflict();
            }

        }




    }
}
