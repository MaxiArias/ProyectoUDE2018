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
    public class UsuarioController : ApiController
    {
        
        [HttpPost]
        public IHttpActionResult GetUsuarioLogin(String mail, String password)
        {
            try
            {
                IFachadaWeb fac = new FabricaFachadas().CrearFachadaWeb;
                fac.UsuarioLoginWEB(mail, password);
                return Ok(fac.DarIdUsuario(mail));
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
