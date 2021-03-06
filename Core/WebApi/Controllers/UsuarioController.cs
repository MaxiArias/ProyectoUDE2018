﻿using LogicaPersistencia;
using LogicaPersistencia.Excepciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.Models;

namespace WebApi.Controllers
{
    public class UsuarioController : ApiController
    {
       
    
        [ActionName("Login")]
        [HttpPost,HttpGet]
        [AcceptVerbs("GET", "POST")]
          public IHttpActionResult Login([FromBody] LoginRequest login)
        {
            try
            {
                IFachadaWeb fac = new FabricaFachadas().CrearFachadaWeb;
                fac.UsuarioLoginWEB(login.mail, login.password);
                return Ok(fac.DarIdUsuario(login.mail));
                
            }
            catch (UsuarioNoHabilitadoException)

            {
                return Unauthorized();
            }
            catch(LoginIncorrectoException)
            {
                return Unauthorized();
            }
            catch (UsuarioNoExisteException)
            {
                return Unauthorized();
            }
            catch (Exception)
            {
                return InternalServerError();
            }
        }

    }
}
