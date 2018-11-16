using Modelo.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaPersistencia
{
    public partial class Usuario
    {
        public UsuarioVO DarUsuarioVO()
        {
            return new UsuarioVO(UsuarioId, UsuarioEmail, UsuarioContrasenia, UsuarioActivo, TipoUsuario);
           
        }

    }
}
