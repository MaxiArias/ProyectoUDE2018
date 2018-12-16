using LogicaPersistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.Models
{
       public class CreateClientPersona
        {
            public bool Activo { get; set; }
            public string Direccion { get; set; }
            public string Email { get; set; }
            public string Nombre { get; set; }
            public string Password { get; set; }
            public string Telefono { get; set; }
            public Enumerados.TipoCliente TipoCliente { get; set; }
            public Enumerados.TipoUsuario TipoUsuario { get; set; }
            public int Cedula { get; set; }

        }


    }
